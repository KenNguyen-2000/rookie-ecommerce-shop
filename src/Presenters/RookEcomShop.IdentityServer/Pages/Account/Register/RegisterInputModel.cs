using System.ComponentModel.DataAnnotations;

namespace RookEcomShop.IdentityServer.Views.Account.Register
{
    public class RegisterInputModel
    {
        [Required(ErrorMessage = "Field is required")]
        [MinLength(2, ErrorMessage = "Firstname must be at least 2 characters long")]
        [MaxLength(50, ErrorMessage = "Firstname must be at most 50 characters long")]
        public string Firstname { get; set; } = null!;

        [Required(ErrorMessage = "Field is required")]
        [MinLength(2, ErrorMessage = "Firstname must be at least 2 characters long")]
        [MaxLength(50, ErrorMessage = "Firstname must be at most 50 characters long")]
        public string Lastname { get; set; } = null!;

        [EmailAddress]
        public string? Email { get; set; }

        [MinLength(10, ErrorMessage = "Phone number must be between 10-15 characters long")]
        [MaxLength(15, ErrorMessage = "Phone number must be between 10-15 characters long")]
        public string? PhoneNumber { get; set; }

        [Required(ErrorMessage = "Field is required")]
        [MinLength(6, ErrorMessage = "Username must be at least 6 characters long")]
        public string Username { get; set; } = null!;

        [Required(ErrorMessage = "Field is required")]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters long")]
        public string Password { get; set; } = null!;

        [Required(ErrorMessage = "Field is required")]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; } = null!;
    }
}