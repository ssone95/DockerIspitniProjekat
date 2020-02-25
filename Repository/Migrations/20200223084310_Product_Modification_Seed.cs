using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class Product_Modification_Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 23, 9, 43, 10, 486, DateTimeKind.Local).AddTicks(1217), new Guid("ffbc74d7-8f18-4020-ac63-e8ee26b4ae39"), new DateTime(2020, 2, 23, 9, 43, 10, 486, DateTimeKind.Local).AddTicks(1790) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 23, 9, 43, 10, 486, DateTimeKind.Local).AddTicks(2417), new Guid("bb3b6af8-0efb-437b-ae74-75b952f4006f"), new DateTime(2020, 2, 23, 9, 43, 10, 486, DateTimeKind.Local).AddTicks(2435) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 23, 9, 43, 10, 486, DateTimeKind.Local).AddTicks(2455), new Guid("26aa3ebc-18d5-41be-9564-5543cbc7d632"), new DateTime(2020, 2, 23, 9, 43, 10, 486, DateTimeKind.Local).AddTicks(2459) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 23, 9, 43, 10, 486, DateTimeKind.Local).AddTicks(2470), new Guid("1549b883-60c8-4d6b-9ef2-bae91a16f3ca"), new DateTime(2020, 2, 23, 9, 43, 10, 486, DateTimeKind.Local).AddTicks(2473) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 23, 9, 43, 10, 486, DateTimeKind.Local).AddTicks(2484), new Guid("755eea30-e157-4b56-9372-adf3e684f7bf"), new DateTime(2020, 2, 23, 9, 43, 10, 486, DateTimeKind.Local).AddTicks(2487) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 23, 9, 43, 10, 486, DateTimeKind.Local).AddTicks(3065), new Guid("bf31c4c9-e0a2-4c04-9b7b-3833fdf70448"), new DateTime(2020, 2, 23, 9, 43, 10, 486, DateTimeKind.Local).AddTicks(3079) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 23, 9, 43, 10, 486, DateTimeKind.Local).AddTicks(3110), new Guid("6b98f227-0376-48a5-96b7-7f44119eccd3"), new DateTime(2020, 2, 23, 9, 43, 10, 486, DateTimeKind.Local).AddTicks(3114) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 23, 9, 43, 10, 486, DateTimeKind.Local).AddTicks(3142), new Guid("924edcc6-1611-498f-ad29-fe9fff92dcd1"), new DateTime(2020, 2, 23, 9, 43, 10, 486, DateTimeKind.Local).AddTicks(3146) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 23, 9, 43, 10, 486, DateTimeKind.Local).AddTicks(3158), new Guid("2c4ef978-32b3-44d6-8a0d-0149d5bca4e5"), new DateTime(2020, 2, 23, 9, 43, 10, 486, DateTimeKind.Local).AddTicks(3161) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 23, 9, 43, 10, 486, DateTimeKind.Local).AddTicks(3172), new Guid("95540ee8-d359-450d-ad16-7f62b5a98cec"), new DateTime(2020, 2, 23, 9, 43, 10, 486, DateTimeKind.Local).AddTicks(3176) });

            migrationBuilder.InsertData(
                table: "Product_ProductType",
                columns: new[] { "ProductId", "ProductTypeId" },
                values: new object[,]
                {
                    { 1, 10 },
                    { 3, 10 },
                    { 3, 2 },
                    { 3, 9 },
                    { 2, 9 },
                    { 2, 8 },
                    { 1, 7 },
                    { 1, 6 }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Identifier", "Tags", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 23, 9, 43, 10, 487, DateTimeKind.Local).AddTicks(8004), new Guid("7c335389-0c88-41ea-9de7-7bdffcb30548"), "Artikal;test;Nesto;Nesto 2;Proba;", new DateTime(2020, 2, 23, 9, 43, 10, 487, DateTimeKind.Local).AddTicks(8008) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Identifier", "Tags", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 23, 9, 43, 10, 488, DateTimeKind.Local).AddTicks(1500), new Guid("68735fbc-5cd4-4f8b-8407-6cb6d1acb201"), "Artikal;test;Nesto;Nesto 2;Proba;", new DateTime(2020, 2, 23, 9, 43, 10, 488, DateTimeKind.Local).AddTicks(1503) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Identifier", "Tags", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 23, 9, 43, 10, 488, DateTimeKind.Local).AddTicks(1570), new Guid("f040afb1-154e-4670-9662-d3d19561a30b"), "Artikal;test;Nesto;Nesto 2;Proba;", new DateTime(2020, 2, 23, 9, 43, 10, 488, DateTimeKind.Local).AddTicks(1573) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product_ProductType",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "Product_ProductType",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "Product_ProductType",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "Product_ProductType",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "Product_ProductType",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "Product_ProductType",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "Product_ProductType",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "Product_ProductType",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 23, 9, 37, 32, 713, DateTimeKind.Local).AddTicks(5300), new Guid("b15e852d-03cb-498d-bad0-004f70b0d8f9"), new DateTime(2020, 2, 23, 9, 37, 32, 713, DateTimeKind.Local).AddTicks(5873) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 23, 9, 37, 32, 713, DateTimeKind.Local).AddTicks(6512), new Guid("53520aa9-214f-442f-9064-b61edc041ccf"), new DateTime(2020, 2, 23, 9, 37, 32, 713, DateTimeKind.Local).AddTicks(6536) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 23, 9, 37, 32, 713, DateTimeKind.Local).AddTicks(6558), new Guid("b08f1c66-f17f-46a6-aa00-ae8832bc1685"), new DateTime(2020, 2, 23, 9, 37, 32, 713, DateTimeKind.Local).AddTicks(6561) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 23, 9, 37, 32, 713, DateTimeKind.Local).AddTicks(6571), new Guid("a450f575-2ded-4fa2-81e6-7212a5154da7"), new DateTime(2020, 2, 23, 9, 37, 32, 713, DateTimeKind.Local).AddTicks(6574) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 23, 9, 37, 32, 713, DateTimeKind.Local).AddTicks(6585), new Guid("b4e4eae2-dc49-48b7-a8a9-9a900a440ce5"), new DateTime(2020, 2, 23, 9, 37, 32, 713, DateTimeKind.Local).AddTicks(6588) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 23, 9, 37, 32, 713, DateTimeKind.Local).AddTicks(7184), new Guid("29a7bca3-dcf8-41dd-aa3f-d7879f1b9ab7"), new DateTime(2020, 2, 23, 9, 37, 32, 713, DateTimeKind.Local).AddTicks(7198) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 23, 9, 37, 32, 713, DateTimeKind.Local).AddTicks(7231), new Guid("cfa869a2-3d5e-499a-99ba-c21afd962799"), new DateTime(2020, 2, 23, 9, 37, 32, 713, DateTimeKind.Local).AddTicks(7235) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 23, 9, 37, 32, 713, DateTimeKind.Local).AddTicks(7261), new Guid("2f445d66-ecaa-4dfd-8a1a-b2c2b64e3306"), new DateTime(2020, 2, 23, 9, 37, 32, 713, DateTimeKind.Local).AddTicks(7264) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 23, 9, 37, 32, 713, DateTimeKind.Local).AddTicks(7275), new Guid("792f95f3-3a5e-4385-ad83-139808975a62"), new DateTime(2020, 2, 23, 9, 37, 32, 713, DateTimeKind.Local).AddTicks(7278) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 23, 9, 37, 32, 713, DateTimeKind.Local).AddTicks(7288), new Guid("314c14db-bdcd-46ee-a071-c98ef206ab10"), new DateTime(2020, 2, 23, 9, 37, 32, 713, DateTimeKind.Local).AddTicks(7292) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Identifier", "Tags", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 23, 9, 37, 32, 715, DateTimeKind.Local).AddTicks(1284), new Guid("bcccf35a-99d6-4ce2-b707-59c1bb922795"), null, new DateTime(2020, 2, 23, 9, 37, 32, 715, DateTimeKind.Local).AddTicks(1287) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Identifier", "Tags", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 23, 9, 37, 32, 715, DateTimeKind.Local).AddTicks(3290), new Guid("d1b5d1c8-fca6-4cb4-b194-edfb55a2eb76"), null, new DateTime(2020, 2, 23, 9, 37, 32, 715, DateTimeKind.Local).AddTicks(3293) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Identifier", "Tags", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 23, 9, 37, 32, 715, DateTimeKind.Local).AddTicks(3346), new Guid("e8d28099-832a-4e53-92e4-959267c6d9cf"), null, new DateTime(2020, 2, 23, 9, 37, 32, 715, DateTimeKind.Local).AddTicks(3350) });
        }
    }
}
