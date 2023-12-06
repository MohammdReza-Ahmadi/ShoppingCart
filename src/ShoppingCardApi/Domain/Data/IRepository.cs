namespace ShoppingCardApi.Domain;

public interface IRepository<TEntity>:IDisposable where TEntity: Entity
{
    Task AddAsync(TEntity entity);
    Task AddRangeAsync(List<TEntity> entity);
    Task DeleteAsync(TEntity entity);
    Task<TEntity> GetAsync(long id);
    Task<List<TEntity>> GetAllAsync();
}