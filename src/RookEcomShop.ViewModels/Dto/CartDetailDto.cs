namespace RookEcomShop.ViewModels.Dto
{
    public class CartDetailDto : ProductDto
    {
        public int Quantity { get; set; }
        public ProductDto Product { get; set; } = null!;
    }
}
