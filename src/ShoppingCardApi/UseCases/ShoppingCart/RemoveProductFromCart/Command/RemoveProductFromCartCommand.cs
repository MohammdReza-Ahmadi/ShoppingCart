using MediatR;

namespace ShoppingCardApi.UseCases.ShoppingCart.RemoveProductFromCart;

public record RemoveProductFromCart(long id):IRequest;