namespace DXC.LM.SDK.HealthMetric.ConfigSections.ApplicationMetric
{
    public class Outputs
    {
        public bool Enabled { get; set; }
        public OutputConfiguration Text { get; set; }
        public OutputConfiguration JSON { get; set; }
    }
}
