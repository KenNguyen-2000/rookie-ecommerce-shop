using FluentResults;
using MediatR;
using RookEcomShop.Domain.Common.Enums;

namespace RookEcomShop.Application.Handlers.Products.PatchStatus
{
    public class UpdateProductStatusCommand : IRequest<Result>
    {
        public Guid Id { get; set; }
        public ProductStatus Status { get; set; }
    }
}
