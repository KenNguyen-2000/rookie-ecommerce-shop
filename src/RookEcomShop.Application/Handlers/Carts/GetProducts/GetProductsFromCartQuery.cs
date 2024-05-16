using FluentResults;
using MediatR;
using RookEcomShop.ViewModels.Cart;
using RookEcomShop.ViewModels.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookEcomShop.Application.Handlers.Carts.GetProducts
{
    public class GetProductsFromCartQuery : IRequest<Result<IEnumerable<CartDetailVM>>>
    {
    }
}
