namespace ShoppingCartApi.Domain.ValueObjects.Products
{
    public class ProductDescription : BaseValueObject
    {

        public string? Value {  get; private set; }

        public ProductDescription(string? value) 
        {
            Value = value;
            CheckPolicies();
        } 


        public static ProductDescription Create(string? value)
        {
            return new ProductDescription(value);
        }
        protected override void CheckPolicies()
        {
            if (Value?.Length > 100)
                throw new Exception("Description Should be less than 100 charecters");
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }
    }
}
