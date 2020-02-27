using Domain.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DTO
{
    public class ShoppingCartItemDTO
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public decimal TotalItemPrice => Product.CalculatedPrice * Quantity;
    }
}
