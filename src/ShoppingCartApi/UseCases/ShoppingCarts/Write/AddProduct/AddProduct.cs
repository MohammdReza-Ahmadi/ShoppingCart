using MediatR;
using ShoppingCartApi.Contracts;

namespace ShoppingCartApi.UseCases.ShoppingCarts.Write.AddProduct;

public record AddProduct(long productId, int Quantity) : IRequest<Result<long>>;