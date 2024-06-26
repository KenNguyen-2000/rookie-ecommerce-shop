﻿using FluentResults;
using MediatR;
using RookEcomShop.ViewModels.Contracts.Order;

namespace RookEcomShop.Application.Handlers.Orders.Create
{
    public class CreateOrderCommand : CreateOrderRequest, IRequest<Result>
    {
        public Guid UserId { get; set; }
    }
}
