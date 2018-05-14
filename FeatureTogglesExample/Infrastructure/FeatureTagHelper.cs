using Microsoft.AspNetCore.Razor.TagHelpers;

namespace FeatureTogglesExample.Infrastructure
{
    public class FeatureTagHelper:TagHelper
    {
        private readonly IFeatureDecisions _decisions;

        [HtmlAttributeName("name")]
        public string Name { get; set; }

        public FeatureTagHelper(IFeatureDecisions decisions)
        {
            _decisions = decisions;
        }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagMode = TagMode.StartTagAndEndTag;
            output.TagName = "DIV";
            if (!_decisions.IsFeatureEnabled(Name))
            {
                output.SuppressOutput();
            }
        }
    }
}
