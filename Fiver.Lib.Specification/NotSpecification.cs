namespace Fiver.Lib.Specification
{
    internal sealed class NotSpecification<T> : ISpecification<T>
    {
        private readonly ISpecification<T> spec;

        internal NotSpecification(ISpecification<T> spec)
        {
            this.spec = spec;
        }

        public bool IsSatisfied(T model) => !this.spec.IsSatisfied(model);
    }
}
