using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Domain.Entities;
using RookEcomShop.ViewModels.Dto;
using System.Linq.Expressions;
using RookEcomShop.Application.Common.Helpers;
using RookEcomShop.Application.Common.Services;
using RookEcomShop.Domain.Common.Enums;

namespace RookEcomShop.Application.Handlers.Products.GetByCategoryName
{
    public class GetProductsByCategoryNameQueryHandler : BaseService, IRequestHandler<GetProductsByCategoryNameQuery, Result<PaginatedList<ProductDto>>>
    {
        private readonly IProductRepository _productRepository;

        public GetProductsByCategoryNameQueryHandler(IProductRepository productRepository, UserContext userContext): base(userContext) 
        {
            _productRepository = productRepository;
        }

        public async Task<Result<PaginatedList<ProductDto>>> Handle(GetProductsByCategoryNameQuery query, CancellationToken cancellationToken)
        {
            Expression<Func<Product, bool>>? filter =
                _userContext.IsAdmin() ? null : (p => p.Status == ProductStatus.Active);
            var paginatedProducts = await _productRepository.GetListAsync(filter, query.QueryObject, cancellationToken);

            PaginatedList<ProductDto> productVMs = ProductsMapper.MapToPaginatedProductVM(paginatedProducts);

            return Result.Ok(productVMs);
        }


    }
}
