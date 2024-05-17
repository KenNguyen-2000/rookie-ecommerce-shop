namespace RookEcomShop.Api
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPresentation(this IServiceCollection services)
        {
            services.AddAuthentication("Bearer")
                .AddLocalApi("Bearer", options =>
                {
                    options.ExpectedScope = "rookEcomShop.api";
                });
           //.AddJwtBearer("Bearer", options =>
           //{
           //    options.Authority = "https://localhost:7280"; // IdentityServer URL
           //    options.Audience = "rookEcomShop.client";
           //});

            services.AddControllers();
            services.AddAuthorization();

            return services;
        }
    }
}
