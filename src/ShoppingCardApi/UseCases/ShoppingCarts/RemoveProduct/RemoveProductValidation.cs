using FluentValidation;

namespace ShoppingCartApi.UseCases.ShoppingCarts.RemoveProduct;
public class RemoveProductValidation<TRequest> : AbstractValidator<TRequest> 
    where TRequest : RemoveProduct
{
    public RemoveProductValidation(){ }
}

