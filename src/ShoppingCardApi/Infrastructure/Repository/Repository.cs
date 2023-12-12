using ShoppingCartApi.Domain;

namespace ShoppingCartApi.Infrastructure.Repository;

public class Repository<TEntity>:IRepository<TEntity> where TEntity: Entity
{
    private static readonly List<TEntity> _entities = new();
    
    public virtual async Task<long> AddAsync(TEntity entity)
    {
        _entities.Add(entity);
        return await Task.FromResult(entity.Id);
    }

    public async Task AddRangeAsync(List<TEntity> entity)
    {
        _entities.AddRange(entity);
    }

    public async Task DeleteAsync(TEntity entity)
    {
        _entities.Remove(entity);
        await Task.CompletedTask;
    }

    public virtual async Task<TEntity> GetAsync(long id)
    { 
        return await Task.FromResult(_entities.SingleOrDefault(entity => entity.Id == id));
    }

    public async Task<List<TEntity>> GetAllAsync()
    {
        return await Task.FromResult(_entities);
    }


    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }
}