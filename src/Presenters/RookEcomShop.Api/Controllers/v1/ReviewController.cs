using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RookEcomShop.Application.Common.Helpers;
using RookEcomShop.Application.Handlers.Reviews.Create;
using RookEcomShop.Application.Handlers.Reviews.Delete;
using RookEcomShop.Application.Handlers.Reviews.GetList;
using RookEcomShop.Application.Handlers.Reviews.Update;
using RookEcomShop.ViewModels.Contracts.Reviews;

namespace RookEcomShop.Api.Controllers.v1
{
    [Authorize]
    [Route("api/v1/products/{productId}/reviews")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly ISender _sender;
        private readonly UserContext _userContext;

        public ReviewController(ISender sender, UserContext userContext)
        {
            _sender = sender;
            _userContext = userContext;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> GetProductReviews(Guid productId)
        {
            var query = new GetReviewsListQuery
            {
                ProductId = productId
            };
            var result = await _sender.Send(query);

            if (result.IsFailed)
                return BadRequest(result.Errors);

            return Ok(result.Value);
        }

        [HttpPost]
        public async Task<IActionResult> ReviewProduct(Guid productId, CreateReviewRequest createViewRequest)
        {
            var command = new CreateReviewCommand
            {
                ProductId = productId,
                UserId = _userContext.UserId,
                Rating = createViewRequest.Rating,
                Content = createViewRequest.Content
            };
            var result = await _sender.Send(command);
            if (result.IsFailed)
                return BadRequest(result.Errors);

            return Ok();
        }

        [HttpDelete("{reviewId}")]
        public IActionResult RemoveReview(Guid reviewId)
        {
            var command = new DeleteReviewCommand
            {
                Id = reviewId,
                UserId = _userContext.UserId
            };

            var result = _sender.Send(command).Result;

            if (result.IsFailed)
                return BadRequest(result.Errors);

            return Ok();
        }

        [HttpPut("{reviewId}")]
        public async Task<IActionResult> UpdateReview(Guid productId, Guid reviewId, UpdateReviewRequest updateReviewRequest)
        {
            var command = new UpdateReviewCommand
            {
                Id = reviewId,
                Content = updateReviewRequest.Content,
                ProductId = productId,
                Rating = updateReviewRequest.Rating,
                UserId = _userContext.UserId
            };
            var result = await _sender.Send(command);

            if (result.IsFailed)
                return BadRequest(result.Errors);
            return Ok();
        }
    }
}
