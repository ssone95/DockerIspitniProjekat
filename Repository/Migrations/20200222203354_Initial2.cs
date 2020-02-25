using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Active", "CreatedAt", "Description", "Discount", "Identifier", "Name", "Price", "Tags", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2020, 2, 22, 21, 33, 54, 247, DateTimeKind.Local).AddTicks(9923), "Opis 1", 0, new Guid("1b11aa91-3013-4281-9840-9a293cd896b1"), "Artikal 1", 100m, null, new DateTime(2020, 2, 22, 21, 33, 54, 247, DateTimeKind.Local).AddTicks(9927) },
                    { 2, true, new DateTime(2020, 2, 22, 21, 33, 54, 248, DateTimeKind.Local).AddTicks(2068), "Opis 2", 1, new Guid("f91a9c3c-447e-4cc6-8f51-e6778078aab0"), "Artikal 2", 100m, null, new DateTime(2020, 2, 22, 21, 33, 54, 248, DateTimeKind.Local).AddTicks(2072) },
                    { 3, true, new DateTime(2020, 2, 22, 21, 33, 54, 248, DateTimeKind.Local).AddTicks(2129), "Opis 2", 1, new Guid("3eead302-98d7-4828-9636-b823c327d7e6"), "Artikal 2", 100m, null, new DateTime(2020, 2, 22, 21, 33, 54, 248, DateTimeKind.Local).AddTicks(2133) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(7061), new Guid("d8674cd1-2c63-4303-8c13-6428b1ffde62"), new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(7597) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8198), new Guid("5ffccdfa-cde9-47ac-91b9-44be0d4def50"), new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8218) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8238), new Guid("4e15483a-e492-46cd-a884-1e35408871a8"), new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8241) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8252), new Guid("828eeeb3-9726-4752-88fb-c288927fcd28"), new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8255) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8266), new Guid("a41ea978-e784-4046-828f-a4432d1801e6"), new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8269) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8830), new Guid("6b5e6781-9f0a-42cf-9309-3f49e9d99c17"), new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8845) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8874), new Guid("476ba16a-95ca-4cef-a09d-b07556fc462d"), new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8877) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8903), new Guid("933ff81c-424b-4d5f-8a59-234ef6fd71c8"), new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8907) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8918), new Guid("aa24c747-1cb9-4821-bcd5-ada6ba194cc5"), new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8922) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8933), new Guid("62585f3b-67ef-4785-96d2-92b69e9760f3"), new DateTime(2020, 2, 22, 21, 20, 16, 868, DateTimeKind.Local).AddTicks(8936) });
        }
    }
}
