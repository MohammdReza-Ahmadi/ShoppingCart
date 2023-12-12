using MediatR;
using ShoppingCartApi.Contracts;
using ShoppingCartApi.Domain;

namespace ShoppingCartApi.UseCases.ShoppingCart.RemoveProductFromCart;

public class RemoveProductFromCartHandler : IRequestHandler<RemoveProductFromCart, Result>
{
    private readonly IRepository<Domain.ShoppingCart> _repository;
    public RemoveProductFromCartHandler(IRepository<Domain.ShoppingCart> repository)
    {
        _repository = repository;
    }
    public async Task<Result> Handle(RemoveProductFromCart request, CancellationToken cancellationToken)
    {



            var getProduct = await _repository.GetAsync(request.id);
            if (getProduct == null)
                return Result.Failure();


            await _repository.DeleteAsync(getProduct);



            return Result.Success();

    }
}