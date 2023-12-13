using MediatR;
using Microsoft.AspNetCore.Mvc;
using ShoppingCartApi.Contracts;

namespace ShoppingCartApi.UseCases.ShoppingCarts.RemoveProduct;

[Route("ShoppingCart")]
public class RemoveProductEndpoint: Controller
{

    private readonly ISender _sender;


    public RemoveProductEndpoint(ISender sender)
    {
        _sender = sender;
    }

    [HttpDelete("RemoveProduct")]
    public async Task<Result> RemoveProductFromShoppingCart(RemoveProduct model)
    {
        return await _sender.Send(model);
    }
}

