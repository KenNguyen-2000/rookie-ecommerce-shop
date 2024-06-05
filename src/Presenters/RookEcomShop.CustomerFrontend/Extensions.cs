using Microsoft.AspNetCore.Authentication;
using RookEcomShop.CustomerFrontend.Extensions;
using RookEcomShop.CustomerFrontend.Services.Accounts;
using RookEcomShop.CustomerFrontend.Services.Cart;
using RookEcomShop.CustomerFrontend.Services.Categories;
using RookEcomShop.CustomerFrontend.Services.Orders;
using RookEcomShop.CustomerFrontend.Services.Products;
using RookEcomShop.CustomerFrontend.Services.Reviews;
using System.Net.Http.Headers;
using System.Security.Claims;

namespace RookEcomShop.CustomerFrontend
{
    public static class RookEcomShopMvcExtensions
    {
        public static IServiceCollection AddAuthenticationConfiguration(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddControllersWithViews();

            services.AddAuthentication(options =>
                    {
                        options.DefaultScheme = "Cookies";
                        options.DefaultChallengeScheme = "oidc";
                    })
                        .AddCookie("Cookies", options =>
                        {
                            options.SlidingExpiration = false;
                        })
                        .AddOpenIdConnect("oidc", options =>
                        {
                            options.Authority = "https://localhost:7280"; // IdentityServer Url

                            options.ClientId = configuration["IdentityConnectionSettings:ClientId"];
                            options.ClientSecret = configuration["IdentityConnectionSettings:ClientSecret"];
                            options.ResponseType = "code";
                            options.SaveTokens = true;

                            options.Scope.Add("openid");
                            options.Scope.Add("profile");
                            options.Scope.Add("rookEcomShop.api");
                            options.Scope.Add("offline_access");

                            options.GetClaimsFromUserInfoEndpoint = true;
                            options.ClaimActions.MapJsonKey(ClaimTypes.Role, "role");
                            options.TokenValidationParameters.NameClaimType = "name";
                            options.TokenValidationParameters.RoleClaimType = "role";

                            options.Events.OnTicketReceived = context =>
                            {
                                var accessToken = context.Properties.GetTokenValue("access_token");
                                var refreshToken = context.Properties.GetTokenValue("refresh_token");

                                context.HttpContext.Items.Add("access_token", accessToken);
                                context.HttpContext.Items.Add("refresh_token", refreshToken);

                                return Task.CompletedTask;
                            };
                        });
            return services;
        }

        public static IServiceCollection AddApiClientConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<UnauthorizedHttpClientHandler>();

            var configureClient = new Action<IServiceProvider, HttpClient>(async (provider, client) =>
            {
                var httpContextAccessor = provider.GetRequiredService<IHttpContextAccessor>();
                string? accessToken = await httpContextAccessor?.HttpContext?.GetTokenAsync("access_token") ?? "";
                client.BaseAddress = new Uri(configuration["ApiEndpoint"] ?? "");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            });

            // Register all HttpClients with the custom handler
            void RegisterHttpClient<TClient, TImplementation>()
                where TClient : class
                where TImplementation : class, TClient
            {
                services.AddHttpClient<TClient, TImplementation>(configureClient)
                        .AddHttpMessageHandler<UnauthorizedHttpClientHandler>();
            }

            RegisterHttpClient<IProductsApiClient, ProductsApiClient>();
            RegisterHttpClient<ICategoriesApiClient, CategoriesApiClient>();
            RegisterHttpClient<ICartApiClient, CartApiClient>();
            RegisterHttpClient<IReviewsApiClient, ReviewsApiClient>();
            RegisterHttpClient<IOrdersApiClient, OrdersApiClient>();
            RegisterHttpClient<IAccountApiClient, AccountApiClient>();


            return services;
        }
    }
}