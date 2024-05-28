using RookEcomShop.Domain.Common.Enums;
using RookEcomShop.ViewModels.Reviews;

namespace RookEcomShop.ViewModels.Order
{
    public class OrderVM
    {
        public Guid Id { get; set; }
        public OrderStatus Status { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime OrderDate { get; set; }
        public UserVM User { get; set; } = null!;
        public IEnumerable<OrderDetailVM> OrderItems { get; set; } = new List<OrderDetailVM>();
    }
}
