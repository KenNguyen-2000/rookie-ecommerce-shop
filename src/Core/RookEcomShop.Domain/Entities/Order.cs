﻿using RookEcomShop.Domain.Common;
using RookEcomShop.Domain.Common.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace RookEcomShop.Domain.Entities
{
    public class Order : BaseEntity<Guid>
    {
        public OrderStatus Status { get; set; } = OrderStatus.Pending;
        [Column(TypeName = "decimal(18, 2)")]
        public decimal TotalAmount => OrderDetails.Sum(x => x.Quantity * x.UnitPrice);
        public DateTime OrderDate { get; set; }
        public Guid UserId { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual PaymentTransaction? PaymentTransaction { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }
}
