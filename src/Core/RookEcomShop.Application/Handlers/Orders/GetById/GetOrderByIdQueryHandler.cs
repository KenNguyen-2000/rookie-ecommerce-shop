using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Exceptions;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.Application.Handlers.Orders.GetById
{
    public class GetOrderByIdQueryHandler : IRequestHandler<GetOrderByIdQuery, Result<OrderDto>>
    {
        private readonly IOrderRepository _orderRepository;

        public GetOrderByIdQueryHandler(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<Result<OrderDto>> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
        {
            var order = await _orderRepository.GetByIdAsync(request.OrderId, cancellationToken);

            if (order == null)
                throw new NotFoundException("Order not found");

            return Result.Ok(new OrderDto
            {
                Id = order.Id,
                OrderDate = order.OrderDate,
                OrderItems = order.OrderDetails.Select(oD => new OrderDetailDto
                {
                    Id = oD.Id,
                    Quantity = oD.Quantity,
                    UnitPrice = oD.UnitPrice,
                    TotalPrice = oD.UnitPrice * oD.Quantity,
                    Product = new ProductDto
                    {
                        Id = oD.Product.Id,
                        Status = oD.Product.Status,
                        Category = new CategoryDto
                        {
                            Id = oD.Product.Category.Id,
                            Name = oD.Product.Category.Name,
                            Description = oD.Product.Category.Description,
                            ParentId = oD.Product.Category.CategoryId
                        },
                        Description = oD.Product.Description,
                        ImgUrls = oD.Product.ProductImages.Select(pD => pD.Url),
                        Name = oD.Product.Name,
                        Price = oD.Product.Price
                    }

                })
            });
        }
    }
}