using System.Collections.Generic;

namespace FeatureTogglesExample.Infrastructure
{
    public interface IFeatureProvider
    {
        string this[string key] { get; }
    }
}
