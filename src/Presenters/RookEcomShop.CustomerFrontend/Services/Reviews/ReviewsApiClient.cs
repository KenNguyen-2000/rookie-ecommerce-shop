using Newtonsoft.Json;
using RookEcomShop.Application.Dto;
using RookEcomShop.CustomerFrontend.Services.Helpers;
using RookEcomShop.ViewModels.Contracts.Reviews;
using RookEcomShop.ViewModels.Dto;
using RookEcomShop.ViewModels.ViewModels;
using Serilog;
using System.Text;

namespace RookEcomShop.CustomerFrontend.Services.Reviews
{
    public class ReviewsApiClient : IReviewsApiClient
    {
        private readonly HttpClient _httpClient;

        public ReviewsApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<PaginatedList<ReviewDto>> GetReviewsAsync(Guid productId)
        {
            var response = await _httpClient.GetAsync($"products/{productId}/reviews?{QueryHelper.ToQueryString(new QueryDto() { Page = 1, PageSize = 10 })}");

            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();
            var reviews = JsonConvert.DeserializeObject<PaginatedList<ReviewDto>>(content)!;
            return reviews;
        }

        public async Task RemoveReviewAsync(Guid productId, Guid reviewId)
        {
            var response = await _httpClient.DeleteAsync($"products/{productId}/reviews/{reviewId}");
            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();

            Log.Information(content);
        }

        public async Task ReviewProductAsync(ReviewsProductInputModel request)
        {
            var jsonData = JsonConvert.SerializeObject(new CreateReviewRequest
            {
                Content = request.Content,
                Rating = request.Rating
            });
            var bodyContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync($"products/{request.ProductId}/reviews", bodyContent);

            response.EnsureSuccessStatusCode();
            // Read the response content
            string responseBody = await response.Content.ReadAsStringAsync();

            // Output the response
            Log.Information(responseBody);
        }

        public async Task UpdateReviewAsync(ReviewsProductInputModel request)
        {

            var jsonData = JsonConvert.SerializeObject(new UpdateReviewRequest
            {
                ProductId = request.ProductId,
                Content = request.Content,
                Rating = request.Rating
            });
            var bodyContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync($"products/{request.ProductId}/reviews/{request.ReviewId}", bodyContent);

            response.EnsureSuccessStatusCode();
            // Read the response content
            string responseBody = await response.Content.ReadAsStringAsync();

            // Output the response
            Log.Information(responseBody);
        }
    }
}