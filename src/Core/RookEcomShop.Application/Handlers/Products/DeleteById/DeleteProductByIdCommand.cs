using FluentResults;
using MediatR;

namespace RookEcomShop.Application.Handlers.Products.DeleteById
{
    public class DeleteProductByIdCommand : IRequest<Result>
    {
        public int Id { get; set; }
    }
}
