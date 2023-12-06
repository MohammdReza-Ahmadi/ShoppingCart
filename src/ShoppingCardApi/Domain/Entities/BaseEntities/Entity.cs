namespace ShoppingCardApi.Domain;

public class Entity
{
    public Entity()
    {
        
    }
    public Guid Id { get; set; }

    protected void SetId(Guid id)
    {
        Id = id;
    }
}