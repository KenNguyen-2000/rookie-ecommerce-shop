using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Exceptions;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.ViewModels.Category;
using RookEcomShop.ViewModels.Order;
using RookEcomShop.ViewModels.Product;

namespace RookEcomShop.Application.Handlers.Orders.GetById
{
    public class GetOrderByIdQueryHandler : IRequestHandler<GetOrderByIdQuery, Result<OrderVM>>
    {
        private readonly IOrderRepository _orderRepository;

        public GetOrderByIdQueryHandler(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<Result<OrderVM>> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
        {
            var order = await _orderRepository.GetByIdAsync(request.OrderId, cancellationToken);

            if (order == null)
                throw new NotFoundException("Order not found");

            return Result.Ok(new OrderVM
            {
                Id = order.Id,
                OrderDate = order.OrderDate,
                OrderItems = order.OrderDetails.Select(oD => new OrderDetailVM
                {
                    Id = oD.Id,
                    Quantity = oD.Quantity,
                    UnitPrice = oD.UnitPrice,
                    TotalPrice = oD.UnitPrice * oD.Quantity,
                    Product = new ProductVM
                    {
                        Id = oD.Product.Id,
                        Status = oD.Product.Status,
                        Category = new CategoryVM
                        {
                            Id = oD.Product.Category.Id,
                            Name = oD.Product.Category.Name
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