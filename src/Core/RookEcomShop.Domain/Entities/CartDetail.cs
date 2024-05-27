﻿using RookEcomShop.Domain.Common;

namespace RookEcomShop.Domain.Entities
{
    public class CartDetail : BaseEntity
    {
        public int Quantity { get; set; }

        public virtual Product Product { get; set; } = null!;
        public virtual Cart Cart { get; set; } = null!;
    }
}