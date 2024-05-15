


using Microsoft.Extensions.DependencyInjection;
using RookEcomShop.Application.Services.CategoryService;
using RookEcomShop.Application.Services.ProductService;

namespace Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICategoryService, CategoryService>();

            return services;
        }

    }
}
