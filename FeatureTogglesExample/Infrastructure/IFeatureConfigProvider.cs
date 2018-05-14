namespace FeatureTogglesExample.Infrastructure
{
    public interface IFeatureConfigProvider
    {
        string this[string key] { get; }
    }
}
