namespace ShoppingCardApi.UseCases.ShoppingCart.AddProductToCart.Queries;

public interface IGetProductFromCartQuery
{
    Task<Domain.ShoppingCart> GetShoppingCartService(long id);
}