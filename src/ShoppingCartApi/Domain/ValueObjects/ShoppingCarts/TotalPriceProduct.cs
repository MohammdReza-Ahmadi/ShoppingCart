namespace ShoppingCartApi.Domain.ValueObjects.ShoppingCarts;
public class TotalPriceProduct : BaseValueObject
{
    public long Value { get; private set; }
    public TotalPriceProduct(long value)
    {

        Value = value;
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
       
    }
}

