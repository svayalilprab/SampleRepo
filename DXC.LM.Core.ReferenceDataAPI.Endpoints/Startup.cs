using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DXC.LM.SDK.SharedLogging.Interfaces;
using DXC.LM.SDK.SharedLogging.LoggingProvider;
using DXC.LM.Core.ReferenceDataAPI.Endpoints.Db.Configuration;
using DXC.LM.Core.ReferenceDataAPI.Endpoints.Db.Helpers;
using DXC.LM.SDK.WebApi;
using DXC.LM.Core.ReferenceDataAPI.Endpoints.DistributedCache;
using DXC.LM.SDK.DistributedResponseCaching;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Redis;

namespace DXC.LM.Core.ReferenceDataAPI.Endpoints
{
    using System;
    using System.IO;
    using System.Text;

    using DXC.LM.Core.ReferenceDataAPI.Endpoints.EntityModel;
    using DXC.LM.Core.ReferenceDataAPI.Endpoints.Swagger;

    using Microsoft.AspNet.OData.Builder;
    using Microsoft.AspNet.OData.Extensions;
    using Microsoft.AspNetCore.Authentication.JwtBearer;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.ApiExplorer;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Options;
    using Microsoft.IdentityModel.Tokens;
    using StackExchange.Redis;
    using Swashbuckle.AspNetCore.Swagger;
    using Swashbuckle.AspNetCore.SwaggerGen;

    /// <summary>
    /// </summary>
    public class Startup
    {
        private static readonly ILoggerWrapper<Startup> Logger
            = StaticLoggingProvider.Create<Startup>();

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            var env = services.BuildServiceProvider()
                .GetRequiredService<IHostingEnvironment>();

            Logger.LogInformation("Registering second-line services in Startup.ConfigureServices");
            services.AddSingleton<IServiceCollection>(services);

