using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RookEcomShop.Application.Common.Helpers;
using RookEcomShop.Application.Common.Services;
using RookEcomShop.Domain.Common.Enums;
using RookEcomShop.Domain.Entities;
using RookEcomShop.ViewModels.Dto;

namespace RookEcomShop.Application.Handlers.Products
{
    public static class ProductsHandlerExtensions
    {
        public static IEnumerable<Product> FilterProductsIfNotAdmin(IEnumerable<Product> items, UserContext userContext)
        {
            var isAdmin = !String.IsNullOrWhiteSpace(userContext.UserRole) && userContext.UserRole == "Admin";
            var isLoggedIn = userContext.UserId != null;
            if (!isLoggedIn || !isAdmin)
            {
                return items.Where(i => i.Status == ProductStatus.Active);
            }

            return items;
        }
    }
}
