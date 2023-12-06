using MediatR;
using ShoppingCardApi.Contracts;
using ShoppingCardApi.UseCases.ShoppingCart.AddProductToCart.Common;

namespace ShoppingCardApi.UseCase.ShoppingCart.AddProductToCart.Command;

public record AddProductToCartCommand(long productId,int Quantity):IRequest<Result<long>>;