using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Interfaces.Services;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Domain.Common.Enums;
using RookEcomShop.Domain.Entities;


namespace RookEcomShop.Application.Handlers.Orders.Create
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, Result>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IProductRepository _productRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly IDateTimeProvider _dateTimeProvider;

        public CreateOrderCommandHandler(IOrderRepository orderRepository, IUnitOfWork unitOfWork, IDateTimeProvider dateTimeProvider, IProductRepository productRepository)
        {
            _orderRepository = orderRepository;
            _unitOfWork = unitOfWork;
            _dateTimeProvider = dateTimeProvider;
            _productRepository = productRepository;
        }

        public async Task<Result> Handle(CreateOrderCommand command, CancellationToken cancellationToken)
        {
            CreateNewOrder(command);

            await _unitOfWork.SaveAsync(cancellationToken);

            return Result.Ok();
        }

        private async void CreateNewOrder(CreateOrderCommand command)
        {
            var producttIds = command.CartDetails.Select(cD => cD.Product.Id);
            var products = await _productRepository.GetListAsync(p => producttIds.Contains(p.Id));

            var newOrder = new Order
            {
                OrderDetails = command.CartDetails.Select(cD => new OrderDetail
                {
                    UnitPrice = cD.Price,
                    Quantity = cD.Quantity,
                    Product = products.FirstOrDefault(p => p.Id.Equals(cD.Product.Id))!,
                }).ToList(),
                Status = OrderStatus.Pending,
                UserId = 2,
                TotalAmount = command.CartDetails.Sum(cD => cD.Price * cD.Quantity),
                OrderDate = _dateTimeProvider.UtcNow,
                UpdatedAt = _dateTimeProvider.UtcNow
            };

            _orderRepository.Create(newOrder);
        }
    }
}
