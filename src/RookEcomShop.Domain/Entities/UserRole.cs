using RookEcomShop.Domain.Common;
using RookEcomShop.Domain.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookEcomShop.Domain.Entities
{
    public class UserRole : BaseEntity
    {

        public RoleType Name { get; set; } = RoleType.Buyer;

        public virtual ICollection<User> Users { get; set; } = new List<User>();
    }
}
