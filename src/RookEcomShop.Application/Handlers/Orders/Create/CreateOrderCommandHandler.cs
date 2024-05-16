using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Interfaces.Services;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Domain.Common.Enums;
using RookEcomShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookEcomShop.Application.Handlers.Orders.Create
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, Result>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IOrderRepository _orderRepository;
        private readonly IDateTimeProvider _dateTimeProvider;

        public CreateOrderCommandHandler(IOrderRepository orderRepository, IUnitOfWork unitOfWork, IDateTimeProvider dateTimeProvider)
        {
            _orderRepository = orderRepository;
            _unitOfWork = unitOfWork;
            _dateTimeProvider = dateTimeProvider;
        }

        public async Task<Result> Handle(CreateOrderCommand command, CancellationToken cancellationToken)
        {
            CreateNewOrder(command);

            await _unitOfWork.SaveAsync(cancellationToken);

            return Result.Ok();
        }

        private void CreateNewOrder(CreateOrderCommand command)
        {
            var newOrder = new Order
            {
                OrderDetails = command.CartDetails.Select(cD => new OrderDetail
                {
                    UnitPrice = cD.Price,
                    Quantity = cD.Quantity,
                    Product = new Product
                    {
                        Id = cD.ProductId,
                    }
                }).ToList(),
                Status = OrderStatus.Pending,
                TotalAmount = command.CartDetails.Sum(cD => cD.Price * cD.Quantity),
                OrderDate = _dateTimeProvider.UtcNow,
                UpdatedAt = _dateTimeProvider.UtcNow
            };

            _orderRepository.Create(newOrder);
        }
    }
}
