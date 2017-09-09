using Fiver.Lib.Specification;
using Fiver.Lib.Specification.StringSpecifications;
using Xunit;

namespace Fiver.Lib.Validation.Tests
{
    public class SpecificationTests
    {
        [Fact(DisplayName = "Using_spec")]
        public void Using_spec()
        {
            var spec = new NotEmptySpecification()
                  .And(new StartsWithSpecification("T"));

            var result = spec.IsSatisfied("Tahir");

            Assert.True(result);
        }
    }
}
