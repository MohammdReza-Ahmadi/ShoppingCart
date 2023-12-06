using ShoppingCardApi.Domain;

namespace ShoppingCardApi.UseCases.ShoppingCart.AddProductToCart.Queries;

public class GetProductFromCartQuery:IGetProductFromCartQuery
{
    private readonly IRepository<Domain.ShoppingCart> _repository;

    public GetProductFromCartQuery(IRepository<Domain.ShoppingCart> repository)
    {
        _repository = repository;
    }

    public async Task<Domain.ShoppingCart> GetShoppingCartService(long id)
    {

      return await _repository.GetAsync(id);
    }
}