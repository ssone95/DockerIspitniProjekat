using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class Product_Modification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductTypes_Products_ProductId",
                table: "ProductTypes");

            migrationBuilder.DropIndex(
                name: "IX_ProductTypes_ProductId",
                table: "ProductTypes");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ProductTypes");

            migrationBuilder.AlterColumn<string>(
                name: "Tags",
                table: "Products",
                nullable: true,
                oldClrType: typeof(string[]),
                oldType: "text[]",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Product_ProductType",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false),
                    ProductTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product_ProductType", x => new { x.ProductId, x.ProductTypeId });
                    table.ForeignKey(
                        name: "FK_Product_ProductType_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_ProductType_ProductTypes_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 23, 9, 37, 32, 715, DateTimeKind.Local).AddTicks(1284), new Guid("bcccf35a-99d6-4ce2-b707-59c1bb922795"), new DateTime(2020, 2, 23, 9, 37, 32, 715, DateTimeKind.Local).AddTicks(1287) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 23, 9, 37, 32, 715, DateTimeKind.Local).AddTicks(3290), new Guid("d1b5d1c8-fca6-4cb4-b194-edfb55a2eb76"), new DateTime(2020, 2, 23, 9, 37, 32, 715, DateTimeKind.Local).AddTicks(3293) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 23, 9, 37, 32, 715, DateTimeKind.Local).AddTicks(3346), new Guid("e8d28099-832a-4e53-92e4-959267c6d9cf"), new DateTime(2020, 2, 23, 9, 37, 32, 715, DateTimeKind.Local).AddTicks(3350) });

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductType_ProductTypeId",
                table: "Product_ProductType",
                column: "ProductTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product_ProductType");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "ProductTypes",
                type: "integer",
                nullable: true);

            migrationBuilder.AlterColumn<string[]>(
                name: "Tags",
                table: "Products",
                type: "text[]",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 22, 21, 33, 54, 246, DateTimeKind.Local).AddTicks(3671), new Guid("5eb8e21c-f9ab-431f-8840-17a7865e43a7"), new DateTime(2020, 2, 22, 21, 33, 54, 246, DateTimeKind.Local).AddTicks(4237) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 22, 21, 33, 54, 246, DateTimeKind.Local).AddTicks(4870), new Guid("386fb8ea-5cf9-4006-84fa-fd319d1090d1"), new DateTime(2020, 2, 22, 21, 33, 54, 246, DateTimeKind.Local).AddTicks(4896) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 22, 21, 33, 54, 246, DateTimeKind.Local).AddTicks(4915), new Guid("2f9b592e-8d0a-4084-9677-50d5585cadf7"), new DateTime(2020, 2, 22, 21, 33, 54, 246, DateTimeKind.Local).AddTicks(4919) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 22, 21, 33, 54, 246, DateTimeKind.Local).AddTicks(4930), new Guid("cb5e6388-defb-45ec-a823-64812a1d756c"), new DateTime(2020, 2, 22, 21, 33, 54, 246, DateTimeKind.Local).AddTicks(4933) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 22, 21, 33, 54, 246, DateTimeKind.Local).AddTicks(4944), new Guid("229405a9-0ff5-417b-9d01-6832c86f1079"), new DateTime(2020, 2, 22, 21, 33, 54, 246, DateTimeKind.Local).AddTicks(4947) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 22, 21, 33, 54, 246, DateTimeKind.Local).AddTicks(5534), new Guid("9ee843ef-77b9-45fb-9da9-21ea91117917"), new DateTime(2020, 2, 22, 21, 33, 54, 246, DateTimeKind.Local).AddTicks(5551) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 22, 21, 33, 54, 246, DateTimeKind.Local).AddTicks(5582), new Guid("8c6ae88e-e69d-43b7-8681-5df117d8c431"), new DateTime(2020, 2, 22, 21, 33, 54, 246, DateTimeKind.Local).AddTicks(5586) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 22, 21, 33, 54, 246, DateTimeKind.Local).AddTicks(5597), new Guid("23ca63b1-df95-4b45-b2d9-a92614be8468"), new DateTime(2020, 2, 22, 21, 33, 54, 246, DateTimeKind.Local).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 22, 21, 33, 54, 246, DateTimeKind.Local).AddTicks(5619), new Guid("4a9255f7-5fe8-43d1-bac5-c7d83a0b5546"), new DateTime(2020, 2, 22, 21, 33, 54, 246, DateTimeKind.Local).AddTicks(5623) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 22, 21, 33, 54, 246, DateTimeKind.Local).AddTicks(5634), new Guid("f757819c-51ff-43f9-924c-bba15074612b"), new DateTime(2020, 2, 22, 21, 33, 54, 246, DateTimeKind.Local).AddTicks(5637) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 22, 21, 33, 54, 247, DateTimeKind.Local).AddTicks(9923), new Guid("1b11aa91-3013-4281-9840-9a293cd896b1"), new DateTime(2020, 2, 22, 21, 33, 54, 247, DateTimeKind.Local).AddTicks(9927) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 22, 21, 33, 54, 248, DateTimeKind.Local).AddTicks(2068), new Guid("f91a9c3c-447e-4cc6-8f51-e6778078aab0"), new DateTime(2020, 2, 22, 21, 33, 54, 248, DateTimeKind.Local).AddTicks(2072) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 22, 21, 33, 54, 248, DateTimeKind.Local).AddTicks(2129), new Guid("3eead302-98d7-4828-9636-b823c327d7e6"), new DateTime(2020, 2, 22, 21, 33, 54, 248, DateTimeKind.Local).AddTicks(2133) });

            migrationBuilder.CreateIndex(
                name: "IX_ProductTypes_ProductId",
                table: "ProductTypes",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTypes_Products_ProductId",
                table: "ProductTypes",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
