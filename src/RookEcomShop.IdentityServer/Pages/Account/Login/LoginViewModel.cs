
namespace RookEcomShop.IdentityServer.Pages.Account.Login
{
    public class LoginViewModel : LoginInputModel
    {
        public bool AllowRememberLogin { get; set; } = true;
        public bool EnableLocalLogin { get; set; } = true;


    }
}
