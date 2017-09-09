namespace Fiver.Lib.Specification
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T model);
    }
}
