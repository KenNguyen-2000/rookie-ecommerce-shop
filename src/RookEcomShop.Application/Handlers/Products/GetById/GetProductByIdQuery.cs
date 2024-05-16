using FluentResults;
using MediatR;
using RookEcomShop.ViewModels.Product;

namespace RookEcomShop.Application.Handlers.Products.GetById
{
    public class GetProductByIdQuery : IRequest<Result<ProductVM>>

    {
        public int Id { get; set; }
    }
}
