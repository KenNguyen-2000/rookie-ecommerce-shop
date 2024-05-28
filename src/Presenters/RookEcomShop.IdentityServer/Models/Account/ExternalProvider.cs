namespace RookEcomShop.IdentityServer.Models.Account
{
    public class ExternalProvider
    {
        public string DisplayName { get; set; } = null!;
        public string AuthenticationScheme { get; set; } = null!;
    }
}
