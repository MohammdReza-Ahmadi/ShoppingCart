using MediatR;
using ShoppingCartApi.Contracts;

namespace ShoppingCartApi.UseCases.ShoppingCart.AddProductToCart;

public record AddProductToCart(long productId,int Quantity):IRequest<Result<long>>;