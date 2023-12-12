namespace ShoppingCartApi.Domain.ValueObjects.Products
{
    public class ProductName : BaseValueObject
    {
        public string Value { get; private set; }

        public ProductName(string value)
        {
            Value = value;
            CheckPolicies();
        }

        public static ProductName Create(string value)
        {
            return new ProductName(value);
        }

        protected override void CheckPolicies()
        {


            if (string.IsNullOrEmpty(Value))
                throw new Exception("Name is required");


            if (Value.Length < 3)
                throw new Exception("Name Should be more than 3 charecters");


            if (Value.Length > 50)
                throw new Exception("Name Should be less than 50 charecters");
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
