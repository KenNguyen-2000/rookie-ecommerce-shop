using FluentResults;
using MediatR;
using RookEcomShop.ViewModels.Product;

namespace RookEcomShop.Application.Handlers.Products.GetById
{
    public class GetProductByIdQuery : IRequest<Result<ProductVM>>

    {
        public Guid Id { get; set; }
    }
}
