namespace Fiver.Lib.Specification.StringSpecifications
{
    public class StartsWithSpecification : ISpecification<string>
    {
        private readonly string value;

        public StartsWithSpecification(string value)
        {
            this.value = value;
        }

        public bool IsSatisfied(string model) => model.StartsWith(value);
    }
}
