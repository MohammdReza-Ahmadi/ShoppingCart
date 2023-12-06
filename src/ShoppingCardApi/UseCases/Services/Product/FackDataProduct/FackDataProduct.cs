namespace ShoppingCardApi.UseCases.Services.Product.FackDataProduct;

public static class FackDataProduct
{

    public static List<Domain.Product> GetProductGenerator()
    {
        List<Domain.Product> fackProduct = null;
        for (int i = 0; i < 1; i++)
        { fackProduct = new List<Domain.Product>()
            {
                new Domain.Product(Guid.NewGuid(), "Tablet", 8000000, string.Empty, 2),
                new Domain.Product(Guid.NewGuid(), "Mobile", 4000000, string.Empty, 6),
                new Domain.Product(Guid.NewGuid(), "Telephone", 1000000, string.Empty, 30),
                new Domain.Product(Guid.NewGuid(), "Toy", 200000, string.Empty, 10),
                new Domain.Product(Guid.NewGuid(), "Cat", 10000000, string.Empty, 22),
                new Domain.Product(Guid.NewGuid(), "Dog", 9000000, string.Empty, 7),
                new Domain.Product(Guid.NewGuid(), "Camputer", 35000000, string.Empty, 9),
            };
        }
        return fackProduct;
    }
}