using RookEcomShop.ViewModels.Dto;
using RookEcomShop.ViewModels.ViewModels;

namespace RookEcomShop.CustomerFrontend.Services.Reviews
{
    public interface IReviewsApiClient
    {
        Task<PaginatedList<ReviewDto>> GetReviewsAsync(Guid productId);
        Task ReviewProductAsync(ReviewsProductInputModel request);
        Task UpdateReviewAsync(ReviewsProductInputModel request);
        Task RemoveReviewAsync(Guid productId, Guid reviewId);
    }
}