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
    public class ProductTypeRepository : IProductTypeRepository
    {
        private ApplicationDbContext context;

        public ProductTypeRepository(ApplicationDbContext ctx) => context = ctx;

        public async Task<ProductType> Create(ProductType productType)
        {
            var fromDb = await context.ProductTypes.Include(x => x.ParentProductType)
                .Include(x => x.SubTypes)
                .Where(x => x.Id == productType.Id)
                .FirstOrDefaultAsync();

            if (fromDb != null)
            {
                fromDb.Name = productType.Name;
                fromDb.ParentProductTypeId = productType.ParentProductTypeId;
                fromDb.Description = productType.Description;

                fromDb.UpdatedAt = DateTime.Now;

                return fromDb;
            } else
            {
                productType.Id = 0;
                productType.Identifier = Guid.NewGuid();
                productType.Active = true;
                productType.CreatedAt = DateTime.Now;
                productType.UpdatedAt = DateTime.Now;

                await context.ProductTypes.AddAsync(productType);


                return productType;
            }
        }

        public async Task<ProductType> Delete(int id)
        {
            var fromDb = await context.ProductTypes.Include(x => x.ParentProductType)
                .Include(x => x.SubTypes)
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();

            if(fromDb != null)
            {
                fromDb.Active = true;
                fromDb.UpdatedAt = DateTime.Now;
            }

            return fromDb;
        }

        public async Task<ProductType> GetProductType(int typeId)
        {
            return await context.ProductTypes.Include(x => x.ParentProductType)
                .Include(x => x.SubTypes)
                .Where(x => x.Id == typeId)
                .FirstOrDefaultAsync();
        }

        public async Task<List<ProductType>> GetProductTypes(int? parentId = null, bool? mainTypes = null, string filterString = null)
        {
            return await context.ProductTypes.Include(x => x.ParentProductType)
                .Include(x => x.SubTypes)
                .Where(x => x.Active == true)
                .Where(x => parentId == null || x.ParentProductTypeId == parentId)
                .Where(x => mainTypes == null || mainTypes == false && x.ParentProductTypeId != null || mainTypes == true && x.ParentProductTypeId == null)
                .Where(x => String.IsNullOrEmpty(filterString) || x.Name.ToLower().Contains(filterString.ToLower())).ToListAsync();
        }
    }
}
