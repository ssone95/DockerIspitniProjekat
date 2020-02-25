using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Products
{
    public class Product_ProductType
    {
        [Key]
        public int? ProductId { get; set; }
        public Product Product { get; set; }

        [Key]
        public int? ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }
    }
}
