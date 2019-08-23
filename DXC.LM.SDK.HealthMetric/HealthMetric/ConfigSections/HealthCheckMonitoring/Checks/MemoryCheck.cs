namespace DXC.LM.SDK.HealthMetric.ConfigSections.HealthCheckMonitoring.Checks
{
    public class MemoryCheck
    {
        public class Unit
        {
            public const int KB = 1;
            public const int MB = KB * 1024;
            public const int GB = MB * 1024;
            public const int TB = GB * 1024;
        }

        public long ThresholdMB { get; set; }
        public bool Degraded { get; set; }
    }
}
