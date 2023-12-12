using MediatR;
using ShoppingCartApi.Contracts;

namespace ShoppingCartApi.UseCases.ShoppingCart.RemoveProductFromCart;

public record RemoveProductFromCart(long id):IRequest<Result>;