using FluentResults;
using MediatR;
using RookEcomShop.Domain.Common.Enums;
using RookEcomShop.ViewModels.Order;

namespace RookEcomShop.Application.Handlers.GetById
{
    public class GetOrderByIdQuery : IRequest<Result<OrderVM>>
    {
        public int OrderId { get; set; }
    }
}