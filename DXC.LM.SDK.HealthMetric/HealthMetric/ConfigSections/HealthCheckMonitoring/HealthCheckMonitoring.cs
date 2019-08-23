namespace DXC.LM.SDK.HealthMetric.ConfigSections.HealthCheckMonitoring
{
    public class HealthCheckMonitoring
    {
        public bool Enabled { get; set; }
        public Checks.Checks Checks { get; set; }
        public Reports.Reports Reports { get; set; }
    }
}
