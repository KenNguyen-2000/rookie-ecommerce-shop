using Microsoft.AspNetCore.Mvc;
using RookEcomShop.CustomerFrontend.Models.Reviews;
using RookEcomShop.CustomerFrontend.Services.Reviews;
using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.CustomerFrontend.ViewComponents
{
    public class ProductReviewsVM
    {
        public ProductDto Product { get; set; } = null!;
        public ReviewsProductInputModel ReviewsProductInputModel { get; set; } = new ReviewsProductInputModel();
        public PaginatedList<ReviewDto> Reviews { get; set; } = new PaginatedList<ReviewDto>();
        public double AverageRating => Reviews.Items.Any() ? Reviews.Items.Average(x => x.Rating) : 0;
        public int GetRatingCount(int rating) => Reviews.Items.Count(x => x.Rating == rating);

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
