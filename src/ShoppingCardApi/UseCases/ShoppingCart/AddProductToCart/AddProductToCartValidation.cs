using FluentValidation;

namespace ShoppingCartApi.UseCases.ShoppingCart.AddProductToCart;
public class AddProductToCartValidation<TRequest> : AbstractValidator<TRequest> 
    where TRequest : AddProductToCart
{
    public AddProductToCartValidation()
    {
        
    }
}

