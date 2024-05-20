using FluentResults;
using MediatR;
using Microsoft.AspNetCore.Identity;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Domain.Entities;

namespace RookEcomShop.Application.Handlers.Users.GetById
{
    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, Result<User>>
    {
        private readonly IUserRepository _userRepository;

        public GetUserByIdQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Result<User>> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetUserByIdAsync(request.Id);

            if (user is null)
            {
                return Result.Fail<User>($"User with id {request.Id} not found.");
            }

            return Result.Ok(user);
        }
    }
}