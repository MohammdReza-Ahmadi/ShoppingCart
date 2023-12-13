namespace ShoppingCartApi.Helpers.FackData;
public static class GenerateFackId
{

    public static long FackId()
    {
        Random rnd = new Random();
        long id = rnd.Next(1, 8);
        return id;
    }
}
