namespace RookEcomShop.ViewModels.Dto
{
    public class CartDetailDto
    {
        public Guid Id { get; set; }
        public int Quantity { get; set; }
        public ProductDto Product { get; set; } = null!;
    }
}
