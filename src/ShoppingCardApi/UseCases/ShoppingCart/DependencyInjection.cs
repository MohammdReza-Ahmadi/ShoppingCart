using MediatR;
using System.Reflection;
using ShoppingCardApi.UseCases.Product.GetProductQuery;
using ShoppingCartApi.UseCases.Product.GetProductQuery;
using ShoppingCardApi.UseCases.ShoppingCart.AddProductToCart.Queries;
using ShoppingCartApi.UseCases.ShoppingCart.AddProductToCart.Queries;

namespace ShoppingCartApi.UseCases.ShoppingCart;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(cfg=>cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
        services.AddScoped<IGetProductFromCartQuery,GetProductFromCartQuery>();
        services.AddScoped<IGetProductQuery, GetProductQuery>();
        return services;
    }

}