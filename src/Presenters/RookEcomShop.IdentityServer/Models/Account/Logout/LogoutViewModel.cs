namespace RookEcomShop.IdentityServer.Models.Account.Logout
{
    public class LogoutViewModel : LogoutInputModel
    {
        public bool ShowLogoutPrompt { get; set; } = true;
    }
}
