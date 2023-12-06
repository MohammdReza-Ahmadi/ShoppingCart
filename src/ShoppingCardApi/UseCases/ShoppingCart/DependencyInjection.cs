using System.Reflection;
using MediatR;
using ShoppingCardApi.UseCases.Product.GetProductQuery;
using ShoppingCardApi.UseCases.Services.Product;
using ShoppingCardApi.UseCases.ShoppingCart.AddProductToCart.Queries;

namespace ShoppingCardApi.UseCases.ShoppingCart;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(cfg=>cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
        services.AddScoped<IGetProductFromCartQuery,GetProductFromCartQuery>();
        services.AddScoped<IGetProductQuery,GetProductQuery>();
        return services;
    }

}