using ShoppingCartApi.Contracts.Resources;

namespace ShoppingCartApi.Domain.Events
{
    public class ProductDeleteEvent : DomainEvent
    {
        public ProductDeleteEvent(long id) : base(id, DomainMessage.ShoppingCart)
        {
            Id = id;
        }

        public long Id { get; }
    }
}
