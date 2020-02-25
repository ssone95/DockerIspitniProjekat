using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DTO
{
    public class ProductTypeFilterDTO
    {
        public bool? MainTypes { get; set; }
        public int? ParentTypeId { get; set; }
        public string FilterString { get; set; }
    }
}
