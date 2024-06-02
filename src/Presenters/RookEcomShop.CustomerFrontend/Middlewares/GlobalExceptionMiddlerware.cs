using Serilog;

namespace RookEcomShop.CustomerFrontend.Middlewares
{
    public class GlobalExceptionMiddlerware
    {
        private readonly RequestDelegate _next;

        public GlobalExceptionMiddlerware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (UnauthorizedAccessException)
            {
                context.Response.Redirect("/Account/SignIn");
            }
            catch (Exception ex)
            {
                Log.Error(ex, "An unhandled exception occurred.");
                await HandleExceptionAsync(context, ex);
            }
        }


        private Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            if (context.Response.StatusCode == 404)
            {
                context.Response.Redirect("/Error/NotFound");
                return Task.CompletedTask;
            }
            context.Response.Redirect($"/Error");
            return Task.CompletedTask;
        }
    }
}
