using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using RookEcomShop.Application.Common.Behaviors;
using RookEcomShop.Application.Services;
using System.Reflection;

namespace RookEcomShop.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();

            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssembly(assembly);

            });
            services.AddScoped(
                typeof(IPipelineBehavior<,>),
                typeof(ValidationBehavior<,>));

            services.AddScoped<IFileStorageService, FileStorageService>();

            services
                .AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());



            return services;
        }

    }
}