            /*: configuration section "logging" : */
            services.AddLogging(builder =>
            {
                builder.AddConsole()
                    .AddDebug();
            });

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

            }).AddJwtBearerConfiguration(Configuration);
            services.AddAuthorizationConfiguration(Configuration);

            /*: configuration section "responseCaching" : */
            if (ShouldUseCaching(Configuration, out var redisCacheOptions))
            {
                services.AddDistributedRedisCache(options =>
                {
                    options.Configuration = redisCacheOptions.Configuration;
                    options.InstanceName = redisCacheOptions.InstanceName;
                });

                services.AddDistributedResponseCaching();
                services.AddTransient<IDistributedCacheManager, RedisDistributedCacheManager>();
            }

            // Database...
            var connectionStrings = new ConnectionStrings();
            Configuration.Bind("ConnectionStrings", connectionStrings);
            //if(env.IsDevelopment())
            //    services.AddDbContext<ReferenceDataDbContext>(options => { options.UseSqlite("Data Source=mydb.db"); });
            //else
                services.AddDbContext<ReferenceDataDbContext>(options => { options.UseSqlServer(connectionStrings.CoreReadDatabase); });
            services.AddUnitOfWork<ReferenceDataDbContext>();


            services.AddApiVersioning(options =>
            {
                options.ReportApiVersions = true;
            });

            services.AddVersionedApiExplorer(options =>
            {
                options.DefaultApiVersion = new ApiVersion(1, 0);
                options.AssumeDefaultVersionWhenUnspecified = true;
                options.GroupNameFormat = "'v'VVV";
                options.SubstituteApiVersionInUrl = true;
            });

            services.AddOData( )
                .EnableApiVersioning( options=> 
                {
                });
            services.AddODataApiExplorer(options =>
            {
                options.GroupNameFormat = "'v'VVV";
                options.SubstituteApiVersionInUrl = true;
            });

            services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();
            services.AddSwaggerGen(options =>
            {
                // add a custom operation filter which sets default values
                options.OperationFilter<SwaggerDefaultValues>();

                // tell swagger that we are using a JWT token
                // see: https://swagger.io/docs/specification/authentication/
                options.AddSecurityDefinition("Bearer", new ApiKeyScheme
                {
                    In = "header", Type = "apiKey",
                    Name = "Authorization",
                    Description = "JWT Authorization header using the Bearer scheme.",
                });

                // integrate xml comments
                // options.IncludeXmlComments(XmlCommentsFilePath);
            });
            services.AddPlatformComponents(options =>
            {
                options.AutoGenerateEmptyCorrelationId = false;
            });
            
            // Metrics
            services.AddMetricFromConfiguration(Configuration);
            services.AddHealthFromConfiguration(Configuration, builder =>
            {
                if (redisCacheOptions != null)
                {
                    //builder.HealthChecks
                    //   .AddRedisCheck(
                    //    "Redis connection check",
                    //    () => ConnectionMultiplexer.Connect(redisCacheOptions.Configuration),
                    //    TimeSpan.FromSeconds(90),
                    //    true);
                }

                if (!string.IsNullOrEmpty(connectionStrings.CoreReadDatabase))
                {
                    //builder.HealthChecks
                    //    .AddSqlCheck(
                    //        "Sql Database Check", 
                    //        connectionStrings.CoreReadDatabase, 
                    //        TimeSpan.FromSeconds(90), 
                    //        true
                    //    );
                }

            });


            services.AddMvc(options =>
            {
                //options.Filters.Add(
                //    new ResponseCacheAttribute
                //    {
                //        Duration = 3600,
                //        Location = ResponseCacheLocation.Any,
                //        VaryByQueryKeys = new[] {"*"}                
                //    });
            })
                .SetCompatibilityVersion(
                    CompatibilityVersion.Version_2_1
                );

            AddCors(services);

            Logger.LogInformation("Startup.ConfigureServices completed");
        }

        private static void AddCors(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder
                        .AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials());
            });
        }


        /// <summary>
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            Logger.LogInformation("Configuring the Microservice within Startup.Configure");

            app.UseWhen(_ =>
            {
                var isDevelopment = env.IsDevelopment();
                Logger.LogInformation($"env.IsDevelopment(): {isDevelopment}");
                return isDevelopment;
            },
            builder =>
            {
                builder.UseDeveloperExceptionPage();
                builder.UseDatabaseErrorPage();
            });

            app.UseWhen(_ =>
            {
                return !env.IsDevelopment();
            },
            builder =>
            {
                app.UseHsts();
            });
            //app.UseHttpsRedirection();    // <-- (gg) suspect this is handled by platform

            app.UseAuthentication();


            // app.UseResponseCompression();
            if (ShouldUseCaching(Configuration, out _))
            {
                app.UseDistributedResponseCaching();
            }
            app.UsePlatformComponents(); // <--- (GG) Middleware - to reinstate

            app.UseCors("CorsPolicy");

            app.UseMvc(builder =>
            {
                var modelBuilder = app.ApplicationServices
                    .GetRequiredService<VersionedODataModelBuilder>();

                builder.MapVersionedODataRoutes(
                    "odata", "api",
                    modelBuilder.GetEdmModels()
                );

                /// TODO:
                builder
                    .Select( )
                    .MaxTop(500)
                    .Filter( )
                    .Expand( )
                    .OrderBy( )
                    .Count( );
            });


            app.UseMetricsMiddlewareFromConfiguration(Configuration);
            app.UseMetricsEndpointsFromConfiguration(Configuration);
            app.UseHealthEndpointsFromConfiguration(Configuration);

            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                var provider = app.ApplicationServices
                    .GetRequiredService<IApiVersionDescriptionProvider>();
                // build a swagger endpoint for each discovered API version
                foreach (var description in provider.ApiVersionDescriptions)
                {
                    options.SwaggerEndpoint(
                        $"/swagger/{description.GroupName}/swagger.json",
                        description.GroupName.ToUpperInvariant()
                    );
                }
            });

            app.EnsureMigrationOfContext<ReferenceDataDbContext>();

            Logger.LogInformation("Startup.Configure completed");
        }

        private static bool ShouldUseCaching(IConfiguration cfg, out RedisCacheOptions redisCacheOptions)
        {
            redisCacheOptions = cfg.GetSection("RedisCacheOptions")
                .Get<RedisCacheOptions>();

            return !string.IsNullOrWhiteSpace(redisCacheOptions.InstanceName)
                    && !string.IsNullOrWhiteSpace(redisCacheOptions.Configuration);
        }
    }
}
