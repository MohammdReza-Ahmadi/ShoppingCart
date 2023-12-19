using ShoppingCartApi.Domain.Entities.BaseEntities;
using ShoppingCartApi.Domain.ValueObjects;
using ShoppingCartApi.Domain.ValueObjects.Products;

namespace ShoppingCartApi.Domain.Entities.ShoppingCarts;
public class Product : AggregateRoot
{
    public Product(long id,string name, long price, string description, int stockQuantity)
    {
        SetId(id);
        Name = ProductName.Create(name);
        Price = ProductPrice.Create(price);
        Description = ProductDescription.Create(description);
        StockQuantity = ProductStockQuantity.Create(stockQuantity);
    }
    public ProductName Name { get; private set; }

    public ProductPrice Price { get; private set; }

    public ProductDescription? Description { get; private set; }

    public ProductStockQuantity StockQuantity { get; private set; }


    public static Product AddProduct(long id,string name, long price, string description, int stockQuantity)
    {
        return new Product(id, name, price, description, stockQuantity);
    }

    protected override void CheckInvariants()
    {
        
    }
}

