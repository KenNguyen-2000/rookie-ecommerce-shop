using FluentResults;
using MediatR;
using Newtonsoft.Json;

namespace RookEcomShop.Application.Handlers.Users.GetById
{
    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, Result>
    {
        private readonly HttpClient _httpClient;

        public GetUserByIdQueryHandler(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Result> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var response = await _httpClient.GetAsync($"/api/v1/users");
            if (!response.IsSuccessStatusCode)
            {
                return Result.Fail("Failed to get user profile");
            }

            var content = await response.Content.ReadAsStringAsync();
            var user = JsonConvert.DeserializeObject<dynamic>(content);
            Console.WriteLine(user);
            await Task.CompletedTask;
            return Result.Ok();
        }
    }
}