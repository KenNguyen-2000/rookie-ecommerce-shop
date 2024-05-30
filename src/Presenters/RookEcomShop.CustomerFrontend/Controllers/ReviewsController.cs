using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RookEcomShop.CustomerFrontend.Models.Reviews;
using RookEcomShop.CustomerFrontend.Services.Reviews;
using Serilog;

namespace RookEcomShop.CustomerFrontend.Controllers
{
    [Authorize]
    [Route("products/{productId}/reviews")]
    public class ReviewsController : Controller
    {
        private readonly IReviewsApiClient _reviewsApiClient;

        public ReviewsController(IReviewsApiClient reviewsApiClient)
        {
            _reviewsApiClient = reviewsApiClient;
        }

        [HttpPost]
        public async Task<IActionResult> AddReview(Guid productId, ReviewsProductInputModel request)
        {
            Log.Information<ReviewsProductInputModel>("ReviewsController: [BEGIN] Add review for product", request);

            await _reviewsApiClient.ReviewProductAsync(new ReviewsProductInputModel
            {
                ProductId = productId,
                Content = request.Content,
                Rating = request.Rating
            });

            Log.Information<ReviewsProductInputModel>("ReviewsController: [END] Add review for product", request);

            return Redirect($"/products/{request.ProductId}");
        }

        [HttpPost("{reviewId}")]
        public async Task<IActionResult> RemoveReview(Guid productId, Guid reviewId)
        {
            Console.WriteLine("ReviewsController: Remove review " + reviewId + " for product " + productId);
            await _reviewsApiClient.RemoveReviewAsync(productId, reviewId);

            return Redirect($"/products/{productId}");
        }
    }
}
