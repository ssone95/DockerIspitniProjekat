﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Repository.Context;

namespace Repository.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200222202017_Initial")]
    partial class Initial
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

                    b.Property<List<string>>("Tags")
                        .HasColumnType("text[]");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Products");
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

                    b.Property<int?>("ProductId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("ParentProductTypeId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Active = true,
                            CreatedAt = new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(7061),
                            Description = "Opis vrste 1",
                            Identifier = new Guid("d8674cd1-2c63-4303-8c13-6428b1ffde62"),
                            Name = "Vrsta 1",
                            UpdatedAt = new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(7597)
                        },
                        new
                        {
                            Id = 2,
                            Active = true,
                            CreatedAt = new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8198),
                            Description = "Opis vrste 2",
                            Identifier = new Guid("5ffccdfa-cde9-47ac-91b9-44be0d4def50"),
                            Name = "Vrsta 2",
                            UpdatedAt = new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8218)
                        },
                        new
                        {
                            Id = 3,
                            Active = true,
                            CreatedAt = new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8238),
                            Description = "Opis vrste 3",
                            Identifier = new Guid("4e15483a-e492-46cd-a884-1e35408871a8"),
                            Name = "Vrsta 3",
                            UpdatedAt = new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8241)
                        },
                        new
                        {
                            Id = 4,
                            Active = true,
                            CreatedAt = new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8252),
                            Description = "Opis vrste 4",
                            Identifier = new Guid("828eeeb3-9726-4752-88fb-c288927fcd28"),
                            Name = "Vrsta 4",
                            UpdatedAt = new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8255)
                        },
                        new
                        {
                            Id = 5,
                            Active = true,
                            CreatedAt = new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8266),
                            Description = "Opis vrste 5",
                            Identifier = new Guid("a41ea978-e784-4046-828f-a4432d1801e6"),
                            Name = "Vrsta 5",
                            UpdatedAt = new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8269)
                        },
                        new
                        {
                            Id = 6,
                            Active = true,
                            CreatedAt = new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8830),
                            Description = "Opis Pod vrste 1",
                            Identifier = new Guid("6b5e6781-9f0a-42cf-9309-3f49e9d99c17"),
                            Name = "Pod Vrsta 1",
                            ParentProductTypeId = 1,
                            UpdatedAt = new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8845)
                        },
                        new
                        {
                            Id = 7,
                            Active = true,
                            CreatedAt = new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8874),
                            Description = "Opis Pod vrste 2",
                            Identifier = new Guid("476ba16a-95ca-4cef-a09d-b07556fc462d"),
                            Name = "Pod Vrsta 2",
                            ParentProductTypeId = 1,
                            UpdatedAt = new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8877)
                        },
                        new
                        {
                            Id = 8,
                            Active = true,
                            CreatedAt = new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8903),
                            Description = "Opis Pod vrste 3",
                            Identifier = new Guid("933ff81c-424b-4d5f-8a59-234ef6fd71c8"),
                            Name = "Pod Vrsta 3",
                            ParentProductTypeId = 2,
                            UpdatedAt = new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8907)
                        },
                        new
                        {
                            Id = 9,
                            Active = true,
                            CreatedAt = new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8918),
                            Description = "Opis Pod vrste 4",
                            Identifier = new Guid("aa24c747-1cb9-4821-bcd5-ada6ba194cc5"),
                            Name = "Pod Vrsta 4",
                            ParentProductTypeId = 2,
                            UpdatedAt = new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8922)
                        },
                        new
                        {
                            Id = 10,
                            Active = true,
                            CreatedAt = new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8933),
                            Description = "Opis Pod vrste 5",
                            Identifier = new Guid("62585f3b-67ef-4785-96d2-92b69e9760f3"),
                            Name = "Pod Vrsta 5",
                            ParentProductTypeId = 3,
                            UpdatedAt = new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8936)
                        });
                });

            modelBuilder.Entity("Domain.Products.ProductType", b =>
                {
                    b.HasOne("Domain.Products.ProductType", "ParentProductType")
                        .WithMany("SubTypes")
                        .HasForeignKey("ParentProductTypeId");

                    b.HasOne("Domain.Products.Product", null)
                        .WithMany("ProductTypes")
                        .HasForeignKey("ProductId");
                });
#pragma warning restore 612, 618
        }
    }
}
