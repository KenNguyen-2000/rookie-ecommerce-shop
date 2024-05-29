namespace RookEcomShop.CustomerFrontend.Middlewares
{
    public class UnauthorizedRedirectMiddleware
    {
        private readonly RequestDelegate _next;

        public UnauthorizedRedirectMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch(UnauthorizedAccessException)
            {
                context.Response.Redirect("/Account/Login");
            }
        }
    }
}
