using MediatR;
using RookEcomShop.ViewModels.Product;

namespace RookEcomShop.Application.Handlers.Products.GetById
{
    public record GetProductByIdQuery(int Id) : IRequest<ProductVM>;
}
