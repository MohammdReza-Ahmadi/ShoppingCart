using ShoppingCardApi.Domain;
using ShoppingCardApi.Infrastructure.Repository;

namespace ShoppingCardApi.Infrastructure.DI;

public static class InfraDependencyInjection
{

   public static IServiceCollection AddInfrastructure(this IServiceCollection services, ConfigurationManager configuration) 
      {

         services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
        
         return services;
      }
}