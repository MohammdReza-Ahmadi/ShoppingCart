using MediatR;
using ShoppingCartApi.Contracts;
using ShoppingCartApi.Domain;
using ShoppingCartApi.Domain.Data;
using ShoppingCartApi.Domain.Entities.ShoppingCarts;

namespace ShoppingCartApi.UseCases.ShoppingCarts.RemoveProduct;

public class RemoveProductHandler : IRequestHandler<RemoveProduct, Result>
{



    private readonly IRepository<ShoppingCart> _repository;

    private readonly IShoppingCartAggregateRepository _shoppingCartAggregateRepository;



    public RemoveProductHandler(IRepository<ShoppingCart> repository,
        IShoppingCartAggregateRepository shoppingCartAggregateRepository)
    {
        _repository = repository;
        _shoppingCartAggregateRepository = shoppingCartAggregateRepository;
    }



    public async Task<Result> Handle(RemoveProduct request, CancellationToken cancellationToken)
    {



        var getShoppingCart = await _shoppingCartAggregateRepository.GetByProductIdAsync(request.id);
        if (getShoppingCart == null)
            return Result.Failure();


        getShoppingCart.DeleteProduct(request.id);

        await _repository.DeleteAsync(getShoppingCart);


        return Result.Success();

    }
}