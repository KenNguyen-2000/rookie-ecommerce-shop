using Microsoft.AspNetCore.Mvc;

namespace RookEcomShop.Api.Controllers.v1
{
    [Route("api/v1/products{productId}/reviews")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProductReviews()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult ReviewProduct(int productId)
        {
            return Ok();
        }

        [HttpDelete("{reviewId}")]
        public IActionResult RemoveReview(int reviewId)
        {
            return Ok();
        }
        [HttpPut("{reviewId}")]
        public IActionResult UpdateReview(int reviewId)
        {
            return Ok();
        }
    }
}
