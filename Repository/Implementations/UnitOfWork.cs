using Microsoft.EntityFrameworkCore;
using Repository.Abstractions;
using Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        ApplicationDbContext context;

        public UnitOfWork()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
            builder.UseNpgsql(ApplicationDbContextFactory.ConnectionString);
            context = new ApplicationDbContext(builder.Options);
        }


        private IProductRepository productRepository;
        public IProductRepository GetProductRepository()
        {
            if (productRepository == null)
                productRepository = new ProductRepository(context);

            return productRepository;
        }

        private IProductTypeRepository productTypeRepository;
        public IProductTypeRepository GetProductTypeRepository()
        {
            if (productTypeRepository == null)
                productTypeRepository = new ProductTypeRepository(context);

            return productTypeRepository;
        }

        public async Task Save()
        {
            await context.SaveChangesAsync();
        }
    }
}
