using ShoppingCardApi.Domain;

namespace ShoppingCardApi.UseCases.Product.GetProductQuery;

public class GetProductQuery : IGetProductQuery
{
    private readonly  IRepository<Domain.Product> _productRepo;
    public GetProductQuery(IRepository<Domain.Product> productRepo)
    {
        _productRepo = productRepo;
    }
    public async Task<Domain.Product> GetProductService(long id)
    {
        var pro = new Domain.Product()
        {
            Id = 1,
            Name = "Tablet",
            Description = null,
            Price = 8000000,
            Quantity = 20,
        };
        List<Domain.Product> p = new List<Domain.Product>();
        p.Add(pro);
        await _productRepo.AddAsync(pro);
        var product = await _productRepo.GetAsync(id);
        return product;
    }
}