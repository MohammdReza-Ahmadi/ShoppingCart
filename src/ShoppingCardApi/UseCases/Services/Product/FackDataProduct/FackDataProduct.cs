using Bogus;

namespace ShoppingCardApi.UseCases.Services;

public static class FackDataProduct
{
    public static void InitBogusData()
    {
        var productGenerator = GetProductGenerator();
        var generatedProduct = productGenerator.Generate(20);
    }
    
    private static Faker<Domain.Product> GetProductGenerator()
    {
        return new Faker<Domain.Product>()
            .RuleFor(p => p.Id, f =>f.Random.Int(1,20))
            .RuleFor(p => p.Name, f => f.Commerce.ProductName())
            .RuleFor(p => p.Price, f => f.Commerce.Random.Long(1000000, 100000000))
            .RuleFor(p => p.Description, f => f.Lorem.Paragraph(1))
            .RuleFor(p => p.Quantity, f => f.Random.Number(1, 40));
    }
}