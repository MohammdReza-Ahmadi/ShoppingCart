namespace ShoppingCartApi.Domain;

public class Entity
{
    public Entity()
    {
        
    }
    public long Id { get; set; }

    protected void SetId(long id)
    {
        Id = id;
    }
}