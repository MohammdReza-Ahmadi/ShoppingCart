using ShoppingCardApi.Domain;
using ShoppingCardApi.UseCases.Services.Product.FackDataProduct;

namespace ShoppingCardApi.UseCases.Product.GetProductQuery;

public class GetProductQuery : IGetProductQuery
{
    private readonly  IRepository<Domain.Product> _productRepo;
    public GetProductQuery(IRepository<Domain.Product> productRepo)
    {
        _productRepo = productRepo;
    }
    public async Task<Domain.Product> GetProductService(Guid id)
    {

        _productRepo.AddRangeAsync(FackDataProduct.GetProductGenerator());
        return await _productRepo.GetAsync(id);
    }
}