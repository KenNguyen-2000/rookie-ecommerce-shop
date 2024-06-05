using RookEcomShop.Domain.Entities;
using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.Application.Handlers.Users;

public static class UsersMapper
{
    public static UserDto MapToUserDto(User user)
    {
        return new UserDto
        {
            Id = user.Id,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Address = user.Address,
            Dob = user.Dob,
            AvartarUrl = user.AvartarUrl,
            PhoneNumber = user.PhoneNumber,
            Email = user.Email,
            Gender = user.Gender
        };
    }
}