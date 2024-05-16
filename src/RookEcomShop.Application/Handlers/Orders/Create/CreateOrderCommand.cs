using FluentResults;
using MediatR;
using RookEcomShop.ViewModels.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookEcomShop.Application.Handlers.Orders.Create
{
    public class CreateOrderCommand : CreateOrderRequest,IRequest<Result>
    {
    }
}
