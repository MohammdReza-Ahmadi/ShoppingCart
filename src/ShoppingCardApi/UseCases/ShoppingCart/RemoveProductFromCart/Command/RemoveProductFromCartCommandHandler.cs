using MediatR;
using ShoppingCardApi.Domain;

namespace ShoppingCardApi.UseCases.ShoppingCart.RemoveProductFromCart;

public class RemoveProductFromCartCommandHandler:IRequestHandler<RemoveProductFromCart>
{
    private readonly IRepository<Domain.ShoppingCart> _repository;
    public RemoveProductFromCartCommandHandler(IRepository<Domain.ShoppingCart> repository)
    {
        _repository = repository;
    }
    public async Task Handle(RemoveProductFromCart request, CancellationToken cancellationToken)
    {
      var getProduct=  await _repository.GetAsync(request.id);
      await _repository.DeleteAsync(getProduct);
    }
}