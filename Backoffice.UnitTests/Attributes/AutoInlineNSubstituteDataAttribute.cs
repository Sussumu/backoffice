using AutoFixture.Xunit2;

namespace Backoffice.UnitTests.Attributes
{
    public class AutoInlineNSubstituteDataAttribute : CompositeDataAttribute
    {
        public AutoInlineNSubstituteDataAttribute(params object[] values)
            : base(new InlineDataAttribute(values),
                new AutoNSubstituteDataAttribute())
        {
        }
    }
}
