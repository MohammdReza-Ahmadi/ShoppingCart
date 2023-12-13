using FluentValidation;

namespace ShoppingCartApi.UseCases.ShoppingCarts.Write.RemoveProduct;
public class RemoveProductValidation<TRequest> : AbstractValidator<TRequest>
    where TRequest : RemoveProduct
{
    public RemoveProductValidation() { }
}

