using ShoppingCartApi.Domain;
using ShoppingCartApi.UseCases.Product.GetProductQuery;
using ShoppingCartApi.UseCases.Services.Product.FackDataProduct;

namespace ShoppingCardApi.UseCases.Product.GetProductQuery;

public class GetProductQuery : IGetProductQuery
{
    private readonly  IRepository<Product> _productRepo;
    public GetProductQuery(IRepository<Product> productRepo)
    {
        _productRepo = productRepo;
    }
    public async Task<Product> GetProductService(long id)
    {

        _productRepo.AddRangeAsync(FackDataProduct.GetProductGenerator());
        return await _productRepo.GetAsync(id);
    }
}