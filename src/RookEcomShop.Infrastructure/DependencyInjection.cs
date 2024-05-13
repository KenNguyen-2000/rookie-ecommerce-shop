using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RookEcomShop.Application.Common.Interfaces.Services;
using RookEcomShop.Infrastructure.Persistence;
using RookEcomShop.Infrastructure.Services;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddPersistence(configuration);

            services.AddSingleton<IDateTimeProvider, DateTimeProvider>();

            return services;
        }

        private static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            string? connectionString = configuration.GetConnectionString("DefaultConnection");
            if (string.IsNullOrEmpty(connectionString))
            {
                Console.WriteLine("Connection string not found");
                throw new System.Exception("Connection string not found");
            }
            services.AddDbContext<RookEcomShopDbContext>(opt =>
                opt.UseSqlServer(connectionString,
                    providerOptions =>
                    {
                        providerOptions.EnableRetryOnFailure();
                    }));


            return services;
        }
    }
}
