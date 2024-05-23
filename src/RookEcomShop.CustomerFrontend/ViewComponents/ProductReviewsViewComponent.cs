using Microsoft.AspNetCore.Mvc;
using RookEcomShop.CustomerFrontend.Models.Reviews;
using RookEcomShop.CustomerFrontend.Services.Reviews;
using RookEcomShop.Domain.Entities;
using RookEcomShop.ViewModels.Product;
using RookEcomShop.ViewModels.Reviews;

namespace RookEcomShop.CustomerFrontend.ViewComponents
{
    public class ProductReviewsVM
    {
        public ReviewsProductInputModel ReviewsProductInputModel { get; set; } = new ReviewsProductInputModel();
        public IEnumerable<ReviewVM> Reviews { get; set; } = new List<ReviewVM>();
    }

    [ViewComponent(Name = "ProductReviews")]
    public class ProductReviewsViewComponent : ViewComponent
    {
        private readonly IReviewsApiClient _reviewsApiClient;

        public ProductReviewsViewComponent(IReviewsApiClient reviewsApiClient)
        {
            _reviewsApiClient = reviewsApiClient;
        }
        public async Task<IViewComponentResult> InvokeAsync(ProductVM product)
        {
            var reviews = await _reviewsApiClient.GetReviews(product.Id);
            return View(new ProductReviewsVM
            {
                Reviews = reviews
            });
        }
    }
}
