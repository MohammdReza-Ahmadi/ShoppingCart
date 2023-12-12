namespace ShoppingCartApi.UseCases.ShoppingCart.AddProductToCart.Queries;

public interface IGetProductFromCartQuery
{
    Task<Domain.ShoppingCart> GetShoppingCartService(long id);
}