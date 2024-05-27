using System.Net.Http.Headers;
using FluentResults;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using RookEcomShop.Api.Extensions;
using RookEcomShop.Application.Handlers.Users.GetById;

namespace RookEcomShop.Api
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPresentation(this IServiceCollection services)
        {
            services.AddControllers();
            services.AddHttpContextAccessor();

            var configureClient = new Action<IServiceProvider, HttpClient>(async (provider, client) =>
            {
                var httpContextAccessor = provider.GetRequiredService<IHttpContextAccessor>();
                var accessToken = await httpContextAccessor?.HttpContext?.GetTokenAsync("access_token") ?? "";
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
                client.BaseAddress = new Uri("https://localhost:7280/");
            });

            services.AddHttpClient<IRequestHandler<GetUserByIdQuery, Result>, GetUserByIdQueryHandler>(configureClient);

            return services;
        }
    }
}
