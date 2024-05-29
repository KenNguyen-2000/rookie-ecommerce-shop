using Microsoft.AspNetCore.Authentication;

namespace RookEcomShop.CustomerFrontend.Middlewares
{
    public class TokenRenewalMiddleware
    {
        private readonly RequestDelegate _next;

        public TokenRenewalMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var token = await context.GetTokenAsync("access_token");
            if (token != null)
            {
            }
            await _next(context);
        }
    }
}
