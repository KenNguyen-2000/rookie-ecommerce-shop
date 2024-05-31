using FluentResults;
using MediatR;
using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.Application.Handlers.Carts.GetProducts
{
    public class GetProductsFromCartQuery : IRequest<Result<IEnumerable<CartDetailDto>>>
    {
        public Guid UserId { get; set; }
    }
}
