using RookEcomShop.ViewModels.Reviews;

namespace RookEcomShop.ViewModels.Product
{
    public class ProductDetailsVM
    {
        public ProductVM Product { get; set; } = null!;
        public IEnumerable<ReviewVM> Reviews { get; set; } = new List<ReviewVM>();
        public AddToCartInput AddToCartInput { get; set; } = new AddToCartInput();
    }
}