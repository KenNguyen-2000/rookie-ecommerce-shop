using RookEcomShop.Domain.Common.Enums;
using RookEcomShop.Domain.Entities;

namespace RookEcomShop.ViewModels.Dto
{
    public class OrderDto
    {
        public Guid Id { get; set; }
        public OrderStatus Status { get; set; }
        public decimal TotalAmount => OrderItems.Sum(x => x.TotalPrice);
        public DateTime OrderDate { get; set; }
        public UserDto User { get; set; } = null!;
        public IEnumerable<OrderDetailDto> OrderItems { get; set; } = new List<OrderDetailDto>();
        public PaymentTransactionDto? PaymentTransaction { get; set; }
    }
}
