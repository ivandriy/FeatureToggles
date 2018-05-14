using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace FeatureTogglesExample.Infrastructure
{
    public class FeatureProvider:IFeatureProvider
    {
        private readonly IConfiguration _configuration;
        
        public FeatureProvider(IConfiguration configuration)
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
