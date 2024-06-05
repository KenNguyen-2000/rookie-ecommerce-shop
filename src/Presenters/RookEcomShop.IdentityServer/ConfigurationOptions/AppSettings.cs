
namespace RookEcomShop.IdentityServer.ConfigurationOptions
{
    public class AppSettings
    {
        public ConnectionStrings? ConnectionStrings { get; set; }
        public Cors? Cors { get; set; }
        public IdentityServerSettings? IdentityServerSettings { get; set; }
    }
}
