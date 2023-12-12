namespace ShoppingCartApi.Domain.ValueObjects.Products
{
    public class ProductPrice : BaseValueObject
    {

        public long Value {  get; private set; }
        public ProductPrice(long value) 
        {
            Value = value;
            CheckPolicies();
        }

        public static ProductPrice Create(long value)
        {
            return new ProductPrice(value);
        }
        protected override void CheckPolicies()
        {
            if (Value <= 0)
                throw new Exception("Price Is required");
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
