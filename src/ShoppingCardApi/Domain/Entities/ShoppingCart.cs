using ShoppingCartApi.Contracts.Resources;
using ShoppingCartApi.Domain.Entities.BaseEntities;
using ShoppingCartApi.Domain.Events;
using ShoppingCartApi.Domain.Events.ShoppingCarts;
using ShoppingCartApi.Domain.ValueObjects.ShoppingCarts;

namespace ShoppingCartApi.Domain;

public class ShoppingCart : AggregateRoot
{
    public ShoppingCart(int quantity, ICollection<Product> products)
    {
        Quantity = QuantityProduct.Create(quantity);
        TotalPrice = TotalPriceProduct.Create(AndQuantityWithPrice(quantity, products.Select(x => x.Price).ToArray()));
        Products = new HashSet<Product>();
    }
    public TotalPriceProduct TotalPrice { get; private set; }
    public QuantityProduct Quantity { get; private set; }
    public ICollection<Product> Products { get; private set; }




    public static ShoppingCart AddShoppingCart(int quantity, ICollection<Product> products)
    {
        return new ShoppingCart(quantity, products);
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
        AddDomainEvent(new ProductAddEvent(product.Id, product.Name.Value, product.Price.Value, product.Description.Value, product.StockQuantity.Value));
    }

    public void DeleteProduct(long id)
    {
        var products = Products.FirstOrDefault(p => p.Id == id);
        if (products == null)
            throw new Exception(ContractMessages.NotFound);

        Products.Remove(products);

        AddDomainEvent(new ProductDeleteEvent(Id));
    }


    private static long AndQuantityWithPrice(int quantity, params long[] prices)
    {
        long total = 0;
        foreach (var number in prices)
        {
            CheckPrice(number);
            total += number * quantity;
        }
        return total;
    }

    private static void CheckPrice(long price)
    {
        if (price <= 0)
            throw new Exception("Price invalid");
    }

    protected override void CheckInvariants()
    {
        throw new NotImplementedException();
    }
}

