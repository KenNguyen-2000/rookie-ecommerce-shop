using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Exceptions;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Domain.Entities;
using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.Application.Handlers.Orders.GetList
{
    public class GetListOrderQueryHandler : IRequestHandler<GetListOrderQuery, Result<PaginatedList<OrderDto>>>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IUserRepository _userRepository;

        public GetListOrderQueryHandler(IOrderRepository orderRepository, IUserRepository userRepository)
        {
            _orderRepository = orderRepository;
            _userRepository = userRepository;
        }

        public async Task<Result<PaginatedList<OrderDto>>> Handle(GetListOrderQuery request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(request.UserId);
            if (user == null)
            {
                throw new NotFoundException($"User with id {request.UserId} not found!");
            }
            var orders = await _orderRepository.GetListAsync(o => o.UserId == request.UserId, request.QueryObject, cancellationToken);
            var orderVMs = MapOrderVMs(orders.Items);

            return Result.Ok(PaginatedList<OrderDto>.Create(
                orderVMs,
                orders.TotalCount,
                orders.Page,
                orders.PageSize));
        }

        private static IEnumerable<OrderDto> MapOrderVMs(IEnumerable<Order> orders)
        {
            return orders.Select(o => new OrderDto
            {
                Id = o.Id,
                OrderDate = o.OrderDate,
                OrderItems = o.OrderDetails.Select(oD => new OrderDetailDto
                {
                    Id = oD.Id,
                    Quantity = oD.Quantity,
                    UnitPrice = oD.UnitPrice,
                    TotalPrice = oD.UnitPrice * oD.Quantity,
                    Product = new ProductDto
                    {
                        Id = oD.Product.Id,
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