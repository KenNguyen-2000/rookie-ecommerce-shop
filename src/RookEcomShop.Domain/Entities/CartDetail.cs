using RookEcomShop.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookEcomShop.Domain.Entities
{
    public class CartDetail : BaseEntity
    {
        public int Quantity { get; set; }

        public virtual Product Product { get; set; } = null!;
        public virtual Cart Cart { get; set; } = null!;
    }
}
