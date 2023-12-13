using ShoppingCartApi.Domain.Entities.ShoppingCarts;

namespace ShoppingCartApi.Helpers.FackData;

public static class FackDataProduct
{

    public static List<Product> GetProductGenerator()
    {
        List<Product> fackProduct = null;
        fackProduct = new List<Product>()
            {
                Product.AddProduct(1, "Tablet", 8000000, string.Empty, 2),
                Product.AddProduct(2, "Mobile", 4000000, string.Empty, 6),
                Product.AddProduct(3, "Telephone", 1000000, string.Empty, 30),
                Product.AddProduct(4, "Toy", 200000, string.Empty, 10),
                Product.AddProduct(5, "Cat", 10000000, string.Empty, 22),
                Product.AddProduct(6, "Dog", 9000000, string.Empty, 7),
                Product.AddProduct(7, "Camputer", 35000000, string.Empty, 9),
            };
        return fackProduct;
    }
}