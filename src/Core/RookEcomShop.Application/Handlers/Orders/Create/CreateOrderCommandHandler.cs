using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Exceptions;
using RookEcomShop.Application.Common.Interfaces.Services;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Application.Common.Services;
using RookEcomShop.Domain.Common.Enums;
using RookEcomShop.Domain.Entities;
using RookEcomShop.Persistence.Repositories;


namespace RookEcomShop.Application.Handlers.Orders.Create
{
    public class CreateOrderCommandHandler : BaseService, IRequestHandler<CreateOrderCommand, Result>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ICartRepository _cartRepository;

        public CreateOrderCommandHandler(
            IOrderRepository orderRepository,
            IUnitOfWork unitOfWork,
            IDateTimeProvider dateTimeProvider,
            ICartRepository cartRepository) : base(unitOfWork, dateTimeProvider)
        {
            _orderRepository = orderRepository;
            _cartRepository = cartRepository;
        }

        public async Task<Result> Handle(CreateOrderCommand command, CancellationToken cancellationToken)
        {
            Cart cart = await GetUserCart(command);

            var order = CreateNewOrder(cart);
            order.PaymentTransaction = CreatePaymentTransaction(command, order);
            _orderRepository.Create(order);

            ClearCart(cart);

            await _unitOfWork.SaveAsync(cancellationToken);

            return Result.Ok();
        }

        private PaymentTransaction CreatePaymentTransaction(CreateOrderCommand command, Order order)
        {
            return new PaymentTransaction
            {
                Id = Guid.NewGuid(),
                PaymentInfo = command.PaymentInfo,
                Status = PaymentTransactionStatus.Pending,
                TotalAmount = order.TotalAmount,
                TransactionDate = _dateTimeProvider.UtcNow,
            };
        }

        private async Task<Cart> GetUserCart(CreateOrderCommand command)
        {
            var cart = await _cartRepository
                                .GetCartByUserIdAsync(command.UserId)
                                .ThrowIfNullAsync("User's cart");


            if (cart.CartDetails.Count == 0)
            {
                throw new BadRequestException("Cart is empty");
            }

            return cart;
        }

        private void ClearCart(Cart cart)
        {
            cart.CartDetails.Clear();
            _cartRepository.Update(cart);
        }

        private Order CreateNewOrder(Cart cart)
        {
            var newOrder = new Order
            {
                OrderDetails = cart.CartDetails.Select(cD => new OrderDetail
                {
                    UnitPrice = cD.Product.Price,
                    Quantity = cD.Quantity,
                    Product = cD.Product,
                }).ToList(),
                Status = OrderStatus.Pending,
                UserId = cart.UserId,
                OrderDate = _dateTimeProvider.UtcNow
            };

            return newOrder;
        }
    }
}
