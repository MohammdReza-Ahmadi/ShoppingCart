using MediatR;
using ShoppingCartApi.Contracts;

namespace ShoppingCartApi.UseCases.ShoppingCarts.RemoveProduct;

public record RemoveProduct(long id):IRequest<Result>;