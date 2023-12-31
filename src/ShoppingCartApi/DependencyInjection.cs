using MediatR;
using System.Reflection;

namespace ShoppingCartApi;

public static class DependencyInjection
{



    public static IServiceCollection AddApplication(this IServiceCollection services)
    {


        services.AddMediatR(cfg=>cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
        return services;
    }

}