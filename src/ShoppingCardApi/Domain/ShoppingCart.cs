namespace ShoppingCardApi.Domain
{
    public class ShoppingCart:BaseEntity
    {
        public ShoppingCart(int quantity,ICollection<Product> products)
        {
            StockQuantity = TotalPrice(products.Select(x=>x.Price).ToArray());
            products = Products;
            quantity = Quantity;
        }

        public long StockQuantity { get; set; }
        
        public int Quantity { get; set; }
        public ICollection<Product> Products { get; set; }
        
        
        
        private static long TotalPrice(params long[] values)
        {
            long total = 0;
            foreach (var number in values)
            {
                total += number;
            }

            return total > 0 ? total:throw new Exception();
        }
    }
}
