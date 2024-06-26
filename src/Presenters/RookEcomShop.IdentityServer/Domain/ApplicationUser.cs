﻿using Microsoft.AspNetCore.Identity;
using RookEcomShop.Domain.Common.Enums;

namespace RookEcomShop.IdentityServer.Domain
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Address { get; set; }
        public DateTime? Dob { get; set; }
        public Gender Gender { get; set; } = Gender.Unisex;
        public string? AvartarUrl { get; set; }
    }
}
