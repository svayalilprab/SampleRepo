namespace DXC.LM.SDK.HealthMetric.ConfigSections.ApplicationMetric
{
    public class Reports
    {
        public bool Enabled { get; set; }
        public ReportConfiguration Console { get; set; }
        public ReportConfiguration TextFile { get; set; }
    }
}
