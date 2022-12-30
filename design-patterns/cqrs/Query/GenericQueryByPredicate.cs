using System;

namespace GoodToCode.Library.Patterns.Cqrs
{
    public class GenericQueryByPredicate<TEntity>
    {
        public Func<TEntity, bool> Predicate { get; }

        public GenericQueryByPredicate() { }

        public GenericQueryByPredicate(Func<TEntity, bool> predicate)
        {
            Predicate = predicate;
        }
    }
}
