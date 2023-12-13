using ShoppingCartApi.Domain;
using ShoppingCartApi.Domain.Data;
using ShoppingCartApi.Domain.Entities.ShoppingCarts;

namespace ShoppingCartApi.Infrastructure.Repository;

public class ShoppingCartAggregateRepository: Repository<ShoppingCart>, IShoppingCartAggregateRepository
{
    private readonly IRepository<ShoppingCart> _repository;
    public ShoppingCartAggregateRepository(IRepository<ShoppingCart> repository)
    {
        _repository = repository;
    }


    public async Task<ShoppingCart> GetByProductIdAsync(long productId)
    {

        return await _repository.GetByPerdicateAsync(a => a.Products.Any(p => p.Id == productId));
    }

}

