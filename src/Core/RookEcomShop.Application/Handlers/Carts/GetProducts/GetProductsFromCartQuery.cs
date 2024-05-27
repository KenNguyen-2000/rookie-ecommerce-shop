using FluentResults;
using MediatR;
using RookEcomShop.ViewModels.Cart;

namespace RookEcomShop.Application.Handlers.Carts.GetProducts
{
    public class GetProductsFromCartQuery : IRequest<Result<IEnumerable<CartDetailVM>>>
    {
        public int UserId { get; set; }
    }
}
