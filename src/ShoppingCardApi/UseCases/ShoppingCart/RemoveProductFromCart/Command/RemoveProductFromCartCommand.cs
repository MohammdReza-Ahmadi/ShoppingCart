using MediatR;
using ShoppingCardApi.Contracts;

namespace ShoppingCardApi.UseCases.ShoppingCart.RemoveProductFromCart;

public record RemoveProductFromCart(long id):IRequest<Result>;