using App.Metrics.AspNetCore.Tracking;

namespace DXC.LM.SDK.HealthMetric.ConfigSections.ApplicationMetric
{
    public class Tracking
    {
        public bool Enabled { get; set; }

        // (GG) Here, we can use the AppMetrics class directly.
        public MetricsWebTrackingOptions Options { get; set; }
    }
}
