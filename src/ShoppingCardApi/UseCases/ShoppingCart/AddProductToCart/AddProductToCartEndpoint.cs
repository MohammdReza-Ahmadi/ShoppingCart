using MediatR;
using Microsoft.AspNetCore.Mvc;
using ShoppingCartApi.Contracts;
using ShoppingCartApi.UseCases.ShoppingCart.AddProductToCart;

namespace ShoppingCartApi.Controllers;
[Route("ShoppingCart")]
public class AddProductToCartEndpoint: BaseApiController
{
    
    
    
    private readonly ISender _sender;
    
    
    public AddProductToCartEndpoint(ISender sender)
    {
        _sender = sender;
    }
    
    [HttpPost("AddProduct")]
    public async Task<Result<long>> AddProductToShoppingCart(AddProductToCart model)
    {
      return await _sender.Send(model);
    }
}