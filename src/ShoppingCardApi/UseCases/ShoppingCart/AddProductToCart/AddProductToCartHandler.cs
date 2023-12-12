using MediatR;
using ShoppingCartApi.Domain;
using ShoppingCartApi.Contracts;
using ShoppingCartApi.Contracts.Resources;
using ShoppingCartApi.UseCases.Product.GetProductQuery;
using ShoppingCartApi.UseCases.Services.Product.FackDataProduct;

namespace ShoppingCartApi.UseCases.ShoppingCart.AddProductToCart;

public class AddProductToCartHandler : IRequestHandler<AddProductToCart, Result<long>>
{



    private readonly IRepository<Domain.ShoppingCart> _repository;

    private readonly IGetProductQuery _product;


    public AddProductToCartHandler(IRepository<Domain.ShoppingCart> repository,
        IGetProductQuery product)
    {
        _repository = repository;
        _product = product;
    }
    public async Task<Result<long>> Handle(AddProductToCart request, CancellationToken cancellationToken)
    {

        var getProduct = await _product.GetProductService(request.productId);
        if (getProduct == null)
            throw new Exception("Product Not Founded");
        List<Domain.Product> products = new List<Domain.Product>() { getProduct };



        var entityId = await _repository.AddAsync(new Domain.ShoppingCart(FackDataProduct.GenerateFackId(), request.Quantity, products));

        return Result.Success<long>(entityId, ContractMessages.CreateSucceed);
    }
}