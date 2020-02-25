﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Repository.Context;

namespace Repository.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200223083733_Product_Modification")]
    partial class Product_Modification
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Domain.Products.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("Discount")
                        .HasColumnType("integer");

                    b.Property<Guid>("Identifier")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<string>("Tags")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Active = true,
                            CreatedAt = new DateTime(2020, 2, 23, 9, 37, 32, 715, DateTimeKind.Local).AddTicks(1284),
                            Description = "Opis 1",
                            Discount = 0,
                            Identifier = new Guid("bcccf35a-99d6-4ce2-b707-59c1bb922795"),
                            Name = "Artikal 1",
                            Price = 100m,
                            UpdatedAt = new DateTime(2020, 2, 23, 9, 37, 32, 715, DateTimeKind.Local).AddTicks(1287)
                        },
                        new
                        {
                            Id = 2,
                            Active = true,
                            CreatedAt = new DateTime(2020, 2, 23, 9, 37, 32, 715, DateTimeKind.Local).AddTicks(3290),
                            Description = "Opis 2",
                            Discount = 1,
                            Identifier = new Guid("d1b5d1c8-fca6-4cb4-b194-edfb55a2eb76"),
                            Name = "Artikal 2",
                            Price = 100m,
                            UpdatedAt = new DateTime(2020, 2, 23, 9, 37, 32, 715, DateTimeKind.Local).AddTicks(3293)
                        },
                        new
                        {
                            Id = 3,
                            Active = true,
                            CreatedAt = new DateTime(2020, 2, 23, 9, 37, 32, 715, DateTimeKind.Local).AddTicks(3346),
                            Description = "Opis 2",
                            Discount = 1,
                            Identifier = new Guid("e8d28099-832a-4e53-92e4-959267c6d9cf"),
                            Name = "Artikal 2",
                            Price = 100m,
                            UpdatedAt = new DateTime(2020, 2, 23, 9, 37, 32, 715, DateTimeKind.Local).AddTicks(3350)
                        });
                });

            modelBuilder.Entity("Domain.Products.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<Guid>("Identifier")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int?>("ParentProductTypeId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("ParentProductTypeId");

                    b.ToTable("ProductTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Active = true,
                            CreatedAt = new DateTime(2020, 2, 23, 9, 37, 32, 713, DateTimeKind.Local).AddTicks(5300),
                            Description = "Opis vrste 1",
                            Identifier = new Guid("b15e852d-03cb-498d-bad0-004f70b0d8f9"),
                            Name = "Vrsta 1",
                            UpdatedAt = new DateTime(2020, 2, 23, 9, 37, 32, 713, DateTimeKind.Local).AddTicks(5873)
                        },
                        new
                        {
                            Id = 2,
                            Active = true,
                            CreatedAt = new DateTime(2020, 2, 23, 9, 37, 32, 713, DateTimeKind.Local).AddTicks(6512),
                            Description = "Opis vrste 2",
                            Identifier = new Guid("53520aa9-214f-442f-9064-b61edc041ccf"),
                            Name = "Vrsta 2",
                            UpdatedAt = new DateTime(2020, 2, 23, 9, 37, 32, 713, DateTimeKind.Local).AddTicks(6536)
                        },
                        new
                        {
                            Id = 3,
                            Active = true,
                            CreatedAt = new DateTime(2020, 2, 23, 9, 37, 32, 713, DateTimeKind.Local).AddTicks(6558),
                            Description = "Opis vrste 3",
                            Identifier = new Guid("b08f1c66-f17f-46a6-aa00-ae8832bc1685"),
                            Name = "Vrsta 3",
                            UpdatedAt = new DateTime(2020, 2, 23, 9, 37, 32, 713, DateTimeKind.Local).AddTicks(6561)
                        },
                        new
                        {
                            Id = 4,
                            Active = true,
                            CreatedAt = new DateTime(2020, 2, 23, 9, 37, 32, 713, DateTimeKind.Local).AddTicks(6571),
                            Description = "Opis vrste 4",
                            Identifier = new Guid("a450f575-2ded-4fa2-81e6-7212a5154da7"),
                            Name = "Vrsta 4",
                            UpdatedAt = new DateTime(2020, 2, 23, 9, 37, 32, 713, DateTimeKind.Local).AddTicks(6574)
                        },
                        new
                        {
                            Id = 5,
                            Active = true,
                            CreatedAt = new DateTime(2020, 2, 23, 9, 37, 32, 713, DateTimeKind.Local).AddTicks(6585),
                            Description = "Opis vrste 5",
                            Identifier = new Guid("b4e4eae2-dc49-48b7-a8a9-9a900a440ce5"),
                            Name = "Vrsta 5",
                            UpdatedAt = new DateTime(2020, 2, 23, 9, 37, 32, 713, DateTimeKind.Local).AddTicks(6588)
                        },
                        new
                        {
                            Id = 6,
                            Active = true,
                            CreatedAt = new DateTime(2020, 2, 23, 9, 37, 32, 713, DateTimeKind.Local).AddTicks(7184),
                            Description = "Opis Pod vrste 1",
                            Identifier = new Guid("29a7bca3-dcf8-41dd-aa3f-d7879f1b9ab7"),
                            Name = "Pod Vrsta 1",
                            ParentProductTypeId = 1,
                            UpdatedAt = new DateTime(2020, 2, 23, 9, 37, 32, 713, DateTimeKind.Local).AddTicks(7198)
                        },
                        new
                        {
                            Id = 7,
                            Active = true,
                            CreatedAt = new DateTime(2020, 2, 23, 9, 37, 32, 713, DateTimeKind.Local).AddTicks(7231),
                            Description = "Opis Pod vrste 2",
                            Identifier = new Guid("cfa869a2-3d5e-499a-99ba-c21afd962799"),
                            Name = "Pod Vrsta 2",
                            ParentProductTypeId = 1,
                            UpdatedAt = new DateTime(2020, 2, 23, 9, 37, 32, 713, DateTimeKind.Local).AddTicks(7235)
                        },
                        new
                        {
                            Id = 8,
                            Active = true,
                            CreatedAt = new DateTime(2020, 2, 23, 9, 37, 32, 713, DateTimeKind.Local).AddTicks(7261),
                            Description = "Opis Pod vrste 3",
                            Identifier = new Guid("2f445d66-ecaa-4dfd-8a1a-b2c2b64e3306"),
                            Name = "Pod Vrsta 3",
                            ParentProductTypeId = 2,
                            UpdatedAt = new DateTime(2020, 2, 23, 9, 37, 32, 713, DateTimeKind.Local).AddTicks(7264)
                        },
                        new
                        {
                            Id = 9,
                            Active = true,
                            CreatedAt = new DateTime(2020, 2, 23, 9, 37, 32, 713, DateTimeKind.Local).AddTicks(7275),
                            Description = "Opis Pod vrste 4",
                            Identifier = new Guid("792f95f3-3a5e-4385-ad83-139808975a62"),
                            Name = "Pod Vrsta 4",
                            ParentProductTypeId = 2,
                            UpdatedAt = new DateTime(2020, 2, 23, 9, 37, 32, 713, DateTimeKind.Local).AddTicks(7278)
                        },
                        new
                        {
                            Id = 10,
                            Active = true,
                            CreatedAt = new DateTime(2020, 2, 23, 9, 37, 32, 713, DateTimeKind.Local).AddTicks(7288),
                            Description = "Opis Pod vrste 5",
                            Identifier = new Guid("314c14db-bdcd-46ee-a071-c98ef206ab10"),
                            Name = "Pod Vrsta 5",
                            ParentProductTypeId = 3,
                            UpdatedAt = new DateTime(2020, 2, 23, 9, 37, 32, 713, DateTimeKind.Local).AddTicks(7292)
                        });
                });

            modelBuilder.Entity("Domain.Products.Product_ProductType", b =>
                {
                    b.Property<int?>("ProductId")
                        .HasColumnType("integer");

                    b.Property<int?>("ProductTypeId")
                        .HasColumnType("integer");

                    b.HasKey("ProductId", "ProductTypeId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("Product_ProductType");
                });

            modelBuilder.Entity("Domain.Products.ProductType", b =>
                {
                    b.HasOne("Domain.Products.ProductType", "ParentProductType")
                        .WithMany("SubTypes")
                        .HasForeignKey("ParentProductTypeId");
                });

            modelBuilder.Entity("Domain.Products.Product_ProductType", b =>
                {
                    b.HasOne("Domain.Products.Product", "Product")
                        .WithMany("Product_ProductTypes")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Products.ProductType", "ProductType")
                        .WithMany("Product_ProductTypes")
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
