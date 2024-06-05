using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using RookEcomShop.Application.Common.Interfaces.Services;
using RookEcomShop.Infrastructure.Authentication;
using RookEcomShop.Infrastructure.ConfigurationOptions;
using RookEcomShop.Infrastructure.Cors;
using RookEcomShop.Infrastructure.Services;
using RookEcomShop.Infrastructure.Swagger;

namespace RookEcomShop.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
            IConfiguration configuration, AppSettings appSettings)
        {

            services.ConfigureAuthentication(configuration, appSettings);
            services.AddSwaggerConfig();
            services.ConfigureCors(appSettings);

            services.AddSingleton<IDateTimeProvider, DateTimeProvider>();

            return services;
        }

    }
}
