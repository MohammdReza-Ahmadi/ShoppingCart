using FluentValidation;

namespace ShoppingCartApi.UseCases.ShoppingCart.RemoveProductFromCart;
public class RemoveProductFromCartValidation<TRequest> : AbstractValidator<TRequest> 
    where TRequest : RemoveProductFromCart
{
    public RemoveProductFromCartValidation(){ }
}

