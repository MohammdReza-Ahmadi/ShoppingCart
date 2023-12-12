using ShoppingCartApi.Domain;
using ShoppingCartApi.Infrastructure.Repository;

namespace ShoppingCartApi.Infrastructure.DI;

public static class InfraDependencyInjection
{

   public static IServiceCollection AddInfrastructure(this IServiceCollection services, ConfigurationManager configuration) 
      {

         services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
        
         return services;
      }
}