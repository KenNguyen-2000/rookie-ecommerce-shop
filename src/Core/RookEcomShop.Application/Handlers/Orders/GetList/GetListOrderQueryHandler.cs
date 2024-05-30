using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Exceptions;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.ViewModels.Category;
using RookEcomShop.ViewModels.Order;
using RookEcomShop.ViewModels.Product;

namespace RookEcomShop.Application.Handlers.Orders.GetList
{
    public class GetListOrderQueryHandler : IRequestHandler<GetListOrderQuery, Result<IEnumerable<OrderVM>>>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IUserRepository _userRepository;

        public GetListOrderQueryHandler(IOrderRepository orderRepository, IUserRepository userRepository)
        {
            _orderRepository = orderRepository;
            _userRepository = userRepository;
        }

        public async Task<Result<IEnumerable<OrderVM>>> Handle(GetListOrderQuery request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(request.UserId);
            if (user == null)
            {
                throw new NotFoundException($"User with id {request.UserId} not found!");
            }
            var orders = await _orderRepository.GetListAsync(o => o.UserId == request.UserId, cancellationToken);

            return Result.Ok(orders.Select(o => new OrderVM
            {
                Id = o.Id,
                OrderDate = o.OrderDate,
                OrderItems = o.OrderDetails.Select(oD => new OrderDetailVM
                {
                    Id = oD.Id,
                    Quantity = oD.Quantity,
                    UnitPrice = oD.UnitPrice,
                    TotalPrice = oD.UnitPrice * oD.Quantity,
                    Product = new ProductVM
                    {
                        Id = oD.Product.Id,
                        Category = new CategoryVM
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
            }));
        }
    }
}