using RookEcomShop.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookEcomShop.Domain.Entities
{
    public class Role : BaseEntity<Guid>
    {
        public string Name { get; set; } = null!;

        public string NormalizedName => Name.ToUpper();

        public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
    }
}
