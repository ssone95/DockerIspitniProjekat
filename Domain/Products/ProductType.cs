using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Products
{
    public class ProductType : BaseEntity
    {
        public string Name { get; set; }
        
        public string Description { get; set; }

        public int? ParentProductTypeId { get; set; }
        public ProductType ParentProductType { get; set; }

        public virtual List<ProductType> SubTypes { get; set; }

        public virtual List<Product_ProductType> Product_ProductTypes { get; set; }
    }
}
