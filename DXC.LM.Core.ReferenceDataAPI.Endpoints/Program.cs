using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DXC.LM.SDK.SharedErrorHandling;
using DXC.LM.SDK.SharedErrorHandling.Interfaces;
using DXC.LM.SDK.SharedLogging.Interfaces;
using DXC.LM.SDK.SharedLogging.LoggingProvider;
using DXC.LM.SDK.WebApi;
using Microsoft.Extensions.Configuration.Json;
using NLog.Extensions.Logging;
using NLog.Web;

namespace DXC.LM.Core.ReferenceDataAPI.Endpoints
{
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.Logging;

    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;

    /// <summary>
    /// </summary>
    public class Program
    {
        private const string UserSecretsId = "4e59a5a3-b657-4c0a-af08-13866978bc41";

        private static ILoggerWrapper<Program> _logger;
        private static IErrorHandler<Program> _errorHandler;

        public static void Main(string[] args)
        {
            var startUpCorrelationId = Guid.NewGuid().ToString();

            try
            {
                var configuration = InitialiseConfiguration(new ConfigurationBuilder(), args).Build();
                InitialiseLoggingAndErrorHandling(configuration);

                IWebHost host;

                using (_logger.BeginScopeWithCommonData(startUpCorrelationId, null, null, null, true, false))
                {
                    _logger.LogInformation("Logging is all set up and ready to go");

                    _logger.LogInformation("About to call BuildWebHost");

                    host = WebHost.CreateDefaultBuilder(args)
                        .UseNLog()
                        .ConfigureServices(services =>
                        {
                            services.AddPlatformServices();
                        })
                        .ConfigureAppConfiguration(cfg => InitialiseConfiguration(cfg, args))
                        .ConfigureAppMetricsHostingConfiguration(options =>
                        {
                            options.AllEndpointsPort = configuration.GetValue<int>("MetricsEndpoints:AllEndpointsPort");
                        })
                        .UseStartup<Startup>()
                        .Build();

                    _logger.LogInformation("About to call webHost.Run");
                }

                host.Run();
            }
            catch (Exception ex)
                when (PassToErrorHandler(ex))
            {
                // Do not interfere with what would ordinarily happen if we didn't try to intercept because
                // upstream components will likely be catching exceptions and / or the checking the return code

                _logger.LogInformation("Microservice about to throw unhandled exception.  Process may be terminated.");
                throw;
            }

            _logger.LogInformation("Microservice instance is shutting down.");
        }

        private static IConfigurationBuilder InitialiseConfiguration(IConfigurationBuilder configuration, string[] args)
        {
            try
            {
                configuration.Sources.Clear();
                configuration.AddJsonFile("appmetrics.json", true, true);
                configuration.AddPlatformConfiguration(UserSecretsId, args);                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to initialise configuration: {ex}");
                throw;
            }

            return configuration;
        }

        private static void InitialiseLoggingAndErrorHandling(IConfiguration configuration)
        {
            try
            {
                StaticLoggingProvider.Initialise(configuration, new NLogLoggerFactory());

                _logger = StaticLoggingProvider.Create<Program>();
                _errorHandler = new ErrorHandler<Program>(_logger, configuration);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to initialise logging and error handling: " + ex);
                throw;
            }
        }

        private static bool PassToErrorHandler(Exception ex)
        {
            // See https://andrewlock.net/how-to-include-scopes-when-logging-exceptions-in-asp-net-core/
            // Check null so that if _errorHandler has somehow not been initialised, the exception is allowed to bubble up
            _errorHandler?.HandleError("A catastrophic error occured within the Microservice instance", new EventId(909090, "Unknown catastrophic error"), ex);

            return true;
        }
    }
}
