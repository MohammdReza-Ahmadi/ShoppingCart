namespace ShoppingCartApi.Domain.ValueObjects;
public class ProductStockQuantity : BaseValueObject
{
    public int Value { get; private set; }
    public ProductStockQuantity(int value)
    {

        Value = value;
        CheckPolicies();
    }


    public static ProductStockQuantity Create(int value)
    {
        return new ProductStockQuantity(value);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    protected override void CheckPolicies()
    {
        if (Value <= 0)
            throw new Exception("Quantity Is required");
    }
}

