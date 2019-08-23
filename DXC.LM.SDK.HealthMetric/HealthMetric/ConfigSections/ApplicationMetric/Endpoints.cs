namespace DXC.LM.SDK.HealthMetric.ConfigSections.ApplicationMetric
{
    public class Endpoints
    {
        // (GG) This is an example of one of the classes I mention - it could be MetricEndpointsOptions, in which case
        // we could just use the provided data type.  We need the extra parameter to set the formatter types.  Maybe
        // AppMetrics has a way to do that which I just haven't came across yet.  
        // Even then though, setting the formatter from configuration, there are different options for each types of
        // formatter, so maybe there is a way to also set those options from configuration.
        public bool Enabled { get; set; }
        public EndpointConfiguration Metric { get; set; }
        public EndpointConfiguration Text { get; set; }
        public EndpointConfiguration EnvironmentInfo { get; set; }
    }
}
