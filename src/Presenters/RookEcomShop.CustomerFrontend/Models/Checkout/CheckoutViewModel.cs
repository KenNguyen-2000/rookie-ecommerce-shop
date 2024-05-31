using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.CustomerFrontend.Models.Checkout;

public class CheckoutViewModel
{
    public IEnumerable<CartDetailDto> Items { get; set; } = new List<CartDetailDto>();
}