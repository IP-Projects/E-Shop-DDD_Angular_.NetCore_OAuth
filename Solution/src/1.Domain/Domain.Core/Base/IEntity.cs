namespace Domain.Core.Base
{
    public interface IEntity<TKey>: IEntity
    {
        TKey Id { get; set; }
    }

    public interface IEntity
    {
    }
}
