namespace ShoppingCartApi.Domain.ValueObjects.ShoppingCarts
{
    public class QuantityProduct : BaseValueObject
    {
        public int Value { get; private set; }

        public QuantityProduct(int value) 
        {
            Value = value;
            CheckPolicies();
        }

        public static QuantityProduct Create(int value)
        {
            return new QuantityProduct(value);
        }

        protected override void CheckPolicies()
        {
            if (Value <= 0)
                throw new Exception("Quantity Is required");
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
