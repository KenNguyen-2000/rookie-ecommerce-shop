using FluentResults;
using MediatR;
using RookEcomShop.ViewModels.Cart;

namespace RookEcomShop.Application.Handlers.Carts.AddProduct
{
    public class AddProductToCartCommand : AddProductToCartRequest, IRequest<Result>
    {
    }
}
