namespace FeatureTogglesExample.Infrastructure
{
    public interface IFeatureToggle
    {
        bool IsFeatureEnabled(string feature);
    }
}
