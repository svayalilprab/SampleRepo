using System;
using System.IO;

namespace Microsoft.Extensions.DependencyInjection
{
    using App.Metrics.Extensions.Configuration;
    using App.Metrics;
    using App.Metrics.Formatters;
    using App.Metrics.Formatters.Ascii;
    using App.Metrics.Formatters.Json;
    using App.Metrics.Formatters.Prometheus;

    using DXC.LM.SDK.HealthMetric.ConfigSections;
    using DXC.LM.SDK.HealthMetric.ConfigSections.ApplicationMetric;
    using DXC.LM.SDK.HealthMetric.Extensions;

    using Configuration;

    /// <summary>
    /// </summary>
    public static partial class IServiceCollectionExtension
    {            
        public static IServiceCollection AddMetricFromConfiguration(
                this IServiceCollection services,
                IConfiguration configuration
            )
        {
            var cfg = configuration.GetTypedSection<ApplicationMetric>();

            if (cfg is null || cfg.Enabled == false)
                return services;
                                   
            var metricBuilder = AppMetrics
                .CreateDefaultBuilder()
                .Configuration.ReadFrom(configuration);

            SetupOutputs(metricBuilder, cfg.Outputs);
            SetupReports(metricBuilder, cfg.Reports);
            
            var metricsRoot = metricBuilder.Build();
            services.AddMetrics(metricsRoot);

            SetupTracking(services, cfg.Tracking);
            SetupEndpoints(services, cfg.Endpoints);
            
            services.AddMetricsReportingHostedService();

            return services;
        }

        private static void SetupOutputs(IMetricsBuilder metricBuilder, Outputs outputs)
        {
            if (!outputs.Enabled)
                return;

            if (outputs.Text.Enabled)
                metricBuilder.OutputMetrics.AsPlainText();

            if (outputs.JSON.Enabled)
                metricBuilder.OutputMetrics.AsJson();
        }

        private static void SetupReports(IMetricsBuilder metricBuilder, Reports reports)
        {
            if (!reports.Enabled)
                return;

            if (reports.Console.Enabled)
                metricBuilder.Report.ToConsole();

            // TODO: maybe need do a TextFileReport with rollover ?
            if (reports.TextFile.Enabled)
            {
                var metricFilePath = Path.Combine(Directory.GetCurrentDirectory(), $"{DateTime.Now:yyyyMMdd-HHmmss}.metrics");

                metricBuilder.Report.ToTextFile( options =>
                {
                    options.OutputPathAndFileName = metricFilePath;
                    options.AppendMetricsToTextFile = true;
                    options.FlushInterval = TimeSpan.FromSeconds(30);
                });
            }
        }

        private static void SetupTracking(IServiceCollection services, Tracking tracking)
        {
            if (tracking.Enabled && tracking.Options != null)
                services.AddMetricsTrackingMiddleware(options => options = tracking.Options);
        }

        private static void SetupEndpoints(IServiceCollection services, Endpoints endpoints)
        {
            if (!endpoints.Enabled)
                return;

            services.AddMetricsEndpoints(options => {
                options.MetricsEndpointEnabled = endpoints.Metric.Enabled;
                options.MetricsTextEndpointEnabled = endpoints.Text.Enabled;
                options.EnvironmentInfoEndpointEnabled = endpoints.EnvironmentInfo.Enabled;

                var metricsFormatter = GetMetricsFormatter(endpoints.Metric.Formatter);
                if (metricsFormatter != null)
                    options.MetricsEndpointOutputFormatter = GetMetricsFormatter(endpoints.Metric.Formatter);

                var metricsTextFormatter = GetMetricsFormatter(endpoints.Text.Formatter);
                if (metricsTextFormatter != null)
                    options.MetricsTextEndpointOutputFormatter = metricsTextFormatter;


                var envInfoFormatter = GetEndInfoFormatter(endpoints.EnvironmentInfo.Formatter);
                if (envInfoFormatter != null)
                    options.EnvInfoEndpointOutputFormatter = envInfoFormatter;
            });
        }

        private static IEnvOutputFormatter GetEndInfoFormatter(string name)
        {
            switch (name)
            {
                case "text":
                    return new EnvInfoTextOutputFormatter();

                case "json":
                    return new EnvInfoJsonOutputFormatter();

                default:
                    return null;
            }
        }

        private static IMetricsOutputFormatter GetMetricsFormatter(string name)
        {
            switch (name)
            {
                case "text":
                    return new MetricsTextOutputFormatter();   

                case "json":
                    return new MetricsJsonOutputFormatter();

                case "prometheusText":
                    return new MetricsPrometheusTextOutputFormatter();

                case "prometheusProtobuf":
                    return new MetricsPrometheusProtobufOutputFormatter();

                default:
                    return null;
            }
        }
    }
}
