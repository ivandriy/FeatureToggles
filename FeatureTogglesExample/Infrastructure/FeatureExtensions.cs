using Microsoft.Extensions.DependencyInjection;

namespace FeatureTogglesExample.Infrastructure
{
    public static class FeatureExtensions
    {
        public static void AddFeatureToggles(this IServiceCollection service)
        {
            service.AddSingleton(typeof(IFeatureToggle), typeof(FeatureToggle));
        }
    }
}
