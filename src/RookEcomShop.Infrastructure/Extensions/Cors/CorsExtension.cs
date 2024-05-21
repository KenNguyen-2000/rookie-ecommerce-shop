using Microsoft.Extensions.DependencyInjection;

namespace RookEcomShop.Infrastructure.Extensions.Cors
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
                        //.AllowCredentials()
                        .WithOrigins("https://localhost:7019", "http://localhost:3000", "https://localhost:7280")
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                });
            });
        }
    }
}
