using Domain.DTO;
using Domain.Products;
using Microsoft.EntityFrameworkCore;
using Repository.Abstractions;
using Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementations
{
    public class ProductRepository : IProductRepository
    {
        private ApplicationDbContext context;

        public ProductRepository(ApplicationDbContext ctx) => context = ctx;

        public async Task<Product> Create(Product product)
        {
            if(product.Id > 0)
            {
                var fromDb = await context.Products.Include(x => x.Product_ProductTypes).Where(x => x.Id == product.Id).FirstOrDefaultAsync();
                if(fromDb != null)
                {
                    fromDb.Name = product.Name;
                    fromDb.Description = product.Description;
                    fromDb.Discount = product.Discount;
                    fromDb.Price = product.Price;
                    fromDb.Tags = product.Tags;

                    if(fromDb.Product_ProductTypes == null)
                    {
                        fromDb.Product_ProductTypes = new List<Product_ProductType>();
                    }

                    var types = product.Product_ProductTypes ?? new List<Product_ProductType>();

                    var existingTypes = fromDb.Product_ProductTypes ?? new List<Product_ProductType>();

                    foreach (var item in existingTypes)
                        fromDb.Product_ProductTypes.Remove(item);

                    foreach (var item in types)
                        fromDb.Product_ProductTypes.Add(item);
                    
                    fromDb.UpdatedAt = DateTime.Now;
                }
                return fromDb;
            } else
            {
                product.Id = 0;
                product.Identifier = Guid.NewGuid();

                product.Active = true;
                product.CreatedAt = DateTime.Now;
                product.UpdatedAt = DateTime.Now;
                
                await context.Products.AddAsync(product);
                return product;
            }
        }

        public async Task<Product> Delete(int id)
        {
            var fromDb = await context.Products.Include(x => x.Product_ProductTypes).Where(x => x.Id == id).FirstOrDefaultAsync();
            if (fromDb != null)
            {
                fromDb.Active = false;
                fromDb.UpdatedAt = DateTime.Now;
            }
            return fromDb;
        }

        public async Task<Product> GetProduct(int parentId)
        {
            return await context.Products
                .Include(x => x.ProductPhotos)
                .Include(x => x.Product_ProductTypes)
                .ThenInclude(x => x.ProductType)
                .Where(x => x.Id == parentId).FirstOrDefaultAsync();
        }

        public async Task<List<Product>> GetProducts(ProductFilterDTO productFilter)
        {
            int currentPage = productFilter?.CurrentPage ?? 1;
            int itemsPerPage = productFilter?.ItemsPerPage ?? 12;

            string filterString = productFilter?.FilterString?.ToLower();

            bool discountOnly = productFilter?.DiscountOnly ?? false;

            var queryable = context.Products
                .Include(x => x.ProductPhotos)
                .Include(x => x.Product_ProductTypes)
                .ThenInclude(x => x.ProductType)
                .Where(x => productFilter.ProductTypeId == null
                    || x.Product_ProductTypes.Any(y => y.ProductTypeId == productFilter.ProductTypeId || y.ProductType.ParentProductTypeId == productFilter.ProductTypeId))
                .Where(x => discountOnly == false || discountOnly == true && x.Discount > 0)
                .Where(x => String.IsNullOrEmpty(filterString) || x.Name.ToLower().Contains(filterString));

            switch(productFilter.SortingField)
            {
                case SortingFields.PriceAscending:
                    {
                        queryable = queryable.OrderBy(x => x.Price);
                        break;
                    }
                case SortingFields.PriceDescending:
                    {
                        queryable = queryable.OrderByDescending(x => x.Price);
                        break;
                    }

                case null:
                    {
                        break;
                    }
            }



            return await queryable
                .Skip((currentPage - 1) * itemsPerPage)
                .Take(itemsPerPage)
                .ToListAsync();
        }
    }
}
