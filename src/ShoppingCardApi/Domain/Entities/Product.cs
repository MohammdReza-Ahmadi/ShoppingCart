using ShoppingCartApi.Domain.Entities.BaseEntities;
using ShoppingCartApi.Domain.ValueObjects;
using ShoppingCartApi.Domain.ValueObjects.Products;

namespace ShoppingCartApi.Domain;
public class Product : AggregateRoot
{
    public Product(string name, long price, string description, int stockQuantity)
    {
        Name = ProductName.Create(name);
        Price = ProductPrice.Create(price);
        Description = ProductDescription.Create(description);
        StockQuantity = ProductStockQuantity.Create(stockQuantity);
    }
    public ProductName Name { get; private set; }

    public ProductPrice Price { get; private set; }

    public ProductDescription? Description { get; private set; }

    public ProductStockQuantity StockQuantity { get; private set; }


    public Product AddProduct(string name, long price, string description, int stockQuantity)
    {
        return new Product(name, price, description, stockQuantity);
    }

    protected override void CheckInvariants()
    {
        throw new NotImplementedException();
    }
}

