using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeatureTogglesExample.Infrastructure
{
    public class FeatureDecisions:IFeatureDecisions
    {
        private readonly IFeatureProvider _provider;

        public FeatureDecisions(IFeatureProvider provider)
        {
            _provider = provider;
        }

        public bool IsFeatureEnabled(string feature)
        {
            return bool.Parse(_provider[feature]);
        }
    }
}
