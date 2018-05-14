using Microsoft.Extensions.DependencyInjection;

namespace FeatureTogglesExample.Infrastructure
{
    public static class FeatureExtensions
    {
        public static void AddFeatureDecisions(this IServiceCollection service)
        {
            service.AddSingleton(typeof(IFeatureDecisions), typeof(FeatureDecisions));
        }
    }
}
