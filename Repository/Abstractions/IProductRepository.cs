using Domain.DTO;
using Domain.Products;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Abstractions
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProducts(ProductFilterDTO productFilter);
        Task<Product> GetProduct(int parentId);
        Task<Product> Create(Product product);
        Task<Product> Delete(int id);
    }
}
