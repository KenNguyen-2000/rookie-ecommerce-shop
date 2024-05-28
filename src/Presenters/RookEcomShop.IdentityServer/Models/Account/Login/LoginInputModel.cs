using System.ComponentModel.DataAnnotations;

namespace RookEcomShop.IdentityServer.Models.Account.Login
{
    public class LoginInputModel
    {
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; } = null!;
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; } = null!;
        public bool RememberLogin { get; set; }
        public string? ReturnUrl { get; set; }
    }
}
