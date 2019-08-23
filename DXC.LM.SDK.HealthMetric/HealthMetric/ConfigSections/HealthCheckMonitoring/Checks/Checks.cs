using System.Collections.Generic;

namespace DXC.LM.SDK.HealthMetric.ConfigSections.HealthCheckMonitoring.Checks
{
    public class Checks
    {

        public MemoryChecks Memory { get; set; }

        public Dictionary<string, PingCheckOptions> Ping { get; set; }

        public Dictionary<string, HttpCheckOptions> Http { get; set; }
    }
}
