namespace ShoppingCart.Write.Tests.Base;
public class ShoppingCartBuilder
{


    public int Quantity { get; private set; }

    public int TotalPrice { get; private set; }

    private ShoppingCartBuilder(){}


    public ShoppingCartBuilder init()
    {
        return new ShoppingCartBuilder();
    }

    public ShoppingCartBuilder WithQuantity(int quantity)
    {
        Quantity = quantity;
        return this;
    }

    public ShoppingCartBuilder WhithTotalPrice(int totalPrice)
    {
        TotalPrice = totalPrice;
        return this;
    }
}

