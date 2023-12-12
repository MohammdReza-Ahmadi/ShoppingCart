namespace ShoppingCartApi.Domain.ValueObjects.ShoppingCarts;
public class TotalPriceProduct : BaseValueObject
{
    public long Value { get; private set; }
    public TotalPriceProduct(long value)
    {

        Value = value;
        CheckPolicies();
    }



    public static TotalPriceProduct Create(long value)
    {
        return new TotalPriceProduct(value);
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

