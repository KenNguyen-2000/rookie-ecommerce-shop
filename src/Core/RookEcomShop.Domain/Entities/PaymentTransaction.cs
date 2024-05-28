using RookEcomShop.Domain.Common;
using RookEcomShop.Domain.Common.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace RookEcomShop.Domain.Entities
{
    public class PaymentTransaction : BaseEntity<Guid>
    {
        public Guid OrderId { get; set; }
        public PaymentTransactionStatus Status { get; set; } = PaymentTransactionStatus.Pending;
        [Column(TypeName = "decimal(18, 2)")]
        public decimal TotalAmount { get; set; }
        public DateTime TransactionDate { get; set; }
        public string PaymentInfo { get; set; } = null!;

        public virtual Order Order { get; set; } = null!;
    }
}