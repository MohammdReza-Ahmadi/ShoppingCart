namespace ShoppingCardApi.Domain
{
    public class ShoppingCart:BaseEntity
    {
        public ShoppingCart(long id,int quantity,ICollection<Product> products)
        {
            Id = id;
            StockQuantity = AndQuantityWithPrice(quantity,products.Select(x=>x.Price).ToArray()); 
            Products = ProductPolicies(products);
            Quantity = QuantityPolicies(quantity);
        }

        public long StockQuantity { get; set; }
        
        public int Quantity { get; set; }
        public ICollection<Product> Products { get; set; }
        

        private static long AndQuantityWithPrice(int quantity,params long[] prices)
        {
            long total = 0;
            foreach (var number in prices)
            {
                CheckPrice(number);
                total += number * quantity;
            }
            return total > 0 ? total:throw new Exception("total invalid");
        }

        private static void CheckPrice(long price)
        {
            if (price <= 0)
                throw new Exception("Price invalid");
        }

        private static ICollection<Product> ProductPolicies(ICollection<Product> products)
        {
            if (products == null || products.Count <= 0)
                throw new Exception("Product is required");
            return products;
        }
        
        private static int QuantityPolicies(int quantity)
        {
            if (quantity <= 0)
                throw new Exception("Quantity Is required");
            return quantity;
        }
    }
}
