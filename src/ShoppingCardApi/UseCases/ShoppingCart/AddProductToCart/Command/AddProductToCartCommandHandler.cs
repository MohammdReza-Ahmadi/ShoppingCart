using MediatR;
using ShoppingCardApi.Domain;
using ShoppingCardApi.Resources;
using ShoppingCardApi.UseCases.ShoppingCart.AddProductToCart.Common;

namespace ShoppingCardApi.UseCase.ShoppingCart.AddProductToCart.Command;

public class AddProductToCartCommandHandler:IRequestHandler<AddProductToCartCommand,AddProductToCartResult>
{
    private readonly IRepository<Domain.ShoppingCart> _repository;
    public AddProductToCartCommandHandler(IRepository<Domain.ShoppingCart> repository)
    {
        _repository = repository;
    }
    public async Task<AddProductToCartResult> Handle(AddProductToCartCommand request, CancellationToken cancellationToken)
    {
        var pro = new Product()
        {
            Id = 1,
            Name = "Tablet",
            Description = null,
            Price = 8000000,
            Quantity = 20,
        };
        List<Product> p = new List<Product>()
        {
            pro
        };
        await _repository.AddAsync(new Domain.ShoppingCart(request.Quantity,p));
        //var getProduct= await _repository.GetAsync(request.productId); ; 
        
        return new AddProductToCartResult(ContractMessages.CreateSucceed);
    }
}