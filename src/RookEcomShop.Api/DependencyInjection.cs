namespace RookEcomShop.Api
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPresentation(this IServiceCollection services)
        {
            services.AddControllers();

            services.AddAuthentication("Bearer")
                     .AddIdentityServerAuthentication("Bearer", options =>
                     {
                         options.ApiName = "rookEcomShop.api";
                         options.Authority = "https://localhost:7280";
                     });

            return services;
        }
    }
}
