using RookEcomShop.Domain.Common.Enums;

namespace RookEcomShop.ViewModels.Dto
{
    public class OrderDto
    {
        public Guid Id { get; set; }
        public OrderStatus Status { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime OrderDate { get; set; }
        public UserDto User { get; set; } = null!;
        public IEnumerable<OrderDetailDto> OrderItems { get; set; } = new List<OrderDetailDto>();
    }
}
