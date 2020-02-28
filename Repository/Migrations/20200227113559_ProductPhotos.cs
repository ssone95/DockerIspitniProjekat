using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class ProductPhotos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductPhotos",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false),
                    PhotoPath = table.Column<string>(nullable: false),
                    MainPhoto = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPhotos", x => new { x.ProductId, x.PhotoPath });
                    table.ForeignKey(
                        name: "FK_ProductPhotos_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 12, 35, 58, 364, DateTimeKind.Local).AddTicks(2770), new Guid("3c68c977-546d-4834-8499-21fc31b52034"), new DateTime(2020, 2, 27, 12, 35, 58, 364, DateTimeKind.Local).AddTicks(3383) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 12, 35, 58, 364, DateTimeKind.Local).AddTicks(4198), new Guid("b84db2de-0394-4600-9afd-72433628e8c7"), new DateTime(2020, 2, 27, 12, 35, 58, 364, DateTimeKind.Local).AddTicks(4218) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 12, 35, 58, 364, DateTimeKind.Local).AddTicks(4238), new Guid("a2db4b86-0128-4c3b-b189-54a7377fc8b3"), new DateTime(2020, 2, 27, 12, 35, 58, 364, DateTimeKind.Local).AddTicks(4241) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 12, 35, 58, 364, DateTimeKind.Local).AddTicks(4252), new Guid("8faa0aa5-b2a7-419d-bd32-9d6248caee62"), new DateTime(2020, 2, 27, 12, 35, 58, 364, DateTimeKind.Local).AddTicks(4255) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 12, 35, 58, 364, DateTimeKind.Local).AddTicks(4265), new Guid("4319937e-baef-4930-bd85-a37c8f700e2b"), new DateTime(2020, 2, 27, 12, 35, 58, 364, DateTimeKind.Local).AddTicks(4269) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 12, 35, 58, 364, DateTimeKind.Local).AddTicks(4933), new Guid("d2a9e796-c9ce-4c89-a0fa-5a41c6b01aab"), new DateTime(2020, 2, 27, 12, 35, 58, 364, DateTimeKind.Local).AddTicks(4949) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 12, 35, 58, 364, DateTimeKind.Local).AddTicks(4978), new Guid("ec86c6da-c5f1-45b6-8984-ee705ea1b75f"), new DateTime(2020, 2, 27, 12, 35, 58, 364, DateTimeKind.Local).AddTicks(4982) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 12, 35, 58, 364, DateTimeKind.Local).AddTicks(4993), new Guid("1c21e5dc-ff2d-4d87-a68d-9730e569a6b6"), new DateTime(2020, 2, 27, 12, 35, 58, 364, DateTimeKind.Local).AddTicks(4996) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 12, 35, 58, 364, DateTimeKind.Local).AddTicks(5007), new Guid("815315c2-c280-4b45-94b6-a5cf200c7c87"), new DateTime(2020, 2, 27, 12, 35, 58, 364, DateTimeKind.Local).AddTicks(5010) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 12, 35, 58, 364, DateTimeKind.Local).AddTicks(5021), new Guid("d94426d3-fca3-4cbc-bbf5-a4e0335126b5"), new DateTime(2020, 2, 27, 12, 35, 58, 364, DateTimeKind.Local).AddTicks(5024) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 12, 35, 58, 366, DateTimeKind.Local).AddTicks(293), new Guid("396cab4c-15a2-4bac-a9b9-250c41e8fe5a"), new DateTime(2020, 2, 27, 12, 35, 58, 366, DateTimeKind.Local).AddTicks(296) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 12, 35, 58, 366, DateTimeKind.Local).AddTicks(3148), "<i><b>Opis</b></i> 2", new Guid("f14479e5-bd5b-44c6-8574-b093f77dff83"), new DateTime(2020, 2, 27, 12, 35, 58, 366, DateTimeKind.Local).AddTicks(3152) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 12, 35, 58, 366, DateTimeKind.Local).AddTicks(3261), new Guid("d6dbd2f3-6af5-4b73-8315-989f8f23ec20"), new DateTime(2020, 2, 27, 12, 35, 58, 366, DateTimeKind.Local).AddTicks(3264) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductPhotos");

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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 23, 9, 43, 10, 487, DateTimeKind.Local).AddTicks(8004), new Guid("7c335389-0c88-41ea-9de7-7bdffcb30548"), new DateTime(2020, 2, 23, 9, 43, 10, 487, DateTimeKind.Local).AddTicks(8008) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 23, 9, 43, 10, 488, DateTimeKind.Local).AddTicks(1500), "Opis 2", new Guid("68735fbc-5cd4-4f8b-8407-6cb6d1acb201"), new DateTime(2020, 2, 23, 9, 43, 10, 488, DateTimeKind.Local).AddTicks(1503) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 23, 9, 43, 10, 488, DateTimeKind.Local).AddTicks(1570), new Guid("f040afb1-154e-4670-9662-d3d19561a30b"), new DateTime(2020, 2, 23, 9, 43, 10, 488, DateTimeKind.Local).AddTicks(1573) });
        }
    }
}
