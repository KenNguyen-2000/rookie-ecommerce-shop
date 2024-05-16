namespace RookEcomShop.ViewModels.Identity
{
    public class RegisterRequest
    {

        public string Email { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string ConfirmPassword { get; set; } = null!;
        public string? PhoneNumber { get; set; }
        public DateTime Dob { get; set; }
    }
}
