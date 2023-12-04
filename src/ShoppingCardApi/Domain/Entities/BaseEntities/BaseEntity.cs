namespace ShoppingCardApi.Domain;

public class BaseEntity:Entity
{
    
    
    public DateTimeOffset CreateDateTime { get; private set; }
    
    
    
    public DateTimeOffset ModifyDateTime { get; private set; }
}