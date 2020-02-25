using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Repository.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Identifier = table.Column<Guid>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Discount = table.Column<int>(nullable: false),
                    Tags = table.Column<List<string>>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Identifier = table.Column<Guid>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ParentProductTypeId = table.Column<int>(nullable: true),
                    ProductId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductTypes_ProductTypes_ParentProductTypeId",
                        column: x => x.ParentProductTypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductTypes_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Active", "CreatedAt", "Description", "Identifier", "Name", "ParentProductTypeId", "ProductId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(7061), "Opis vrste 1", new Guid("d8674cd1-2c63-4303-8c13-6428b1ffde62"), "Vrsta 1", null, null, new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(7597) },
                    { 2, true, new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8198), "Opis vrste 2", new Guid("5ffccdfa-cde9-47ac-91b9-44be0d4def50"), "Vrsta 2", null, null, new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8218) },
                    { 3, true, new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8238), "Opis vrste 3", new Guid("4e15483a-e492-46cd-a884-1e35408871a8"), "Vrsta 3", null, null, new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8241) },
                    { 4, true, new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8252), "Opis vrste 4", new Guid("828eeeb3-9726-4752-88fb-c288927fcd28"), "Vrsta 4", null, null, new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8255) },
                    { 5, true, new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8266), "Opis vrste 5", new Guid("a41ea978-e784-4046-828f-a4432d1801e6"), "Vrsta 5", null, null, new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8269) }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Active", "CreatedAt", "Description", "Identifier", "Name", "ParentProductTypeId", "ProductId", "UpdatedAt" },
                values: new object[,]
                {
                    { 6, true, new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8830), "Opis Pod vrste 1", new Guid("6b5e6781-9f0a-42cf-9309-3f49e9d99c17"), "Pod Vrsta 1", 1, null, new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8845) },
                    { 7, true, new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8874), "Opis Pod vrste 2", new Guid("476ba16a-95ca-4cef-a09d-b07556fc462d"), "Pod Vrsta 2", 1, null, new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8877) },
                    { 8, true, new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8903), "Opis Pod vrste 3", new Guid("933ff81c-424b-4d5f-8a59-234ef6fd71c8"), "Pod Vrsta 3", 2, null, new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8907) },
                    { 9, true, new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8918), "Opis Pod vrste 4", new Guid("aa24c747-1cb9-4821-bcd5-ada6ba194cc5"), "Pod Vrsta 4", 2, null, new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8922) },
                    { 10, true, new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8933), "Opis Pod vrste 5", new Guid("62585f3b-67ef-4785-96d2-92b69e9760f3"), "Pod Vrsta 5", 3, null, new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8936) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductTypes_ParentProductTypeId",
                table: "ProductTypes",
                column: "ParentProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTypes_ProductId",
                table: "ProductTypes",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductTypes");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
