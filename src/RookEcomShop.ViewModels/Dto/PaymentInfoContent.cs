namespace RookEcomShop.ViewModels.Dto
{
    public class PaymentInfoContent
    {
        public string ContactInfo { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string ShippingAddress { get; set; } = null!;
        public string? City { get; set; }
        public string? PostalCode { get; set; }
        public string? Province { get; set; }

    }
}
