using MediatR;
using Microsoft.AspNetCore.Mvc;
using ShoppingCardApi.UseCase.ShoppingCart.AddProductToCart.Command;
using ShoppingCardApi.UseCases.ShoppingCart.AddProductToCart.Common;
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
    
    [HttpPost("AddProductToShoppingCart")]
    public async Task<AddProductToCartResult> AddProductToShoppingCart(AddProductToCartCommand model)
    {
      return await _sender.Send(model);
    }
    
    [HttpDelete("RemoveProductFromShoppingCart")]
    public async Task RemoveProductFromShoppingCart(RemoveProductFromCart model)
    {
         await _sender.Send(model);
    }
}