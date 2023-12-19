using ShoppingCartApi.Contracts.Resources;
using ShoppingCartApi.Domain.Entities.BaseEntities;
using ShoppingCartApi.Domain.Events;
using ShoppingCartApi.Domain.Events.ShoppingCarts;
using ShoppingCartApi.Domain.ValueObjects.ShoppingCarts;

namespace ShoppingCartApi.Domain.Entities.ShoppingCarts;

public class ShoppingCart : AggregateRoot
{



    public ShoppingCart(long id,int quantity)
    {
        SetId(id);
        Quantity = QuantityProduct.Create(quantity);
        Products = new HashSet<Product>();
        TotalPrice = TotalPriceProduct.Create();
    }

    public TotalPriceProduct TotalPrice { get; private set; }
    public QuantityProduct Quantity { get; private set; }
    public ICollection<Product> Products { get; private set; }



    public static ShoppingCart AddShoppingCart(long id,int quantity)
    {
        return new ShoppingCart(id, quantity);
    }



    public void AddProduct(Product product)
    {
        Products.Add(product);
        AddDomainEvent(new ProductAddEvent(product.Id, product.Name.Value, product.Price.Value, product.Description?.Value, product.StockQuantity.Value));
    }



    public void DeleteProduct(long id)
    {
        var products = Products.FirstOrDefault(p => p.Id == id);
        if (products == null)
            throw new Exception(ContractMessages.NotFound);

        Products.Remove(products);

        AddDomainEvent(new ProductDeleteEvent(Id));
    }



    private long TotalPriceCalculate()
    {
        long total = 0;
        foreach (var number in Products.Select(p=>p.Price))
        {
            total += number.Value * Quantity.Value;
        }
        return total;
    }



    protected override void CheckInvariants()
    {
        
    }
}

