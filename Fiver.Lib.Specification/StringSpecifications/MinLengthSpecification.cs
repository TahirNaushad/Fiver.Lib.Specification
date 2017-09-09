namespace Fiver.Lib.Specification.StringSpecifications
{
    public class MinLengthSpecification : ISpecification<string>
    {
        private readonly int length;

        public MinLengthSpecification(int length)
        {
            this.length = length;
        }

        public bool IsSatisfied(string model) => model.Length > this.length;
    }
}
