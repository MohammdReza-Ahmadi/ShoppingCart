using ShoppingCardApi.Configurations;

var builder = WebApplication.CreateBuilder(args);

var app = builder.ConfigurationService().ConfigurePipeline(builder.Configuration);

app.Run();



