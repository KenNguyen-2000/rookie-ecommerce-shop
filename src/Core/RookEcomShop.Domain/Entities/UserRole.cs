using RookEcomShop.Domain.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookEcomShop.Domain.Entities
{
    public class UserRole : BaseEntity<Guid>
    {
        public Guid UserId { get; set; }

        public Guid RoleId { get; set; }

        public User User { get; set; } = null!;

        public Role Role { get; set; } = null!;
    }
}
