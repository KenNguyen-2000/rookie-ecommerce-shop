using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Data;
using RookEcomShop.Application.Common.Helpers;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Domain.Entities;
using RookEcomShop.ViewModels.Cart;
using RookEcomShop.ViewModels.Category;
using RookEcomShop.ViewModels.Product;

namespace RookEcomShop.Application.Handlers.Carts.GetProducts
{
    public class GetProductsFromCartQueryHandler : IRequestHandler<GetProductsFromCartQuery, Result<IEnumerable<CartDetailVM>>>
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

        public async Task<Result<IEnumerable<CartDetailVM>>> Handle(GetProductsFromCartQuery query, CancellationToken cancellationToken)
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


            return Result.Ok(MapCartDetailsVM(cart));

        }

        private static IEnumerable<CartDetailVM> MapCartDetailsVM(Cart cart)
        {
            return cart.CartDetails.Select(x => new CartDetailVM
            {
                Id = x.Id,
                Quantity = x.Quantity,
                Product = new ProductVM
                {
                    Id = x.Product.Id,
                    Description = x.Product.Description,
                    Name = x.Product.Name,
                    Price = x.Product.Price,
                    Status = x.Product.Status,
                    Category = new CategoryVM
                    {
                        Id = x.Product.Category.Id,
                        Name = x.Product.Category.Name,
                        Description = x.Product.Category.Description
                    },
                    ImgUrls = x.Product.ProductImages.Select(pI => pI.Url)
                }
            });
        }
    }
}
