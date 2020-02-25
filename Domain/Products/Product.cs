using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Products
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public int Discount { get; set; }

        [NotMapped]
        public decimal DiscountAmount 
        { 
            get
            {
                return Math.Round((Price * ((Discount * 1.0m) / 100.0m)), 2);
            } 
        }

        [NotMapped]
        public decimal CalculatedPrice { 
            get
            {
                return Math.Round(Price - DiscountAmount, 2);
            }
        }

        public string Tags { get; set; }
        
        public virtual List<Product_ProductType> Product_ProductTypes { get; set; }

    }
}
