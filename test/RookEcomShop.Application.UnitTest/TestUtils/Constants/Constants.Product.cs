using RookEcomShop.Domain.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookEcomShop.Application.UnitTest.TestUtils.Constants
{
    public static partial class Constants
    {
        public static class Product
        {
            public static readonly Guid Id = Guid.NewGuid();
            public const string Name = "Test Product";
            public const decimal Price = 10.0m;
            public const int StockQuantity = 10;
            public const ProductStatus Status = ProductStatus.Active;

            public const string Description = "Test Product Description";

        }
    }
}
