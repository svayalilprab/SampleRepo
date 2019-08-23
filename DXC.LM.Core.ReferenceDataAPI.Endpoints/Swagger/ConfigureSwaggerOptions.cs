using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// </summary>
namespace DXC.LM.Core.ReferenceDataAPI.Endpoints.Swagger
{
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.DependencyInjection.Extensions;
    using Microsoft.Extensions.Hosting;
    using Microsoft.Extensions.Options;

    using Microsoft.AspNetCore.Mvc.ApiExplorer;

    using Swashbuckle.AspNetCore.Swagger;
    using Swashbuckle.AspNetCore.SwaggerGen;

    /// <summary>
    /// Configures the Swagger generation options.
    /// </summary>
    /// <remarks>This allows API versioning to define a Swagger document per API version after the
    /// <see cref="IApiVersionDescriptionProvider"/> service has been resolved from the service container.</remarks>
    public class ConfigureSwaggerOptions : IConfigureOptions<SwaggerGenOptions>
    {
        readonly IHostingEnvironment environment;
        readonly IConfiguration configuration;
        readonly IApiVersionDescriptionProvider provider;

        /// <summary>
        /// </summary>
        /// <param name="environment"></param>
        /// <param name="configuration"></param>
        /// <param name="provider"></param>
        public ConfigureSwaggerOptions(
            IHostingEnvironment environment,
            IConfiguration configuration,
            IApiVersionDescriptionProvider provider)
        {
            this.environment = environment;
            this.configuration = configuration;
            this.provider = provider;
        }
        /// <inheritdoc />
        public void Configure(SwaggerGenOptions options)
        {
            var documentInfoSection = configuration.GetSection("openAPI");
            var documentInfo = new Info();

            documentInfoSection.Bind(documentInfo, _ => _.BindNonPublicProperties = true);

            // add a swagger document for each discovered API version
            // note: you might choose to skip or document deprecated API versions differently
            foreach (var description in provider.ApiVersionDescriptions)
            {
                if(description.IsDeprecated)
                    documentInfo.Title += " <u><b>DEPRECATED</b></u>";

                options.SwaggerDoc(
                    description.GroupName, documentInfo
                );
            }
        }

    }
}
