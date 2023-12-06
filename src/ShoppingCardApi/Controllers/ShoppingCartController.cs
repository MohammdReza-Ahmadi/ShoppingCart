using MediatR;
using Microsoft.AspNetCore.Mvc;
using ShoppingCardApi.Contracts;
using ShoppingCardApi.UseCase.ShoppingCart.AddProductToCart.Command;
using ShoppingCardApi.UseCases.ShoppingCart.RemoveProductFromCart;

namespace ShoppingCardApi.Controllers;
[Route("ShoppingCart")]
public class ShoppingCartController: BaseApiController
{
    
    
    
    private readonly ISender _sender;
    
    
    public ShoppingCartController(ISender sender)
    {
        _sender = sender;
    }
    
    [HttpPost("AddProduct")]
    public async Task<Result> AddProductToShoppingCart(AddProductToCartCommand model)
    {
      return await _sender.Send(model);
    }
    
    [HttpDelete("RemoveProduct")]
    public async Task<Result> RemoveProductFromShoppingCart(RemoveProductFromCart model)
    {
       return  await _sender.Send(model);
    }
}