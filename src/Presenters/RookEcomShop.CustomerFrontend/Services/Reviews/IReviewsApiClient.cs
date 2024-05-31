using RookEcomShop.CustomerFrontend.Models.Reviews;
using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.CustomerFrontend.Services.Reviews
{
    public interface IReviewsApiClient
    {
        Task<PaginatedList<ReviewDto>> GetReviewsAsync(Guid productId);
        Task ReviewProductAsync(ReviewsProductInputModel request);
        Task RemoveReviewAsync(Guid productId, Guid reviewId);
    }
}