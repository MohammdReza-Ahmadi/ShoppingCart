using MediatR;
using System.Text.Json.Serialization;

namespace ShoppingCartApi.Domain.Events;
public class DomainEvent:INotification
{
    public DomainEvent(long entityId, string entityType)
    {
        EntityId = entityId;
        EntityType = entityType;
        EventType = GetType().Name;
        OccurredOn = DateTime.Now;
    }

    /// <summary>
    /// Use JsonIgnore to prevent adding it to Data in StoredEvent. As it will be mapped to StoredEvent.EntityId and no need to have it in StoredEvent.Data
    /// </summary>
    [JsonIgnore]
    public long EntityId { get; }

    /// <summary>
    /// Use JsonIgnore to prevent adding it to Data in StoredEvent.
    /// </summary>
    [JsonIgnore]
    public string EntityType { get; }

    /// <summary>
    /// Use JsonIgnore to prevent adding it to Data in StoredEvent.
    /// </summary>
    [JsonIgnore]
    public string EventType { get; }

    public DateTime OccurredOn { get; }
}

