using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using RookEcomShop.Infrastructure.ConfigurationOptions;

namespace RookEcomShop.Infrastructure.Cors
{
    public static class CorsExtension
    {
        public static void ConfigureCors(this IServiceCollection services, AppSettings appSettings)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(name: "RookEcomShop", builder =>
                {
                    builder
                        .WithOrigins(appSettings.Cors.AllowedOrigins)
                        .AllowCredentials()
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                });
            });
        }
    }
}
