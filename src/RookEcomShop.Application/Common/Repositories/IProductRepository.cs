﻿using RookEcomShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookEcomShop.Application.Common.Repositories
{
    public interface IProductRepository : IBaseRepository<Product>
    {
        void SoftDelete(Product entity);
    }
}
