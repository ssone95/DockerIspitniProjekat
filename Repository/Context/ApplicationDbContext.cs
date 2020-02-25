using Domain.Products;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Repository.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product_ProductType>().HasKey("ProductId", "ProductTypeId");


            modelBuilder.Entity<ProductType>().HasData(
                    new ProductType() { Id = 1, Identifier = Guid.NewGuid(), Name = "Vrsta 1", Description = "Opis vrste 1", Active = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                    new ProductType() { Id = 2, Identifier = Guid.NewGuid(), Name = "Vrsta 2", Description = "Opis vrste 2", Active = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                    new ProductType() { Id = 3, Identifier = Guid.NewGuid(), Name = "Vrsta 3", Description = "Opis vrste 3", Active = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                    new ProductType() { Id = 4, Identifier = Guid.NewGuid(), Name = "Vrsta 4", Description = "Opis vrste 4", Active = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                    new ProductType() { Id = 5, Identifier = Guid.NewGuid(), Name = "Vrsta 5", Description = "Opis vrste 5", Active = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                    new ProductType() { Id = 6, ParentProductTypeId = 1, Identifier = Guid.NewGuid(), Name = "Pod Vrsta 1", Description = "Opis Pod vrste 1", Active = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                    new ProductType() { Id = 7, ParentProductTypeId = 1, Identifier = Guid.NewGuid(), Name = "Pod Vrsta 2", Description = "Opis Pod vrste 2", Active = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                    new ProductType() { Id = 8, ParentProductTypeId = 2, Identifier = Guid.NewGuid(), Name = "Pod Vrsta 3", Description = "Opis Pod vrste 3", Active = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                    new ProductType() { Id = 9, ParentProductTypeId = 2, Identifier = Guid.NewGuid(), Name = "Pod Vrsta 4", Description = "Opis Pod vrste 4", Active = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                    new ProductType() { Id = 10, ParentProductTypeId = 3, Identifier = Guid.NewGuid(), Name = "Pod Vrsta 5", Description = "Opis Pod vrste 5", Active = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product() { 
                    Id = 1, 
                    Identifier = Guid.NewGuid(),
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "Artikal 1",
                    Description = "Opis 1",
                    Discount = 0,
                    Price = 100,
                    Tags = "Artikal;test;Nesto;Nesto 2;Proba;"
                },
                new Product()
                {
                    Id = 2,
                    Identifier = Guid.NewGuid(),
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "Artikal 2",
                    Description = "Opis 2",
                    Discount = 1,
                    Price = 100,
                    Tags = "Artikal;test;Nesto;Nesto 2;Proba;"
                },
                new Product()
                {
                    Id = 3,
                    Identifier = Guid.NewGuid(),
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "Artikal 2",
                    Description = "Opis 2",
                    Discount = 1,
                    Price = 100,
                    Tags = "Artikal;test;Nesto;Nesto 2;Proba;"
                }
            );

            modelBuilder.Entity<Product_ProductType>().HasData(
                new Product_ProductType() { ProductId = 1, ProductTypeId = 10 },
                new Product_ProductType() { ProductId = 1, ProductTypeId = 6 },
                new Product_ProductType() { ProductId = 1, ProductTypeId = 7 },
                new Product_ProductType() { ProductId = 2, ProductTypeId = 8 },
                new Product_ProductType() { ProductId = 2, ProductTypeId = 9 },
                new Product_ProductType() { ProductId = 3, ProductTypeId = 9 },
                new Product_ProductType() { ProductId = 3, ProductTypeId = 2 },
                new Product_ProductType() { ProductId = 3, ProductTypeId = 10 }
            );
        }
    }
}
