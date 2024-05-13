using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RookEcomShop.Application.Common.Interfaces.Services;
using RookEcomShop.Infrastructure.Services;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IDateTimeProvider, DateTimeProvider>();

            return services;
        }
    }
}
