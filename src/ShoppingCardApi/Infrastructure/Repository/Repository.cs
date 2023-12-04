using ShoppingCardApi.Domain;

namespace ShoppingCardApi.Infrastructure.Repository;

public class Repository<TEntity>:IRepository<TEntity> where TEntity: Entity
{
    private List<TEntity> _entities => new();
    
    public virtual async Task AddAsync(TEntity entity)
    {
        _entities.Add(entity);
         await Task.CompletedTask;
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
    

    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }
}