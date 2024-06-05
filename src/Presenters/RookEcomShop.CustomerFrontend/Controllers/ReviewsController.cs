using Microsoft.AspNetCore.Mvc;
using RookEcomShop.CustomerFrontend.Services.Reviews;
using RookEcomShop.ViewModels.ViewModels;
using Serilog;

namespace RookEcomShop.CustomerFrontend.Controllers
{
    //[Authorize]
    [Route("products/{productId}/reviews")]
    public class ReviewsController : Controller
    {
        private readonly IReviewsApiClient _reviewsApiClient;

        public ReviewsController(IReviewsApiClient reviewsApiClient)
        {
            _reviewsApiClient = reviewsApiClient;
        }

        [HttpPost]
        public async Task<IActionResult> AddReview(Guid productId, string button, ReviewsProductInputModel request)
        {
            Log.Information<ReviewsProductInputModel>("ReviewsController: [BEGIN] Add review for product", request);

            if (button == "create")
            {
                await _reviewsApiClient.ReviewProductAsync(new ReviewsProductInputModel
                {
                    ProductId = productId,
                    Content = request.Content,
                    Rating = request.Rating
                });
            }
            else
            {
                await _reviewsApiClient.UpdateReviewAsync(new ReviewsProductInputModel
                {
                    ProductId = productId,
                    Content = request.Content,
                    Rating = request.Rating,
                    ReviewId = request.ReviewId
                });
            }



            Log.Information<ReviewsProductInputModel>("ReviewsController: [END] Add review for product", request);

            return Redirect($"/products/{request.ProductId}");
        }

        [HttpPost("remove")]
        public async Task<IActionResult> RemoveReview(Guid productId, Guid reviewId)
        {
            Console.WriteLine("ReviewsController: Remove review " + reviewId + " for product " + productId);
            await _reviewsApiClient.RemoveReviewAsync(productId, reviewId);

            return Redirect($"/products/{productId}");
        }
    }
}
