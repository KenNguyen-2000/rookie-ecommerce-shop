using FluentResults;
using MediatR;
using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.Application.Handlers.Products.GetById
{
    public class GetProductByIdQuery : IRequest<Result<ProductDto>>

    {
        public Guid Id { get; set; }
    }
}
