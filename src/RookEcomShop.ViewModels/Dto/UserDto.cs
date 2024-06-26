﻿using RookEcomShop.Domain.Common.Enums;

namespace RookEcomShop.ViewModels.Dto
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public DateTime? Dob { get; set; }
        public Gender Gender { get; set; } = Gender.Unisex;
        public string? AvartarUrl { get; set; }
    }
}
