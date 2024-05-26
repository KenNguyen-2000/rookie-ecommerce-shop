using System.Net.Http.Headers;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using RookEcomShop.CustomerFrontend.Services.Cart;
using RookEcomShop.CustomerFrontend.Services.Categories;
using RookEcomShop.CustomerFrontend.Services.Products;
using RookEcomShop.CustomerFrontend.Services.Reviews;

namespace RookEcomShop.CustomerFrontend
{
    public static class RookEcomShopMvcExtensions
    {
        public static IServiceCollection AddAuthenticationConfiguration(this IServiceCollection services)
        {


            services.AddControllersWithViews();

            services.AddAuthentication(options =>
                    {
                        options.DefaultScheme = "Cookies";
                        options.DefaultChallengeScheme = "oidc";
                    })
                        .AddCookie("Cookies")
                        .AddOpenIdConnect("oidc", options =>
                        {
                            options.Authority = "https://localhost:7280"; // IdentityServer Url

                            options.ClientId = "rookEcomShop.mvc";
                            options.ClientSecret = "49C1A7E1-0C79-4A89-A3D6-A37998FB86B0";
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
                        });
            return services;
        }

        public static IServiceCollection AddApiClientConfiguration(this IServiceCollection services)
        {
            var configureClient = new Action<IServiceProvider, HttpClient>(async (provider, client) =>
            {
                var httpContextAccessor = provider.GetRequiredService<IHttpContextAccessor>();
                var accessToken = await httpContextAccessor?.HttpContext?.GetTokenAsync("access_token") ?? "";
                client.BaseAddress = new Uri("https://localhost:7181/api/v1/");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            });

            services.AddHttpClient<IProductsApiClient, ProductsApiClient>(configureClient);
            services.AddHttpClient<ICategoriesApiClient, CategoriesApiClient>(configureClient);
            services.AddHttpClient<ICartApiClient, CartApiClient>(configureClient);
            services.AddHttpClient<IReviewsApiClient, ReviewsApiClient>(configureClient);
            services.AddHttpClient<IOrdersApiClient, OrdersApiClient>(configureClient);

            return services;
        }
    }
}