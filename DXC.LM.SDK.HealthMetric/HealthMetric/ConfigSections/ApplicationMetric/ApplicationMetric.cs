namespace DXC.LM.SDK.HealthMetric.ConfigSections.ApplicationMetric
{
    public class ApplicationMetric
    {
        public bool Enabled { get; set; }
        public Tracking Tracking { get; set; }
        public Outputs Outputs { get; set; }
        public Reports Reports { get; set; }
        public Endpoints Endpoints { get; set; }
    }
}
