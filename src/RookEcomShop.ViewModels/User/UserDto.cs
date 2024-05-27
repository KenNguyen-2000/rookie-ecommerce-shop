using RookEcomShop.Domain.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookEcomShop.ViewModels.User
{
    public class UserDto
    {
        public string Firstname { get; set; } = null!;
        public string Lastname { get; set; } = null!;
        public string? Address { get; set; }
        public DateTime? Dob { get; set; }
        public Gender Gender { get; set; } = Gender.Unisex;
        public string? AvartarUrl { get; set; }
    }
}
