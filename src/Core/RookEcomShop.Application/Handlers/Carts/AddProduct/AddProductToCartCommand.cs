using FluentResults;
using MediatR;
using RookEcomShop.ViewModels.Contracts.Cart;

namespace RookEcomShop.Application.Handlers.Carts.AddProduct
{
    public class AddProductToCartCommand : AddProductToCartRequest, IRequest<Result>
    {
    }
}
