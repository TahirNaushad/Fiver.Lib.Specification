namespace Fiver.Lib.Specification
{
    internal sealed class OrSpecification<T> : ISpecification<T>
    {
        private readonly ISpecification<T> left;
        private readonly ISpecification<T> right;

        internal OrSpecification(ISpecification<T> left, ISpecification<T> right)
        {
            this.left = left;
            this.right = right;
        }

        public bool IsSatisfied(T model)
            => this.left.IsSatisfied(model) ||
                this.right.IsSatisfied(model);
    }
}
