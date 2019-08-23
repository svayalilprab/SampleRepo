namespace DXC.LM.SDK.HealthMetric.ConfigSections.HealthCheckMonitoring.Checks
{
    public class MemoryChecks
    {
        public bool Enabled { get; set; }
        public MemoryCheck Private { get; set; }
        public MemoryCheck Physical { get; set; }
        public MemoryCheck Virtual { get; set; }
    }
}
