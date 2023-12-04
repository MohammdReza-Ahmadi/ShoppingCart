namespace ShoppingCardApi.Domain
{
    public class Product:BaseEntity
    {
        
        public string Name { get; set; } = null!;
        
        public long Price { get; set; }
        
        public string? Description { get; set; }

        public int Quantity { get; set; }
        
    }
}
