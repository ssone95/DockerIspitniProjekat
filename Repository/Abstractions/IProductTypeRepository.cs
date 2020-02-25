using Domain.Products;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Abstractions
{
    public interface IProductTypeRepository
    {
        Task<List<ProductType>> GetProductTypes(int? parentId = null, bool? mainTypes = null, string filterString = null);
        Task<ProductType> GetProductType(int parentId);
        Task<ProductType> Create(ProductType productType);
        Task<ProductType> Delete(int id);
    }
}
