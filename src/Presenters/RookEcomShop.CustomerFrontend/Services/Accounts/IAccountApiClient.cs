namespace RookEcomShop.CustomerFrontend.Services.Accounts
{
    public interface IAccountApiClient
    {
        Task<dynamic?> GetUser();
    }
}
