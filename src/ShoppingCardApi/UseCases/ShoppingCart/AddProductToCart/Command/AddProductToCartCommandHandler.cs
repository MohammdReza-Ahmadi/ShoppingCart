using MediatR;
using ShoppingCardApi.Contracts;
using ShoppingCardApi.Domain;
using ShoppingCardApi.UseCases.Product.GetProductQuery;
using ShoppingCardApi.UseCases.Services.Product.FackDataProduct;
using ShoppingCardApi.UseCases.ShoppingCart.AddProductToCart.Common;
using ShoppingCartApi.Contracts.Resources;

namespace ShoppingCardApi.UseCase.ShoppingCart.AddProductToCart.Command;

public class AddProductToCartCommandHandler:IRequestHandler<AddProductToCartCommand,Result>
{
    
    
    
    private readonly IRepository<Domain.ShoppingCart> _repository;

    private readonly IGetProductQuery _product;
    
    
    public AddProductToCartCommandHandler(IRepository<Domain.ShoppingCart> repository,
        IGetProductQuery product)
    {
        _repository = repository;
        _product = product;
    }
    public async Task<Result> Handle(AddProductToCartCommand request, CancellationToken cancellationToken)
    {
        
        var getProduct= await _product.GetProductService(request.productId);
        if (getProduct == null)
            throw new Exception("Product Not Founded");
        List<Product> products = new List<Product>() {getProduct};
        
        
        
        await _repository.AddAsync(new Domain.ShoppingCart(FackDataProduct.GenerateFackId(), request.Quantity,products));

        return Result.Success(ContractMessages.CreateSucceed);
    }
}