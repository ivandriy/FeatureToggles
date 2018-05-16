using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeatureTogglesExample.Infrastructure
{
    public interface IFeatureDecisions
    {
        bool IsFeatureEnabled(string feature);
    }
}
