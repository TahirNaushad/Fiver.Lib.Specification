namespace Fiver.Lib.Specification.StringSpecifications
{
    public class NotEmptySpecification : ISpecification<string>
    {
        public bool IsSatisfied(string model) => !string.IsNullOrEmpty(model);
    }
}
