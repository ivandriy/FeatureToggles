namespace FeatureTogglesExample.Infrastructure
{
    public class FeatureToggle:IFeatureToggle
    {
        private readonly IFeatureConfigProvider _provider;

        public FeatureToggle(IFeatureConfigProvider provider)
        {
            _provider = provider;
        }

        public bool IsFeatureEnabled(string feature)
        {
            return bool.Parse(_provider[feature]);
        }
    }
}
