using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Products
{
    public class ProductPhoto
    {
        [Key]
        public int? ProductId { get; set; }
        public Product Product { get; set; }

        [Key]
        public string PhotoPath { get; set; }

        public bool MainPhoto { get; set; } = true;
    }
}
