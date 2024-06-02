using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Data;
using RookEcomShop.Application.Common.Helpers;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Domain.Entities;
using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.Application.Handlers.Carts.GetProducts
{
    public class GetProductsFromCartQueryHandler : IRequestHandler<GetProductsFromCartQuery, Result<IEnumerable<CartDetailDto>>>
    {
        private readonly ICartRepository _cartRepository;
        private readonly IRookEcomShopDbContext _context;
        private readonly UserContext userContext;
        private readonly IUnitOfWork _unitOfWork;

        public GetProductsFromCartQueryHandler(
            ICartRepository cartRepository,
            UserContext userContext,
            IUnitOfWork unitOfWork,
            IRookEcomShopDbContext context)
        {
            _cartRepository = cartRepository;
            this.userContext = userContext;
            _unitOfWork = unitOfWork;
            _context = context;
        }

        public async Task<Result<IEnumerable<CartDetailDto>>> Handle(GetProductsFromCartQuery query, CancellationToken cancellationToken)
        {
            var cart = await _cartRepository.GetCartByUserIdAsync(query.UserId);
            var userId = userContext.UserId;
            if (cart is null)
            {
                cart = new Cart
                {
                    UserId = userId
                };
                _context.Carts.Add(cart);
                await _unitOfWork.SaveAsync(cancellationToken);
            }


            return Result.Ok(cart.CartDetails.Select(CartsMapper.MapToCartDetailDto));

        }
    }
}
