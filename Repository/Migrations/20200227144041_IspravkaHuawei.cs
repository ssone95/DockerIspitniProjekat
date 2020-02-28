using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class IspravkaHuawei : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductPhotos",
                keyColumns: new[] { "ProductId", "PhotoPath" },
                keyValues: new object[] { 1, "/photos/phones/huawei/Huawei_P30_Lite_Blue_Front.jpg" });

            migrationBuilder.DeleteData(
                table: "ProductPhotos",
                keyColumns: new[] { "ProductId", "PhotoPath" },
                keyValues: new object[] { 2, "/photos/phones/huawei/Huawei_P20_Twilight_Front.jpg" });

            migrationBuilder.InsertData(
                table: "ProductPhotos",
                columns: new[] { "ProductId", "PhotoPath", "MainPhoto" },
                values: new object[,]
                {
                    { 1, "/photos/phones/Huawei/Huawei_P30_Lite_Blue_Front.jpg", true },
                    { 2, "/photos/phones/Huawei/Huawei_P20_Twilight_Front.jpg", true }
                });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 15, 40, 40, 397, DateTimeKind.Local).AddTicks(2741), new Guid("c94bd74a-e77c-4c78-b851-7e1ae7b9ddde"), new DateTime(2020, 2, 27, 15, 40, 40, 397, DateTimeKind.Local).AddTicks(3716) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 15, 40, 40, 397, DateTimeKind.Local).AddTicks(4831), new Guid("2e84f6ba-5f3f-4bad-8bc7-661007a162ea"), new DateTime(2020, 2, 27, 15, 40, 40, 397, DateTimeKind.Local).AddTicks(4862) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 15, 40, 40, 397, DateTimeKind.Local).AddTicks(4899), new Guid("08932bd1-04f2-49c6-a2f3-b1dbf95c0f4b"), new DateTime(2020, 2, 27, 15, 40, 40, 397, DateTimeKind.Local).AddTicks(4906) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 15, 40, 40, 397, DateTimeKind.Local).AddTicks(4927), new Guid("8597cd5a-3467-49b5-ba04-f700ea8c8a5d"), new DateTime(2020, 2, 27, 15, 40, 40, 397, DateTimeKind.Local).AddTicks(4933) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 15, 40, 40, 397, DateTimeKind.Local).AddTicks(4954), new Guid("667c8c61-3a33-4b49-b2a0-d41481eb93cb"), new DateTime(2020, 2, 27, 15, 40, 40, 397, DateTimeKind.Local).AddTicks(4960) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 15, 40, 40, 397, DateTimeKind.Local).AddTicks(5936), new Guid("fdb6e79e-d7a0-4e77-8d23-8e0aed2e0a29"), new DateTime(2020, 2, 27, 15, 40, 40, 397, DateTimeKind.Local).AddTicks(5959) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 15, 40, 40, 397, DateTimeKind.Local).AddTicks(6009), new Guid("fe8aa944-f9e8-4da5-b211-c6c7d8fd6ad5"), new DateTime(2020, 2, 27, 15, 40, 40, 397, DateTimeKind.Local).AddTicks(6016) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 15, 40, 40, 397, DateTimeKind.Local).AddTicks(6039), new Guid("05bb8b23-eb60-4a5b-9259-fddb7128fce0"), new DateTime(2020, 2, 27, 15, 40, 40, 397, DateTimeKind.Local).AddTicks(6045) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 15, 40, 40, 397, DateTimeKind.Local).AddTicks(6067), new Guid("9ac869dc-10f5-4b78-8d76-fa6239ef7ae9"), new DateTime(2020, 2, 27, 15, 40, 40, 397, DateTimeKind.Local).AddTicks(6073) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 15, 40, 40, 397, DateTimeKind.Local).AddTicks(6095), new Guid("abddd9b0-058d-4863-a285-2f0e3c869be8"), new DateTime(2020, 2, 27, 15, 40, 40, 397, DateTimeKind.Local).AddTicks(6101) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 15, 40, 40, 397, DateTimeKind.Local).AddTicks(6122), new Guid("a36f9ebf-d205-4e44-a51d-e183e2089a5d"), new DateTime(2020, 2, 27, 15, 40, 40, 397, DateTimeKind.Local).AddTicks(6129) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 15, 40, 40, 397, DateTimeKind.Local).AddTicks(6150), new Guid("396102f2-757c-4a15-b7c3-98f8aa61e0e2"), new DateTime(2020, 2, 27, 15, 40, 40, 397, DateTimeKind.Local).AddTicks(6156) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 15, 40, 40, 397, DateTimeKind.Local).AddTicks(6266), new Guid("8ed3d7ec-c8cd-4a2c-bb75-211779a00dde"), new DateTime(2020, 2, 27, 15, 40, 40, 397, DateTimeKind.Local).AddTicks(6273) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 15, 40, 40, 397, DateTimeKind.Local).AddTicks(6302), new Guid("9eefcccf-66eb-4494-a694-49d9c2f29bf7"), new DateTime(2020, 2, 27, 15, 40, 40, 397, DateTimeKind.Local).AddTicks(6309) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 15, 40, 40, 397, DateTimeKind.Local).AddTicks(6330), new Guid("6424a195-276e-4463-9915-1c1c692df6e7"), new DateTime(2020, 2, 27, 15, 40, 40, 397, DateTimeKind.Local).AddTicks(6336) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 15, 40, 40, 397, DateTimeKind.Local).AddTicks(6357), new Guid("6573cc2d-0bc4-4ea8-ae36-d1bc9ee696d8"), new DateTime(2020, 2, 27, 15, 40, 40, 397, DateTimeKind.Local).AddTicks(6364) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 15, 40, 40, 397, DateTimeKind.Local).AddTicks(6385), new Guid("cf8ac7c1-5050-4f9d-8e59-fcd96fd1a281"), new DateTime(2020, 2, 27, 15, 40, 40, 397, DateTimeKind.Local).AddTicks(6391) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 15, 40, 40, 397, DateTimeKind.Local).AddTicks(6412), new Guid("769d012d-9858-438d-8b1a-64c5e239a4b6"), new DateTime(2020, 2, 27, 15, 40, 40, 397, DateTimeKind.Local).AddTicks(6418) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 15, 40, 40, 397, DateTimeKind.Local).AddTicks(6439), new Guid("786eca4b-51b7-4f09-acb5-8f4ea981d835"), new DateTime(2020, 2, 27, 15, 40, 40, 397, DateTimeKind.Local).AddTicks(6446) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 15, 40, 40, 397, DateTimeKind.Local).AddTicks(6467), new Guid("ec32efed-05f8-4fce-9d99-caf73fae04e0"), new DateTime(2020, 2, 27, 15, 40, 40, 397, DateTimeKind.Local).AddTicks(6473) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 15, 40, 40, 397, DateTimeKind.Local).AddTicks(6494), new Guid("6a0d07d0-ee5b-4c71-8a94-9a000ed70a06"), new DateTime(2020, 2, 27, 15, 40, 40, 397, DateTimeKind.Local).AddTicks(6500) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 15, 40, 40, 397, DateTimeKind.Local).AddTicks(6527), new Guid("ec4b5ecb-16a7-4a56-bd50-7bc035570ae2"), new DateTime(2020, 2, 27, 15, 40, 40, 397, DateTimeKind.Local).AddTicks(6533) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 15, 40, 40, 397, DateTimeKind.Local).AddTicks(6554), new Guid("416bbdc2-b302-4f64-a312-f125f470b535"), new DateTime(2020, 2, 27, 15, 40, 40, 397, DateTimeKind.Local).AddTicks(6561) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 15, 40, 40, 400, DateTimeKind.Local).AddTicks(1402), new Guid("8e853b83-55ab-4562-bd90-4af0a8d3f027"), new DateTime(2020, 2, 27, 15, 40, 40, 400, DateTimeKind.Local).AddTicks(1409) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 15, 40, 40, 401, DateTimeKind.Local).AddTicks(6645), new Guid("cb56ab55-3085-4721-8cd4-0eecc3b8fd06"), new DateTime(2020, 2, 27, 15, 40, 40, 401, DateTimeKind.Local).AddTicks(6651) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 15, 40, 40, 401, DateTimeKind.Local).AddTicks(7166), new Guid("27f6396c-8041-484a-9d73-50bc26bfa428"), new DateTime(2020, 2, 27, 15, 40, 40, 401, DateTimeKind.Local).AddTicks(7172) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 15, 40, 40, 401, DateTimeKind.Local).AddTicks(7326), new Guid("53cdf494-d911-4a62-bb18-7342a6c28f07"), new DateTime(2020, 2, 27, 15, 40, 40, 401, DateTimeKind.Local).AddTicks(7333) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 15, 40, 40, 401, DateTimeKind.Local).AddTicks(7482), new Guid("48273312-daac-4601-85ee-0acd86116c14"), new DateTime(2020, 2, 27, 15, 40, 40, 401, DateTimeKind.Local).AddTicks(7488) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 15, 40, 40, 401, DateTimeKind.Local).AddTicks(7654), new Guid("c98c4f2f-10a7-4bac-bfcc-f01db828d279"), new DateTime(2020, 2, 27, 15, 40, 40, 401, DateTimeKind.Local).AddTicks(7660) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 15, 40, 40, 401, DateTimeKind.Local).AddTicks(7995), new Guid("96ab4857-d0ce-4d96-8bc0-6f0486330c79"), new DateTime(2020, 2, 27, 15, 40, 40, 401, DateTimeKind.Local).AddTicks(8001) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 15, 40, 40, 401, DateTimeKind.Local).AddTicks(8148), new Guid("01d18ea0-27c9-47c6-9efd-2216373cdfb5"), new DateTime(2020, 2, 27, 15, 40, 40, 401, DateTimeKind.Local).AddTicks(8154) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 15, 40, 40, 401, DateTimeKind.Local).AddTicks(8324), new Guid("d986239a-00bb-41b4-98ea-800bb8d67f9f"), new DateTime(2020, 2, 27, 15, 40, 40, 401, DateTimeKind.Local).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 15, 40, 40, 401, DateTimeKind.Local).AddTicks(8490), new Guid("c41319c8-5ed6-4d10-b78b-3eadda55f22b"), new DateTime(2020, 2, 27, 15, 40, 40, 401, DateTimeKind.Local).AddTicks(8496) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 15, 40, 40, 401, DateTimeKind.Local).AddTicks(8645), new Guid("17b80d04-1f35-420b-b6d7-876af4d56fef"), new DateTime(2020, 2, 27, 15, 40, 40, 401, DateTimeKind.Local).AddTicks(8652) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 15, 40, 40, 401, DateTimeKind.Local).AddTicks(8798), new Guid("db2dd368-c7a3-439a-96ac-046c65ec3b3b"), new DateTime(2020, 2, 27, 15, 40, 40, 401, DateTimeKind.Local).AddTicks(8804) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductPhotos",
                keyColumns: new[] { "ProductId", "PhotoPath" },
                keyValues: new object[] { 1, "/photos/phones/Huawei/Huawei_P30_Lite_Blue_Front.jpg" });

            migrationBuilder.DeleteData(
                table: "ProductPhotos",
                keyColumns: new[] { "ProductId", "PhotoPath" },
                keyValues: new object[] { 2, "/photos/phones/Huawei/Huawei_P20_Twilight_Front.jpg" });

            migrationBuilder.InsertData(
                table: "ProductPhotos",
                columns: new[] { "ProductId", "PhotoPath", "MainPhoto" },
                values: new object[,]
                {
                    { 1, "/photos/phones/huawei/Huawei_P30_Lite_Blue_Front.jpg", true },
                    { 2, "/photos/phones/huawei/Huawei_P20_Twilight_Front.jpg", true }
                });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 14, 17, 6, 977, DateTimeKind.Local).AddTicks(1564), new Guid("d1f65fb5-d316-456e-8d52-9e23b38e5c86"), new DateTime(2020, 2, 27, 14, 17, 6, 977, DateTimeKind.Local).AddTicks(2351) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 14, 17, 6, 977, DateTimeKind.Local).AddTicks(3228), new Guid("26b87454-bbdd-4f37-a28d-07505b34773f"), new DateTime(2020, 2, 27, 14, 17, 6, 977, DateTimeKind.Local).AddTicks(3255) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 14, 17, 6, 977, DateTimeKind.Local).AddTicks(3283), new Guid("fbb64771-e567-42a1-bd9c-c609df48d38a"), new DateTime(2020, 2, 27, 14, 17, 6, 977, DateTimeKind.Local).AddTicks(3288) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 14, 17, 6, 977, DateTimeKind.Local).AddTicks(3304), new Guid("12727ea7-a8cf-48cd-a14f-ad7604c94d38"), new DateTime(2020, 2, 27, 14, 17, 6, 977, DateTimeKind.Local).AddTicks(3308) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 14, 17, 6, 977, DateTimeKind.Local).AddTicks(3324), new Guid("d58c884d-2212-4d70-a6a1-c691456b461d"), new DateTime(2020, 2, 27, 14, 17, 6, 977, DateTimeKind.Local).AddTicks(3329) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 14, 17, 6, 977, DateTimeKind.Local).AddTicks(4158), new Guid("03d104cb-b203-4acb-b55d-249286193c74"), new DateTime(2020, 2, 27, 14, 17, 6, 977, DateTimeKind.Local).AddTicks(4179) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 14, 17, 6, 977, DateTimeKind.Local).AddTicks(4221), new Guid("0905aef8-d09a-4c4c-ae7f-8f9fbe31c5fd"), new DateTime(2020, 2, 27, 14, 17, 6, 977, DateTimeKind.Local).AddTicks(4227) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 14, 17, 6, 977, DateTimeKind.Local).AddTicks(4243), new Guid("17c55dd0-5a6a-4d23-a4cf-2878dea29aba"), new DateTime(2020, 2, 27, 14, 17, 6, 977, DateTimeKind.Local).AddTicks(4248) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 14, 17, 6, 977, DateTimeKind.Local).AddTicks(4273), new Guid("eb23f964-b8ed-407e-8a5d-15a0877ee8e7"), new DateTime(2020, 2, 27, 14, 17, 6, 977, DateTimeKind.Local).AddTicks(4278) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 14, 17, 6, 977, DateTimeKind.Local).AddTicks(4295), new Guid("1a9fc1dc-c13e-41a8-9ad4-bbe0486fb8f5"), new DateTime(2020, 2, 27, 14, 17, 6, 977, DateTimeKind.Local).AddTicks(4300) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 14, 17, 6, 977, DateTimeKind.Local).AddTicks(4317), new Guid("0956de62-01c4-4c49-bf86-ba67b6d8e498"), new DateTime(2020, 2, 27, 14, 17, 6, 977, DateTimeKind.Local).AddTicks(4322) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 14, 17, 6, 977, DateTimeKind.Local).AddTicks(4338), new Guid("bbac2473-ac5b-42e2-bd85-5cf53d860d3f"), new DateTime(2020, 2, 27, 14, 17, 6, 977, DateTimeKind.Local).AddTicks(4343) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 14, 17, 6, 977, DateTimeKind.Local).AddTicks(4359), new Guid("6c58ef05-8bba-4ba3-a485-cacd0b233d1f"), new DateTime(2020, 2, 27, 14, 17, 6, 977, DateTimeKind.Local).AddTicks(4364) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 14, 17, 6, 977, DateTimeKind.Local).AddTicks(4380), new Guid("82025b2e-d09d-4b98-ad48-9706a981f335"), new DateTime(2020, 2, 27, 14, 17, 6, 977, DateTimeKind.Local).AddTicks(4384) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 14, 17, 6, 977, DateTimeKind.Local).AddTicks(4403), new Guid("10217421-d8b6-423a-ba26-8bb10d36e0a2"), new DateTime(2020, 2, 27, 14, 17, 6, 977, DateTimeKind.Local).AddTicks(4407) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 14, 17, 6, 977, DateTimeKind.Local).AddTicks(4423), new Guid("3c368114-f279-438f-82b4-8c99a35bd7e0"), new DateTime(2020, 2, 27, 14, 17, 6, 977, DateTimeKind.Local).AddTicks(4428) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 14, 17, 6, 977, DateTimeKind.Local).AddTicks(4449), new Guid("1f8db86d-c166-4c7e-97d7-5d49bd23927b"), new DateTime(2020, 2, 27, 14, 17, 6, 977, DateTimeKind.Local).AddTicks(4454) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 14, 17, 6, 977, DateTimeKind.Local).AddTicks(4470), new Guid("ea5df040-9384-43b5-bb72-808adc57af7a"), new DateTime(2020, 2, 27, 14, 17, 6, 977, DateTimeKind.Local).AddTicks(4474) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 14, 17, 6, 977, DateTimeKind.Local).AddTicks(4490), new Guid("684c5d8d-cbc9-4003-84a8-4fcccf3e53b3"), new DateTime(2020, 2, 27, 14, 17, 6, 977, DateTimeKind.Local).AddTicks(4495) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 14, 17, 6, 977, DateTimeKind.Local).AddTicks(4511), new Guid("d435bbfb-8169-4127-902f-a56fcbf7c111"), new DateTime(2020, 2, 27, 14, 17, 6, 977, DateTimeKind.Local).AddTicks(4516) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 14, 17, 6, 977, DateTimeKind.Local).AddTicks(4532), new Guid("c73da2f7-c2ac-4b26-8fc1-6897d4e51321"), new DateTime(2020, 2, 27, 14, 17, 6, 977, DateTimeKind.Local).AddTicks(4536) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 14, 17, 6, 977, DateTimeKind.Local).AddTicks(4552), new Guid("734eaa53-473d-4367-9dfd-57a53727b6d5"), new DateTime(2020, 2, 27, 14, 17, 6, 977, DateTimeKind.Local).AddTicks(4557) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 14, 17, 6, 977, DateTimeKind.Local).AddTicks(4573), new Guid("6ba8a0b7-e3a2-42ab-9144-cc1d297e6a58"), new DateTime(2020, 2, 27, 14, 17, 6, 977, DateTimeKind.Local).AddTicks(4577) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 14, 17, 6, 979, DateTimeKind.Local).AddTicks(4646), new Guid("10e23946-b462-4935-9c01-06da500db95a"), new DateTime(2020, 2, 27, 14, 17, 6, 979, DateTimeKind.Local).AddTicks(4651) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 14, 17, 6, 980, DateTimeKind.Local).AddTicks(4592), new Guid("901832ca-41b6-40e8-a783-8071037ffc36"), new DateTime(2020, 2, 27, 14, 17, 6, 980, DateTimeKind.Local).AddTicks(4598) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 14, 17, 6, 980, DateTimeKind.Local).AddTicks(4934), new Guid("a97c4048-89cb-4f7f-902f-601590df6f0c"), new DateTime(2020, 2, 27, 14, 17, 6, 980, DateTimeKind.Local).AddTicks(4939) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 14, 17, 6, 980, DateTimeKind.Local).AddTicks(5116), new Guid("98ac83ed-650a-416a-a46d-70fd35118716"), new DateTime(2020, 2, 27, 14, 17, 6, 980, DateTimeKind.Local).AddTicks(5121) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 14, 17, 6, 980, DateTimeKind.Local).AddTicks(5227), new Guid("f41ec33b-e85c-4978-bcc8-2fba719111bb"), new DateTime(2020, 2, 27, 14, 17, 6, 980, DateTimeKind.Local).AddTicks(5233) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 14, 17, 6, 980, DateTimeKind.Local).AddTicks(5347), new Guid("6d37215c-5b7c-4b23-a8ea-52a0516e02c1"), new DateTime(2020, 2, 27, 14, 17, 6, 980, DateTimeKind.Local).AddTicks(5352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 14, 17, 6, 980, DateTimeKind.Local).AddTicks(5457), new Guid("30d748ea-b3f9-42de-8842-e28fad27e274"), new DateTime(2020, 2, 27, 14, 17, 6, 980, DateTimeKind.Local).AddTicks(5462) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 14, 17, 6, 980, DateTimeKind.Local).AddTicks(5564), new Guid("42340200-6d28-4c20-ac3c-86d68be2f01e"), new DateTime(2020, 2, 27, 14, 17, 6, 980, DateTimeKind.Local).AddTicks(5569) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 14, 17, 6, 980, DateTimeKind.Local).AddTicks(5672), new Guid("b5a5bc49-77c7-486a-b175-5847c4feff1d"), new DateTime(2020, 2, 27, 14, 17, 6, 980, DateTimeKind.Local).AddTicks(5677) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 14, 17, 6, 980, DateTimeKind.Local).AddTicks(5794), new Guid("e7afbd13-57b7-49c3-af95-ad9bc6adf2d7"), new DateTime(2020, 2, 27, 14, 17, 6, 980, DateTimeKind.Local).AddTicks(5800) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 14, 17, 6, 980, DateTimeKind.Local).AddTicks(5905), new Guid("fc7b9d6f-018b-4f9c-bbb4-655722d401e6"), new DateTime(2020, 2, 27, 14, 17, 6, 980, DateTimeKind.Local).AddTicks(5910) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 14, 17, 6, 980, DateTimeKind.Local).AddTicks(6069), new Guid("fdaa271b-b274-4c84-8bee-086049fbb8b2"), new DateTime(2020, 2, 27, 14, 17, 6, 980, DateTimeKind.Local).AddTicks(6075) });
        }
    }
}
