using RookEcomShop.Application.Handlers.Users;
using RookEcomShop.Domain.Entities;
using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.Application.Handlers.Orders;

public static class OrdersMapper
{
    public static OrderDto MapToOrderDto(Order order)
    {
        return new OrderDto
        {
            Id = order.Id,
            Status = order.Status,
            OrderDate = order.OrderDate,
            User = UsersMapper.MapToUserDto(order.User),
            OrderItems = order.OrderDetails.Select(MapToOrderDetailDto)
        };
    }

    public static OrderDetailDto MapToOrderDetailDto(OrderDetail orderDetail)
    {
        return new OrderDetailDto
        {
            Id = orderDetail.Id,
            Quantity = orderDetail.Quantity,
            UnitPrice = orderDetail.UnitPrice,
            Product = new ProductDto
            {
                Id = orderDetail.Product.Id,
                Category = new CategoryDto
                {
                    Id = orderDetail.Product.Category.Id,
                    Name = orderDetail.Product.Category.Name,
                    Description = orderDetail.Product.Category.Description,
                    ParentId = orderDetail.Product.Category.CategoryId
                },
                Description = orderDetail.Product.Description,
                ImgUrls = orderDetail.Product.ProductImages.Select(pD => pD.Url),
                Name = orderDetail.Product.Name,
                Price = orderDetail.Product.Price
            }
        };
    }
}