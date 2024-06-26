using MediatR;
using RookEcomShop.Application.Common.Helpers;
using System.Security.Claims;

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
                    Guid userId = Guid.Parse(context.User.Claims.First(c => c.Type == ClaimTypes.NameIdentifier).Value);
                    string role = context.User.Claims.First(c => c.Type == ClaimTypes.Role).Value;
                    //var query = new GetUserByIdQuery { Id = userId };
                    //var result = await sender.Send(query);
                    //if (result.IsFailed)
                    //{
                    //    throw new NotFoundException("Cannot find user with the provided id.");
                    //}
                    userContext.SetContext(userId, role);
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