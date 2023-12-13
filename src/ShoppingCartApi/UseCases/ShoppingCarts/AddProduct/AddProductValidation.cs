using FluentValidation;

namespace ShoppingCartApi.UseCases.ShoppingCarts.AddProductToCart;
public class AddProductValidation<TRequest> : AbstractValidator<TRequest> 
    where TRequest : AddProduct
{
    public AddProductValidation()
    {
        
    }
}

