using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Data;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Domain.Entities;
using RookEcomShop.ViewModels.Category;
using RookEcomShop.ViewModels.Dto;
using RookEcomShop.ViewModels.Product;
using System.Linq.Expressions;

namespace RookEcomShop.Application.Handlers.Products.GetList
{
    public class GetListProductQueryHandler : IRequestHandler<GetListProductQuery, Result<PaginatedList<ProductVM>>>
    {
        private readonly IProductRepository _productRepository;

        public GetListProductQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Result<PaginatedList<ProductVM>>> Handle(GetListProductQuery query, CancellationToken cancellationToken)
        {
            var products = await _productRepository.GetListAsync(filter: null, query.QueryObject, cancellationToken);

            PaginatedList<ProductVM> productVMs = ProductsMapper.MapToPaginatedProductVM(products);

            return Result.Ok(productVMs);
        }
    }
}
