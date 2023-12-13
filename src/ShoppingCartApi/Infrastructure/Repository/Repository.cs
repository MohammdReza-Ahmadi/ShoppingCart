using ShoppingCartApi.Domain;
using ShoppingCartApi.Domain.Data;

namespace ShoppingCartApi.Infrastructure.Repository;

public class Repository<TEntity>:IRepository<TEntity> where TEntity: Entity
{




    private static readonly List<TEntity> _entities = new();
    



    public virtual async Task<long> AddAsync(TEntity entity)
    {
        _entities.Add(entity);
        return await Task.FromResult(entity.Id);
    }




    public async Task DeleteAsync(TEntity entity)
    {
        _entities.Remove(entity);
        await Task.CompletedTask;
    }




    public virtual async Task<TEntity> GetByIdAsync(long id)
    { 
        return await Task.FromResult(_entities.SingleOrDefault(entity => entity.Id == id));
    }




    public async Task<TEntity> GetByPerdicateAsync(Func<TEntity,bool> predicate)
    {
        if (_entities == null)
            throw new Exception("Entity invalid!");

        return await Task.FromResult(_entities.Where(predicate).FirstOrDefault());
    }




    public async Task<List<TEntity>> GetAllAsync()
    {
        return await Task.FromResult(_entities.ToList());
    }




    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }



}