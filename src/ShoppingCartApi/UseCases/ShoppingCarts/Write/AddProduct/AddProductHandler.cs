using MediatR;
using ShoppingCartApi.Contracts;
using ShoppingCartApi.Contracts.Resources;
using ShoppingCartApi.Domain.Entities.ShoppingCarts;
using ShoppingCartApi.Helpers.FackData;
using ShoppingCartApi.Domain.Data;

namespace ShoppingCartApi.UseCases.ShoppingCarts.Write.AddProduct;

public class AddProductHandler : IRequestHandler<AddProduct, Result<long>>
{



    private readonly IShoppingCartAggregateRepository _shoppingCartAggregateRepository;

    private readonly IRepository<ShoppingCart> _repository;

    private long _entityId;

    public AddProductHandler(IRepository<ShoppingCart> repository,
        IShoppingCartAggregateRepository shoppingCartAggregateRepository)
    {
        _repository = repository;
        _shoppingCartAggregateRepository = shoppingCartAggregateRepository;
    }
    public async Task<Result<long>> Handle(AddProduct request, CancellationToken cancellationToken)
    {




        var productList = FackDataProduct.GetProductGenerator();


        var getProduct = productList.FirstOrDefault(p => p.Id == request.productId);

        if (getProduct == null)
            throw new Exception("Product NotFound!");



        var getShoppingCart = await _shoppingCartAggregateRepository.GetAllAsync();

        if (getShoppingCart.Count > 0)
        {

            foreach (var item in getShoppingCart)
            {
                item.AddProduct(getProduct);
                _entityId = item.Id;

            }



        }
        else
        {
            var shoppingCart = ShoppingCart.AddShoppingCart(GenerateFackId.FackId(), request.Quantity);

            shoppingCart.AddProduct(getProduct);

            _entityId = await _repository.AddAsync(shoppingCart);

        }


        return Result.Success(_entityId, ContractMessages.CreateSucceed);



    }



}