namespace Microsoft.Extensions.DependencyInjection
{
    using DXC.LM.SDK.HealthMetric.ConfigSections;
    using DXC.LM.SDK.HealthMetric.Extensions;

    using Microsoft.Extensions.Configuration;

    using Microsoft.AspNetCore.Builder;

    /// <summary>
    /// </summary>
    public static class IApplicationBuilderExtension
    {
        /// <summary>
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseMetricsMiddlewareFromConfiguration(this IApplicationBuilder builder,
            IConfiguration configuration)
        {
            var cfg = configuration.GetTypedSection<MetricsMiddleware>();

            if (cfg.UseMetricsActiveRequestMiddleware)
                builder.UseMetricsActiveRequestMiddleware();

            if (cfg.UseMetricsErrorTrackingMiddleware)
                builder.UseMetricsErrorTrackingMiddleware();

            if (cfg.UseMetricsPostAndPutSizeTrackingMiddleware)
                builder.UseMetricsPostAndPutSizeTrackingMiddleware();

            if (cfg.UseMetricsRequestTrackingMiddleware)
                builder.UseMetricsRequestTrackingMiddleware();

            if (cfg.UseMetricsRequestTrackingMiddleware)
                builder.UseMetricsRequestTrackingMiddleware();

            if (cfg.UseMetricsOAuth2TrackingMiddleware)
                builder.UseMetricsOAuth2TrackingMiddleware();

            if (cfg.UseMetricsApdexTrackingMiddleware)
                builder.UseMetricsApdexTrackingMiddleware();

            return builder;
        }

        /// <summary>
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseHealthEndpointsFromConfiguration(this IApplicationBuilder builder,        
            IConfiguration configuration)
        { 
            var cfg = configuration.GetTypedSection<HealthEndpoints>();

            if (cfg.UsePingEndpoint)
                builder.UsePingEndpoint();

            if (cfg.UseHealthEndpoint)
                builder.UseHealthEndpoint();

            return builder;
        }

        public static IApplicationBuilder UseMetricsEndpointsFromConfiguration(this IApplicationBuilder builder,
            IConfiguration configuration)
        {
            var cfg = configuration.GetTypedSection<MetricsEndpoints>();

            if(cfg.UseMetricsEndpoint)
                builder.UseMetricsEndpoint();

            if (cfg.UseMetricsTextEndpoint)
                builder.UseMetricsTextEndpoint();

            if (cfg.UseEnvInfoEndpoint)
                builder.UseEnvInfoEndpoint();

            return builder;
        }
    }
}
