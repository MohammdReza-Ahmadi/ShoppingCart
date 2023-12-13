using MediatR;
using ShoppingCartApi.Contracts;

namespace ShoppingCartApi.UseCases.ShoppingCarts.AddProductToCart;

public record AddProduct(long productId,int Quantity):IRequest<Result<long>>;