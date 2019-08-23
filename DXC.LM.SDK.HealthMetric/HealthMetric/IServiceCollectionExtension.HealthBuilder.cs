using System;

namespace Microsoft.Extensions.DependencyInjection
{
    using DXC.LM.SDK.HealthMetric.ConfigSections.HealthCheckMonitoring;
    using DXC.LM.SDK.HealthMetric.ConfigSections.HealthCheckMonitoring.Checks;
    using DXC.LM.SDK.HealthMetric.ConfigSections.HealthCheckMonitoring.Reports;
    using DXC.LM.SDK.HealthMetric.Extensions;

    using App.Metrics;
    using App.Metrics.Health;
    using Configuration;

    /// <summary>
    /// </summary>
    public static partial class IServiceCollectionExtension
    {
        public static IServiceCollection AddHealthFromConfiguration(
                this IServiceCollection serviceCollection,
                IConfiguration configuration, Action<IHealthBuilder> setup = null
            )
        {
            var cfg = configuration.GetTypedSection<HealthCheckMonitoring>();
            if (cfg == null || cfg.Enabled == false)
            {
                return serviceCollection;
            }

            var serviceProvider = serviceCollection
                .BuildServiceProvider();

            var healthBuilder = AppMetricsHealth
                .CreateDefaultBuilder();

            SetupChecks(cfg.Checks, healthBuilder);            
            SetupReports(cfg.Reports, serviceProvider, healthBuilder);

            if (setup != null)
                setup.Invoke(healthBuilder);

            serviceCollection.AddHealthEndpoints();
            healthBuilder.BuildAndAddTo(serviceCollection);

            return serviceCollection;
        }

        private static void SetupChecks(Checks checks, IHealthBuilder healthBuilder)
        {
            void AddMemoryCheck(string name, MemoryCheck memoryCheck,  Func<string, long, bool, IHealthBuilder> addAction)
            {
                if (memoryCheck.ThresholdMB > 0)
                {
                    addAction(name, memoryCheck.ThresholdMB * MemoryCheck.Unit.MB, memoryCheck.Degraded);
                }
            }

            if (checks == null || !checks.Memory.Enabled)
                return;

            AddMemoryCheck("Private memory size", 
                checks.Memory.Private, 
                healthBuilder.HealthChecks.AddProcessPrivateMemorySizeCheck);

            AddMemoryCheck("Physical memory size",
                checks.Memory.Physical,
                healthBuilder.HealthChecks.AddProcessPhysicalMemoryCheck);

            AddMemoryCheck("Virtual memory size",
                checks.Memory.Virtual,
                healthBuilder.HealthChecks.AddProcessVirtualMemorySizeCheck);


            // Ping Checks
            foreach (var (k, v) in checks.Ping)
            {
                healthBuilder.HealthChecks.AddPingCheck($"PING Check {k}", v.Endpoint, v.Timeout, v.Degraded);
            }

            // Http Checks
            foreach (var (k, v) in checks.Http)
            {
                if (Uri.TryCreate(v.Endpoint, UriKind.Absolute, out var uri))
                {
                    healthBuilder.HealthChecks.AddHttpGetCheck($"HTTP Check {k}", uri, v.Timeout, v.Degraded);
                }
            }
        }

        private static void SetupReports(Reports reports, IServiceProvider serviceProvider, IHealthBuilder healthBuilder)
        {
            if (reports == null || !reports.Enabled)
                return;

            if (reports.Metric.Enabled)
            {
                var metricRoot = serviceProvider.GetService<IMetricsRoot>();
                healthBuilder.Report.ToMetrics(metricRoot);
            }

            if (reports.Slack.Enabled)
            {
                healthBuilder.Report.ToSlack(reports.Slack);
            }
        }
    }
}
