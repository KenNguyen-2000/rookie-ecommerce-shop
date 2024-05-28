using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RookEcomShop.CustomerFrontend.Models.Reviews;
using RookEcomShop.CustomerFrontend.Services.Reviews;

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
            try
            {
                Console.WriteLine("Hello World!" + request.Content);
                await _reviewsApiClient.ReviewProductAsync(new ReviewsProductInputModel
                {
                    ProductId = productId,
                    Content = request.Content,
                    Rating = request.Rating
                });
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e);
            }

            return Redirect($"/products/{request.ProductId}");
        }

        [HttpPost("{reviewId}")]
        public async Task<IActionResult> RemoveReview(Guid productId, Guid reviewId)
        {
            try
            {
                Console.WriteLine("ReviewsController: Remove review " + reviewId + " for product " + productId);
                await _reviewsApiClient.RemoveReviewAsync(productId, reviewId);
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e);
            }

            return Redirect($"/products/{productId}");
        }
    }
}
