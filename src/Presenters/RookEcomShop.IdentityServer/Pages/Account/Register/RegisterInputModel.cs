using System.ComponentModel.DataAnnotations;

namespace RookEcomShop.IdentityServer.Pages.Account.Register
{
    public class RegisterInputModel
    {
        [Required]
        public string Firstname { get; set; } = null!;
        [Required]
        public string Lastname { get; set; } = null!;
        [Required]
        public string Email { get; set; } = null!;
        [Required]
        public string Password { get; set; } = null!;
        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; } = null!;
    }
}