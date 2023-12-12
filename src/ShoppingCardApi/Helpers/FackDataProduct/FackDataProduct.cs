namespace ShoppingCartApi.UseCases.Services.Product.FackDataProduct;

public static class FackDataProduct
{

    public static List<Domain.Product> GetProductGenerator()
    {
        List<Domain.Product> fackProduct = null;
        for (int i = 0; i < 1; i++)
        { fackProduct = new List<Domain.Product>()
            {
                new Domain.Product(1, "Tablet", 8000000, string.Empty, 2),
                new Domain.Product(2, "Mobile", 4000000, string.Empty, 6),
                new Domain.Product(3, "Telephone", 1000000, string.Empty, 30),
                new Domain.Product(4, "Toy", 200000, string.Empty, 10),
                new Domain.Product(5, "Cat", 10000000, string.Empty, 22),
                new Domain.Product(6, "Dog", 9000000, string.Empty, 7),
                new Domain.Product(7, "Camputer", 35000000, string.Empty, 9),
            };
        }
        return fackProduct;
    }

    public static long GenerateFackId()
    {
        Random rnd = new Random();
        long id = rnd.Next(1,8);
        return id;
    }
}