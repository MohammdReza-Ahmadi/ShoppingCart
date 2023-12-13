using MediatR;
using ShoppingCartApi.Contracts;

namespace ShoppingCartApi.UseCases.ShoppingCarts.Write.RemoveProduct;

public record RemoveProduct(long id) : IRequest<Result>;