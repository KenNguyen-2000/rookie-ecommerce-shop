using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RookEcomShop.Application.Common.Exceptions;
using System.Net;
using System.Text.Json;

namespace RookEcomShop.Api.Middlewares
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

                    if (contextFeature is null) return;

                    //context.Response.Headers.Add("Access-Control-Allow-Origin", "*");
                    context.Response.ContentType = "application/json";

                    context.Response.StatusCode = contextFeature.Error switch
                    {
                        BadRequestException => (int)HttpStatusCode.BadRequest,
                        NotFoundException => (int)HttpStatusCode.NotFound,
                        ForbiddenException => (int)HttpStatusCode.Forbidden,
                        BusinessConflictException => (int)HttpStatusCode.Conflict,
                        _ => (int)HttpStatusCode.InternalServerError
                    };

                    var errorResponse = new ProblemDetails
                    {
                        Status = context.Response.StatusCode,
                        Title = "Internal Server Error",
                        Detail = contextFeature.Error.GetBaseException().Message,
                        Extensions =
                        {
                            ["traceId"] = context.TraceIdentifier,
                            ["errors"] = contextFeature.Error is BadRequestException badRequestException ? badRequestException.Errors : new List<string>()
                        },
                        Type = "https://tools.ietf.org/html/rfc7231#section-6.6.1"
                    };
                    await context.Response.WriteAsync(JsonSerializer.Serialize(errorResponse));
                });
            });
        }
    }
}
