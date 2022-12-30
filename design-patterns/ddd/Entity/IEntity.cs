using System;

namespace GoodToCode.Library.Patterns.Ddd
{
    public interface IEntity
    {
        Guid RowKey { get; }
        string PartitionKey { get; }
    }
}