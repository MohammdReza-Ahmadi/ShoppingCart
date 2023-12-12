using ShoppingCartApi.Configurations.Prometuos;
using ShoppingCartApi.Configurations.Swagger;
using ShoppingCartApi.Exceptions;
using ShoppingCartApi.Infrastructure.DI;
using ShoppingCartApi.UseCases.ShoppingCart;
using ShoppingCartApi.UseCases.Behaviors;

namespace ShoppingCartApi.Configurations;

public static class HostingExtentions
{
    public static WebApplication ConfigurationService(this WebApplicationBuilder builder)
    {
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddApplication();
        builder.Services.AddApplicationBehaviors();
        builder.Services.AddInfrastructure(builder.Configuration);
        return builder.Build();
    

    }

    public static WebApplication ConfigurePipeline(this WebApplication app, IConfiguration conf)
    {
        app.UseSwagger();
        app.UseSwaggerUI();
        app.MapControllers();
        app.Run();
        return app;
    }
    
    public static void UseWebApiPreConfigured(this IApplicationBuilder app, IWebHostEnvironment env, IConfiguration configuration)
    {
        if (app == null)
            throw new ArgumentNullException(nameof(app));

        if (env.IsDevelopment())
            app.UseDeveloperExceptionPage();

        app.UseGlobalExceptionHandler();

        app.UseSwaggerPreConfigured();

        app.UseHttpsRedirection();

        app.UseRouting();

        app.UseMetrics(configuration);

        app.UseAuthentication();

        app.UseAuthorization();
    }
    
    private static void UseGlobalExceptionHandler(this IApplicationBuilder app)
    {
        app.UseMiddleware<HttpGlobalExceptionHandler>();
    }
}