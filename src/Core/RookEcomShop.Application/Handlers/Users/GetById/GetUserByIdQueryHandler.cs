using FluentResults;
using MediatR;

namespace RookEcomShop.Application.Handlers.Users.GetById
{
    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, Result>
    {


        public async Task<Result> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            return Result.Ok();
        }
    }
}