using Microsoft.AspNetCore.Mvc;
using RookEcomShop.ViewModels.Dto;
using System.ComponentModel.DataAnnotations;

namespace RookEcomShop.CustomerFrontend.Models.Checkout;

public class CheckoutViewModel
{
    public IEnumerable<CartDetailDto> Items { get; set; } = new List<CartDetailDto>();
    [BindProperty]
    public PaymentTransactionInputModel PaymentTransactionInputModel { get; set; } = new PaymentTransactionInputModel();
}

public class PaymentTransactionInputModel
{
    [Required]
    [DataType(DataType.EmailAddress | DataType.PhoneNumber)]
    public string ContactInfo { get; set; } = null!;
    [Required]
    public string FirstName { get; set; } = null!;
    [Required]
    public string LastName { get; set; } = null!;
    [Required]
    public string ShippingAddress { get; set; } = null!;
    public string? City { get; set; }
    public string? PostalCode { get; set; }
    public string? Province { get; set; }
}