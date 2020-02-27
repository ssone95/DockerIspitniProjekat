using Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.DTO
{
    public class ShoppingCartDTO
    {
        public List<ShoppingCartItemDTO> ShoppingCartItems { get; set; } = new List<ShoppingCartItemDTO>();

        public decimal DiscountValue { get; set; } = 0;

        public decimal ShippingValue { get; set; } = 0;

        public ShoppingCartDTO()
        {
            if (ShoppingCartItems == null)
                ShoppingCartItems = new List<ShoppingCartItemDTO>();
        }

        public void InsertIntoCart(Product product, int quantity)
        {
            RemoveFromCart(product);

            ShoppingCartItems.Add(new ShoppingCartItemDTO()
            {
                Product = product,
                Quantity = quantity
            });
        }

        public void RemoveFromCart(Product product)
        {
            var productInItem = ShoppingCartItems.Where(x => x.Product.Equals(product)).FirstOrDefault();
            if (productInItem != null)
            {
                ShoppingCartItems.Remove(productInItem);
            }
        }

        public decimal TotalValue => ShoppingCartItems.Sum(x => x.Quantity * x.Product.CalculatedPrice) + ShippingValue - DiscountValue;
    }
}
