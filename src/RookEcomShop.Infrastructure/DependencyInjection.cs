using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using RookEcomShop.Application.Common.Interfaces.Authentication;
using RookEcomShop.Application.Common.Interfaces.Services;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Domain.Entities;
using RookEcomShop.Infrastructure.Extensions.Authentication;
using RookEcomShop.Infrastructure.Extensions.Cors;
using RookEcomShop.Infrastructure.Extensions.IdentityServer;
using RookEcomShop.Infrastructure.Persistence;
using RookEcomShop.Infrastructure.Persistence.Repositories;
using RookEcomShop.Infrastructure.Services;

namespace RookEcomShop.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {

            services
                .AddAuth(configuration)
                .AddPersistence(configuration);


            //services
            //    .ConfigureCors();
            services.AddSingleton<IDateTimeProvider, DateTimeProvider>();

            return services;
        }

        private static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            string? connectionString = configuration.GetConnectionString("DefaultConnection");
            if (string.IsNullOrEmpty(connectionString))
            {
                Console.WriteLine("Connection string not found");
                throw new Exception("Connection string not found");
            }
            services.AddDbContext<RookEcomShopDbContext>(opt =>
                opt.UseSqlServer(connectionString,
                    providerOptions =>
                    {
                        providerOptions.EnableRetryOnFailure();
                    }));

            services.AddControllersWithViews();

            //services
            //    .AddIdentity<User, IdentityRole<int>>()
            //    .AddEntityFrameworkStores<RookEcomShopDbContext>();

            //services.AddConfigIdentityServices(configuration);

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICartRepository, CartRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();

            //SeedData.EnsureSeedData(connectionString);

            return services;
        }

        private static IServiceCollection AddAuth(this IServiceCollection services, IConfiguration configuration)
        {
            var JwtSettings = new JwtSettings();
            configuration.Bind(JwtSettings.SectionName, JwtSettings);

            services.AddSingleton(Options.Create(JwtSettings));
            services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();

            //services.ConfigureAuthentication(configuration);

            return services;
        }
    }
}
