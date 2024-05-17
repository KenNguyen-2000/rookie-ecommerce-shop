namespace RookEcomShop.Api
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPresentation(this IServiceCollection services)
        {
            services.AddAuthentication("Bearer")
           .AddJwtBearer("Bearer", options =>
           {
               options.Authority = "https://localhost:5001"; // IdentityServer URL
               options.Audience = "rookEcomShop.api";
           });

            services.AddControllers();
            services.AddAuthorization();

            return services;
        }
    }
}
