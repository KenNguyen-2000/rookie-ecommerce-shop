using FluentResults;
using MediatR;
using RookEcomShop.Application.Common.Exceptions;
using RookEcomShop.Application.Common.Repositories;
using RookEcomShop.Domain.Entities;
using RookEcomShop.ViewModels.Cart;
using RookEcomShop.ViewModels.Category;
using RookEcomShop.ViewModels.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookEcomShop.Application.Handlers.Carts.GetProducts
{
    public class GetProductsFromCartQueryHandler : IRequestHandler<GetProductsFromCartQuery, Result<IEnumerable<CartDetailVM>>>
    {
        private readonly ICartRepository _cartRepository;

        public GetProductsFromCartQueryHandler(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        public async Task<Result<IEnumerable<CartDetailVM>>> Handle(GetProductsFromCartQuery query, CancellationToken cancellationToken)
        {
            var cart = await _cartRepository.GetCartByUserIdAsync(2);

            if (cart is null)
            {
                throw new NotFoundException("Cart not found!");
            }


            return Result.Ok(MapCartDetailsVM(cart));

        }

        private static IEnumerable<CartDetailVM> MapCartDetailsVM(Cart cart)
        {
            return cart.CartDetails.Select(x => new CartDetailVM
            {
                Id = x.Product.Id,
                Description = x.Product.Description,
                Name = x.Product.Name,
                Price = x.Product.Price,
                Quantity = x.Quantity,
                Category = new CategoryVM
                {
                    Id = x.Product.Category.Id,
                    Name = x.Product.Category.Name,
                    Description = x.Product.Category.Description
                },
                ImgUrls = x.Product.ProductImages.Select(pI => pI.Url)
            });
        }
    }
}
