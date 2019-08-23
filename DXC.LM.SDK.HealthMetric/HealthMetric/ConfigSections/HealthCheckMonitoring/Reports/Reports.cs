using App.Metrics.Health.Reporting.Slack;

namespace DXC.LM.SDK.HealthMetric.ConfigSections.HealthCheckMonitoring.Reports
{
    public class Reports
    {
        public bool Enabled { get; set; }

        public Metric Metric { get; set; }

        public SlackHealthAlertOptions Slack { get; set; }
    }
}
