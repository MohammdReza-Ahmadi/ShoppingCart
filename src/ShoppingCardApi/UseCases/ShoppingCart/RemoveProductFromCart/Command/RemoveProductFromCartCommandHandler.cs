using MediatR;
using ShoppingCardApi.Contracts;
using ShoppingCardApi.Domain;

namespace ShoppingCardApi.UseCases.ShoppingCart.RemoveProductFromCart;

public class RemoveProductFromCartCommandHandler : IRequestHandler<RemoveProductFromCart, Result>
{
    private readonly IRepository<Domain.ShoppingCart> _repository;
    public RemoveProductFromCartCommandHandler(IRepository<Domain.ShoppingCart> repository)
    {
        _repository = repository;
    }
    public async Task<Result> Handle(RemoveProductFromCart request, CancellationToken cancellationToken)
    {
        try
        {
            var getProduct = await _repository.GetAsync(request.id);
            if (getProduct == null)
                return Result.Failure();
            await _repository.DeleteAsync(getProduct);
            return Result.Success();
        }
        catch (Exception ex)
        {
            return Result.Failure();
        }

    }
}