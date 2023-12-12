namespace ShoppingCartApi.Domain;

public class BaseEntity:Entity
{
    public BaseEntity()
    {
        CreateDateTime = CreationDateTime.CreateNowDateTime();
    }
    
    public CreationDateTime CreateDateTime { get; private set; }


    protected void UpdateModifiedDateTime()
    {
        CreateDateTime = CreateDateTime.UpdateModifiedDateTime();
    }
}