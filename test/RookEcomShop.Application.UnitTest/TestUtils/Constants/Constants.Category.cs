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
        public static class Category
        {
            public static readonly Guid Id = Guid.NewGuid();
            public const string Name = "Test Category Name";

            public const string Description = "Test Category Description";

        }
    }
}
