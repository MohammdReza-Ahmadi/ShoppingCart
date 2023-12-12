using MediatR;

namespace ShoppingCartApi.UseCases.Behaviors;

public static class BehaviorExtensions
{
    /// <summary>
    ///
    /// </summary>
    public static void AddApplicationBehaviors(this IServiceCollection services)
    {
        services.AddCachingBehavior();
    }
    

    /// <summary>
    ///
    /// </summary>
    public static void AddCachingBehavior(this IServiceCollection services)
    {
        services.AddEasyCaching(option => option.UseInMemory());
        services.AddScoped(typeof(IPipelineBehavior<,>), typeof(CachingBehavior<,>));
        services.AddScoped(typeof(IPipelineBehavior<,>), typeof(LogingPiplineBehavior<,>));
    }
}
