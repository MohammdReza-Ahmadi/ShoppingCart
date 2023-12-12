namespace ShoppingCartApi.UseCases.Product.GetProductQuery;

public interface IGetProductQuery
{
    Task<Domain.Product> GetProductService(long id);
}