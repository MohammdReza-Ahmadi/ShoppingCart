using FluentValidation;

namespace ShoppingCartApi.UseCases.ShoppingCarts.Write.AddProduct;
public class AddProductValidation<TRequest> : AbstractValidator<TRequest>
    where TRequest : AddProduct
{
    public AddProductValidation()
    {

    }
}

