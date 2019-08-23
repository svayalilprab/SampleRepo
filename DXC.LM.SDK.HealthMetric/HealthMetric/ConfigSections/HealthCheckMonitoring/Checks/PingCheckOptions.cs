using System;

namespace DXC.LM.SDK.HealthMetric.ConfigSections.HealthCheckMonitoring.Checks
{
    public class PingCheckOptions
    {
        public string Endpoint { get; set; }
        public TimeSpan Timeout { get; set; }
        public bool Degraded { get; set; }
    }
}
