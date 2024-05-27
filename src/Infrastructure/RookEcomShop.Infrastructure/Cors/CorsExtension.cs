using Microsoft.Extensions.DependencyInjection;

namespace RookEcomShop.Infrastructure.Cors
{
    public static class CorsExtension
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(name: "RookEcomShop", builder =>
                {
                    builder
                        //.WithOrigins("https://rook-ecom-shop.vercel.app", "http://localhost:3000")
                        //.SetIsOriginAllowedToAllowWildcardSubdomains()
                        .WithOrigins("https://localhost:7019", "http://localhost:5173", "https://localhost:7280")
                        .AllowCredentials()
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                });
            });
        }
    }
}
