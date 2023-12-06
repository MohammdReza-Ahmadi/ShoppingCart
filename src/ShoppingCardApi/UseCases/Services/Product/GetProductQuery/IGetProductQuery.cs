namespace ShoppingCardApi.UseCases.Product.GetProductQuery;

public interface IGetProductQuery
{
    Task<Domain.Product> GetProductService(Guid id);
}