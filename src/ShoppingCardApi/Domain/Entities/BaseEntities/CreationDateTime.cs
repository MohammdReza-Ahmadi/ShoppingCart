namespace ShoppingCardApi.Domain;

public class CreationDateTime
{
    public DateTime CreateDateTime { get; private set; }
    public DateTime ModifiedDateTime { get; private set; }
    
    
    public CreationDateTime(DateTime dateTime)
    {
        CreateDateTime = dateTime;
        ModifiedDateTime = dateTime;
    }
    
    
    public static CreationDateTime CreateNowDateTime()
    {
        return new CreationDateTime(DateTime.Now);
    }
    
    public CreationDateTime UpdateModifiedDateTime()
    {
        return new CreationDateTime(DateTime.Now);
    }
    
    
}