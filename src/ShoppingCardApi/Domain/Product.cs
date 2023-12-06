namespace ShoppingCardApi.Domain
{
    public class Product:BaseEntity
    {
        public Product(Guid id,string name,long price,string description,int quantity)
        {
            Id = id;
            Name = NamePolicies(name);
            Price = PricePolicies(price);
            Description = description;
            Quantity = QuantityPolicies(quantity);
        }
        public string Name { get; set; } = null!;
        
        public long Price { get; set; }
        
        public string? Description { get; set; }

        public int Quantity { get; set; }

        private static string NamePolicies(string name)
        {
            
            if (string.IsNullOrEmpty(name))
                throw new Exception("Name is required");
            
            
            if (name.Length < 3)
                throw new Exception("Name Should be more than 3 charecters");
            
            
            if (name.Length > 50)
                throw new Exception("Name Should be less than 50 charecters");
            
            
            return name;
        }

        private static long PricePolicies(long price)
        {
            if (price <= 0)
                throw new Exception("Price Is required");
            return price;
        } 
        
        private static int QuantityPolicies(int quantity)
        {
            if (quantity <= 0)
                throw new Exception("Quantity Is required");
            return quantity;
        }
    }
}
