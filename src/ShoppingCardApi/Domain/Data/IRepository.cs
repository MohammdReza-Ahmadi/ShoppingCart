namespace ShoppingCartApi.Domain.Data;

public interface IRepository<TEntity>:IDisposable where TEntity: Entity
{


    Task<long> AddAsync(TEntity entity);

    Task DeleteAsync(TEntity entity);

    Task<TEntity> GetByIdAsync(long id);

    Task<List<TEntity>> GetAllAsync();

    Task<TEntity> GetByPerdicateAsync(Func<TEntity, bool> predicate);


}