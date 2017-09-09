namespace Fiver.Lib.Specification.StringSpecifications
{
    public class MaxLengthSpecification : ISpecification<string>
    {
        private readonly int length;

        public MaxLengthSpecification(int length)
        {
            this.length = length;
        }

        public bool IsSatisfied(string model) => model.Length <= this.length;
    }
}
