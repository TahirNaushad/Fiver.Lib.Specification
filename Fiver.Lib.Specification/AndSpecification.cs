namespace Fiver.Lib.Specification
{
    internal sealed class AndSpecification<T> : ISpecification<T>
    {
        private readonly ISpecification<T> left;
        private readonly ISpecification<T> right;

        internal AndSpecification(ISpecification<T> left, ISpecification<T> right)
        {
            this.left = left;
            this.right = right;
        }

        public bool IsSatisfied(T model)
            => this.left.IsSatisfied(model) &&
                this.right.IsSatisfied(model);
    }
}
