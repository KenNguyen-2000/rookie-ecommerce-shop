using RookEcomShop.Domain.Common.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace RookEcomShop.ViewModels.Dto
{
    public class PaymentTransactionDto
    {
        public PaymentTransactionStatus Status { get; set; } = PaymentTransactionStatus.Pending;
        [Column(TypeName = "decimal(18, 2)")]
        public decimal TotalAmount { get; set; }
        public DateTime TransactionDate { get; set; }
        public PaymentInfoContent PaymentInfo { get; set; } = null!;

    }
}
