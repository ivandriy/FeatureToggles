using System;

namespace FeatureTogglesExample.Infrastructure
{
    public class FeatureNotFoundException:Exception
    {
        private readonly string _feature;

        public FeatureNotFoundException(string feature)
        {
            _feature = feature;
        }
    }
}
