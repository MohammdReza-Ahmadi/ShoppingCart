using Microsoft.Extensions.Options;

namespace ShoppingCartApi.Configurations.Swagger;

public static class SwaggerConfigurations
{

    public static IApplicationBuilder UseSwaggerPreConfigured(this IApplicationBuilder app)
    {
        if (app == null)
            throw new ArgumentNullException(nameof(app));

        var options = app.ApplicationServices.GetRequiredService<IOptions<SwaggerOptions>>();
        if (options == null)
            throw new ArgumentNullException(nameof(options));

        // Enable middleware to serve generated Swagger as a JSON endpoint.
        app.UseSwagger();

        // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), specifying the Swagger JSON endpoint.
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/" + options.Value.Version + "/swagger.json", options.Value.Version);
            //redirect root url to swagger ui
            c.RoutePrefix = "";
        });

        return app;
    }
}