using ShoppingCartApi.Domain.Entities.ShoppingCarts;

namespace ShoppingCartApi.Domain.Data;
public interface IShoppingCartAggregateRepository : IRepository<ShoppingCart>
{
    Task<ShoppingCart> GetByProductIdAsync(long productId);
}

