namespace movies.core.Entities.Base;

public abstract class EntityBase<TId>:IEntityBase<TId>
{
    public virtual TId Id { get; protected set; }
}