using Microsoft.Extensions.Configuration;

namespace FeatureTogglesExample.Infrastructure
{
    public class ConfigProvider:IFeatureConfigProvider
    {
        private readonly IConfiguration _configuration;

        public ConfigProvider(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string this[string key]
        {
            get
            {
                var featureValue = _configuration[$"{c_featureSection}:{key}"];
                if (string.IsNullOrWhiteSpace(featureValue))
                    new FeatureNotFoundException(key);
                return featureValue;

            }
        }

        private const string c_featureSection = "Features";
    }
}
