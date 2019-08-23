using Microsoft.Extensions.Configuration;

namespace DXC.LM.SDK.HealthMetric.Extensions
{
    public static class ConfigurationExtensions
    {
        public static TSection GetTypedSection<TSection>(this IConfiguration configuration, string sectionName = null)
            where TSection : new()
        {
            if (sectionName == null)
            {
                sectionName = typeof(TSection).Name;
            }

            var section = configuration.GetSection(sectionName);
            var result = new TSection();
            section.Bind(result);

            return result;
        }
    }
}
