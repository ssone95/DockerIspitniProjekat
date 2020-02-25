using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Domain.DTO
{
    public class ProductFilterDTO
    {
        public int? ProductTypeId { get; set; }

        public SortingFields? SortingField { get; set; }

        public bool? DiscountOnly { get; set; }

        public string FilterString { get; set; }

        public int CurrentPage { get; set; } = 1;

        public int ItemsPerPage { get; set; } = 12;

    }

    public enum SortingFields : int
    {
        PriceAscending = 1,
        PriceDescending,
    }
}
