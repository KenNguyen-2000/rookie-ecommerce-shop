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
        public ProductVM Product { get; set; } = null!;
        public ReviewsProductInputModel ReviewsProductInputModel { get; set; } = new ReviewsProductInputModel();
        public IEnumerable<ReviewVM> Reviews { get; set; } = new List<ReviewVM>();
        public double AverageRating => Reviews.Any() ? Reviews.Average(x => x.Rating) : 0;
        public int GetRatingCount(int rating) => Reviews.Count(x => x.Rating == rating);

        public int TotalFiveStar => GetRatingCount(5);
        public int TotalFourStar => GetRatingCount(4);
        public int TotalThreeStar => GetRatingCount(3);
        public int TotalTwoStar => GetRatingCount(2);
        public int TotalOneStar => GetRatingCount(1);
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
