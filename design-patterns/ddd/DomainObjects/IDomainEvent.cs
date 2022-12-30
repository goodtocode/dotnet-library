
namespace GoodToCode.Library.Patterns.Ddd
{
    public interface IDomainEvent<T>
    {
        T Item { get; }
    }
}   