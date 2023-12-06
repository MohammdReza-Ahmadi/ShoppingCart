namespace ShoppingCardApi.Domain;

public interface IRepository<TEntity>:IDisposable where TEntity: Entity
{
    Task AddAsync(TEntity entity);
    Task AddRangeAsync(List<TEntity> entity);
    Task DeleteAsync(TEntity entity);
    Task<TEntity> GetAsync(Guid id);
    Task<List<TEntity>> GetAllAsync();
}