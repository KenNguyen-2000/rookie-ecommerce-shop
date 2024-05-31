using FluentResults;
using MediatR;
using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.Application.Handlers.Orders.GetById
{
    public class GetOrderByIdQuery : IRequest<Result<OrderDto>>
    {
        public Guid OrderId { get; set; }
    }
}