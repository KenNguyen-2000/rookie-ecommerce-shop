using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RookEcomShop.Infrastructure.Extensions.GlobalExceptonHandler
{
    public static class GlobalExceptionHandlerExtension
    {
        public static void UseGlobalExceptionHandler(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(appError =>
            {
                appError.Run(async context =>
                {
                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    context.Response.StatusCode = StatusCodes.Status500InternalServerError;

                    if (contextFeature is null) return;

                    var errorResponse = new ProblemDetails
                    {
                        Status = context.Response.StatusCode,
                        Title = "Internal Server Error",
                        Detail = contextFeature.Error.GetBaseException().Message,
                        Extensions =
                        {
                            ["traceId"] = context.TraceIdentifier
                        },
                        Type = "https://tools.ietf.org/html/rfc7231#section-6.6.1"
                    };

                    await context.Response.WriteAsJsonAsync(errorResponse);
                });
            });
        }
    }
}
