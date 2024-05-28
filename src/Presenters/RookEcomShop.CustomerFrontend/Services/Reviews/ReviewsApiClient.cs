using Newtonsoft.Json;
using RookEcomShop.CustomerFrontend.Models.Reviews;
using RookEcomShop.ViewModels.Reviews;
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

        public async Task<IEnumerable<ReviewVM>> GetReviews(Guid productId)
        {
            var response = await _httpClient.GetAsync($"products/{productId}/reviews");

            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();
            var reviews = JsonConvert.DeserializeObject<IEnumerable<ReviewVM>>(content)!;
            return reviews;
        }

        public async Task RemoveReviewAsync(Guid productId, Guid reviewId)
        {
            var response = await _httpClient.DeleteAsync($"products/{productId}/reviews/{reviewId}");
            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();

            Console.WriteLine(content);
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
            Console.WriteLine(responseBody);
        }
    }
}