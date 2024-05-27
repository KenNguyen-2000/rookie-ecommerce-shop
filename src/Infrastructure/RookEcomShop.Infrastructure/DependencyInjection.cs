using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using RookEcomShop.Application.Common.Interfaces.Services;
using RookEcomShop.Infrastructure.Authentication;
using RookEcomShop.Infrastructure.Cors;
using RookEcomShop.Infrastructure.Services;
using RookEcomShop.Infrastructure.Swagger;

namespace RookEcomShop.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var JwtSettings = new JwtSettings();
            configuration.Bind(JwtSettings.SectionName, JwtSettings);

            services.ConfigureAuthentication(configuration);
            services.AddSwaggerConfig();
            services.ConfigureCors();

            services.AddSingleton(Options.Create(JwtSettings));
            services.AddSingleton<IDateTimeProvider, DateTimeProvider>();

            return services;
        }

        public static void ConfigureIdentityService(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IProfileService, ProfileService>();
        }

    }
}
