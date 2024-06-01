using Microsoft.AspNetCore.Mvc;
using RookEcomShop.CustomerFrontend.Services.Reviews;
using RookEcomShop.ViewModels.Dto;
using RookEcomShop.ViewModels.ViewModels;

namespace RookEcomShop.CustomerFrontend.ViewComponents
{


    [ViewComponent(Name = "ProductReviews")]
    public class ProductReviewsViewComponent : ViewComponent
    {
        private readonly IReviewsApiClient _reviewsApiClient;

        public ProductReviewsViewComponent(IReviewsApiClient reviewsApiClient)
        {
            _reviewsApiClient = reviewsApiClient;
        }
        public async Task<IViewComponentResult> InvokeAsync(ProductDto product)
        {
            var reviews = await _reviewsApiClient.GetReviewsAsync(product.Id);

            return View(new ProductReviewsVM
            {
                Product = product,
                Reviews = reviews,
                ReviewsProductInputModel = new ReviewsProductInputModel
                {
                    ProductId = product.Id
                }
            });
        }
    }
}
