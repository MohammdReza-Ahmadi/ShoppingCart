using MediatR;
using Microsoft.AspNetCore.Mvc;
using ShoppingCartApi.Contracts;
using ShoppingCartApi.Controllers;

namespace ShoppingCartApi.UseCases.ShoppingCart.RemoveProductFromCart;
public class RemoveProductFromCartEndpoint: BaseApiController
{

    private readonly ISender _sender;


    public RemoveProductFromCartEndpoint(ISender sender)
    {
        _sender = sender;
    }

    [HttpDelete("RemoveProduct")]
    public async Task<Result> RemoveProductFromShoppingCart(RemoveProductFromCart model)
    {
        return await _sender.Send(model);
    }
}

