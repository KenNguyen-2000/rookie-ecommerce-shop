using System.ComponentModel.DataAnnotations;

namespace RookEcomShop.IdentityServer.Pages.Account.Login
{
    public class LoginInputModel
    {
        [Required]
        public string Username { get; set; } = null!;
        [Required]
        public string Password { get; set; } = null!;
        public bool RememberLogin { get; set; }
        public string ReturnUrl { get; set; } = null!;
    }
}
