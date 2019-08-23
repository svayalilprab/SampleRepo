namespace DXC.LM.SDK.HealthMetric.ConfigSections
{
    public class MetricsMiddleware
    {
        public bool UseMetricsActiveRequestMiddleware { get; set; }
        public bool UseMetricsErrorTrackingMiddleware { get; set; }
        public bool UseMetricsPostAndPutSizeTrackingMiddleware { get; set; }
        public bool UseMetricsRequestTrackingMiddleware { get; set; }
        public bool UseMetricsOAuth2TrackingMiddleware { get; set; }
        public bool UseMetricsApdexTrackingMiddleware { get; set; }
    }
}
