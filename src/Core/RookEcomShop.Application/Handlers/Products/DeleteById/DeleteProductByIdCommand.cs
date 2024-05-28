using FluentResults;
using MediatR;

namespace RookEcomShop.Application.Handlers.Products.DeleteById
{
    public class DeleteProductByIdCommand : IRequest<Result>
    {
        public Guid Id { get; set; }
    }
}
