using System.Security.Claims;
using MediatR;
using Microsoft.AspNetCore.Identity;
using RookEcomShop.Application.Common.Exceptions;
using RookEcomShop.Application.Common.Helpers;
using RookEcomShop.Application.Handlers.Users.GetById;
using RookEcomShop.Domain.Entities;

namespace RookEcomShop.Api.Middlewares
{
    public class UserContextBuilderMiddleware
    {
        private readonly RequestDelegate _next;

        public UserContextBuilderMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, UserContext userContext, ISender sender)
        {

            try
            {
                if (context.User?.Identity?.IsAuthenticated == true)
                {
                    int userId = int.Parse(context.User.Claims.First(c => c.Type == ClaimTypes.NameIdentifier).Value);
                    var query = new GetUserByIdQuery { Id = userId };
                    var result = await sender.Send(query);
                    if (result.IsFailed)
                    {
                        throw new NotFoundException("Cannot find user with the provided id.");
                    }
                    var email = result.Value.Email;
                    userContext.SetContext(userId, email, 2);
                }

                await _next(context);
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}