using ShoppingCartApi.Domain.Resources;

namespace ShoppingCartApi.Domain.Events.ShoppingCarts
{
    public class ProductAddEvent : DomainEvent
    {



        public ProductAddEvent(long id, string name, long price, string? description, int stockQuantity) : base(id, DomainMessage.ShoppingCart)
        {
            Id = id;
            Name = name;
            Price = price;
            Description = description;
            StockQuantity = stockQuantity;
        }


        public long Id { get; }

        public string Name { get; private set; }

        public long Price { get; private set; }

        public string? Description { get; private set; }

        public int StockQuantity { get; private set; }

    }
}
