namespace ShoppingCartApi.Domain;

public class BaseEntity:Entity
{


    #region ctor

    public BaseEntity()
    {
        CreateDateTime = CreationDateTime.CreateNowDateTime();
    }

    #endregion

    #region Feild

    public CreationDateTime CreateDateTime { get; private set; }

    #endregion

    #region Protected Method

    protected void UpdateModifiedDateTime()
    {
        CreateDateTime = CreateDateTime.UpdateModifiedDateTime();
    }

    #endregion

}