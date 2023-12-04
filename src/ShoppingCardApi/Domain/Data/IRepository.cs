namespace ShoppingCardApi.Domain;

public interface IRepository<TEntity>:IDisposable where TEntity: Entity
{
    Task AddAsync(TEntity entity);
    Task DeleteAsync(TEntity entity);
    Task<TEntity> GetAsync(long id);
}