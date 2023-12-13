using MediatR;
using Microsoft.AspNetCore.Mvc;
using ShoppingCartApi.Contracts;
using ShoppingCartApi.UseCases.ShoppingCarts.AddProductToCart;

namespace ShoppingCartApi.Controllers;
[Route("ShoppingCart")]
public class AddProductEndpoint: Controller
{
    
    
    
    private readonly ISender _sender;
    
    
    public AddProductEndpoint(ISender sender)
    {
        _sender = sender;
    }
    
    [HttpPost("AddProduct")]
    public async Task<Result<long>> AddProductToShoppingCart(AddProduct model)
    {
      return await _sender.Send(model);
    }
}