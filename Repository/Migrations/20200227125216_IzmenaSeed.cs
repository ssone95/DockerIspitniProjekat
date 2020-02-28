using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class IzmenaSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

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
                columns: new[] { "CreatedAt", "Description", "Identifier", "Name", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 13, 52, 15, 396, DateTimeKind.Local).AddTicks(9519), "Phones", new Guid("17a3cc06-db02-4554-80c4-6c1125018145"), "Phones", new DateTime(2020, 2, 27, 13, 52, 15, 397, DateTimeKind.Local).AddTicks(894) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "Identifier", "Name", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 13, 52, 15, 397, DateTimeKind.Local).AddTicks(2443), "Masks", new Guid("80ae22ae-7cfc-4af8-add4-ddeecff0ec90"), "Masks", new DateTime(2020, 2, 27, 13, 52, 15, 397, DateTimeKind.Local).AddTicks(2485) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "Identifier", "Name", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 13, 52, 15, 397, DateTimeKind.Local).AddTicks(2533), "Chargers", new Guid("b4483d0b-4ae6-46a1-afcc-840b255a0a77"), "Chargers", new DateTime(2020, 2, 27, 13, 52, 15, 397, DateTimeKind.Local).AddTicks(2542) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "Identifier", "Name", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 13, 52, 15, 397, DateTimeKind.Local).AddTicks(2570), "Earphones", new Guid("161dbf0f-0993-4d9d-9eaf-9e5c59e7dda8"), "Earphones", new DateTime(2020, 2, 27, 13, 52, 15, 397, DateTimeKind.Local).AddTicks(2578) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "Identifier", "Name", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 13, 52, 15, 397, DateTimeKind.Local).AddTicks(2606), "Batteries", new Guid("7e344281-6dc5-48ca-9dc6-4cfad92ed496"), "Batteries", new DateTime(2020, 2, 27, 13, 52, 15, 397, DateTimeKind.Local).AddTicks(2614) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Description", "Identifier", "Name", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 13, 52, 15, 397, DateTimeKind.Local).AddTicks(4138), "Huawei", new Guid("8b44fa13-6800-4703-a65a-e032b070c02b"), "Huawei", new DateTime(2020, 2, 27, 13, 52, 15, 397, DateTimeKind.Local).AddTicks(4181) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description", "Identifier", "Name", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 13, 52, 15, 397, DateTimeKind.Local).AddTicks(4252), "LG", new Guid("7272e440-7479-4713-8863-6b86d6b989e6"), "LG", new DateTime(2020, 2, 27, 13, 52, 15, 397, DateTimeKind.Local).AddTicks(4262) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Description", "Identifier", "Name", "ParentProductTypeId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 13, 52, 15, 397, DateTimeKind.Local).AddTicks(4319), "Nokia", new Guid("6c0dd947-2027-4a88-8350-177eb2b53a7c"), "Nokia", 1, new DateTime(2020, 2, 27, 13, 52, 15, 397, DateTimeKind.Local).AddTicks(4328) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Description", "Identifier", "Name", "ParentProductTypeId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 13, 52, 15, 397, DateTimeKind.Local).AddTicks(4358), "Apple", new Guid("7c85a7c7-6cf6-4e49-b650-ecdcf5b9cf0d"), "Apple", 1, new DateTime(2020, 2, 27, 13, 52, 15, 397, DateTimeKind.Local).AddTicks(4368) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Description", "Identifier", "Name", "ParentProductTypeId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 13, 52, 15, 397, DateTimeKind.Local).AddTicks(4401), "Samsung", new Guid("f0585af8-15de-4e9e-9782-e9c9ee37115d"), "Samsung", 1, new DateTime(2020, 2, 27, 13, 52, 15, 397, DateTimeKind.Local).AddTicks(4410) });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Active", "CreatedAt", "Description", "Identifier", "Name", "ParentProductTypeId", "UpdatedAt" },
                values: new object[,]
                {
                    { 23, true, new DateTime(2020, 2, 27, 13, 52, 15, 397, DateTimeKind.Local).AddTicks(4882), "Xiaomi", new Guid("098461f3-3e8f-4585-9859-d8f134045f4d"), "Xiaomi", 4, new DateTime(2020, 2, 27, 13, 52, 15, 397, DateTimeKind.Local).AddTicks(4890) },
                    { 22, true, new DateTime(2020, 2, 27, 13, 52, 15, 397, DateTimeKind.Local).AddTicks(4846), "Samsung", new Guid("311a1e3a-d8c3-426d-b859-7f5d45d06e4f"), "Samsung", 4, new DateTime(2020, 2, 27, 13, 52, 15, 397, DateTimeKind.Local).AddTicks(4855) },
                    { 21, true, new DateTime(2020, 2, 27, 13, 52, 15, 397, DateTimeKind.Local).AddTicks(4811), "Apple", new Guid("f7cb870d-7a96-4db7-af34-bb7688c20d74"), "Apple", 4, new DateTime(2020, 2, 27, 13, 52, 15, 397, DateTimeKind.Local).AddTicks(4819) },
                    { 20, true, new DateTime(2020, 2, 27, 13, 52, 15, 397, DateTimeKind.Local).AddTicks(4775), "Nokia", new Guid("e2e6b02a-76bd-4258-a5c0-700bab2f3a65"), "Nokia", 4, new DateTime(2020, 2, 27, 13, 52, 15, 397, DateTimeKind.Local).AddTicks(4783) },
                    { 19, true, new DateTime(2020, 2, 27, 13, 52, 15, 397, DateTimeKind.Local).AddTicks(4738), "LG", new Guid("31fec34d-64d6-4cc9-a81e-ca6780c1b3ac"), "LG", 4, new DateTime(2020, 2, 27, 13, 52, 15, 397, DateTimeKind.Local).AddTicks(4747) },
                    { 18, true, new DateTime(2020, 2, 27, 13, 52, 15, 397, DateTimeKind.Local).AddTicks(4703), "Huawei", new Guid("50c3342d-163f-41a0-8b8b-db33fbcad439"), "Huawei", 4, new DateTime(2020, 2, 27, 13, 52, 15, 397, DateTimeKind.Local).AddTicks(4711) },
                    { 17, true, new DateTime(2020, 2, 27, 13, 52, 15, 397, DateTimeKind.Local).AddTicks(4667), "Xiaomi", new Guid("b41562a8-872e-48cf-a656-88aade6306bc"), "Xiaomi", 2, new DateTime(2020, 2, 27, 13, 52, 15, 397, DateTimeKind.Local).AddTicks(4675) },
                    { 16, true, new DateTime(2020, 2, 27, 13, 52, 15, 397, DateTimeKind.Local).AddTicks(4631), "Samsung", new Guid("bc830573-d98c-4df7-9c4b-ac383a1bbcee"), "Samsung", 2, new DateTime(2020, 2, 27, 13, 52, 15, 397, DateTimeKind.Local).AddTicks(4639) },
                    { 15, true, new DateTime(2020, 2, 27, 13, 52, 15, 397, DateTimeKind.Local).AddTicks(4586), "Apple", new Guid("e1aa7e70-818c-431e-b6e7-c8b70599d6bc"), "Apple", 2, new DateTime(2020, 2, 27, 13, 52, 15, 397, DateTimeKind.Local).AddTicks(4594) },
                    { 14, true, new DateTime(2020, 2, 27, 13, 52, 15, 397, DateTimeKind.Local).AddTicks(4549), "Nokia", new Guid("b8843413-f756-47d0-9efe-b11f561364ab"), "Nokia", 2, new DateTime(2020, 2, 27, 13, 52, 15, 397, DateTimeKind.Local).AddTicks(4558) },
                    { 13, true, new DateTime(2020, 2, 27, 13, 52, 15, 397, DateTimeKind.Local).AddTicks(4514), "LG", new Guid("53daaef2-b6ea-41cb-98b7-a4a1d3742696"), "LG", 2, new DateTime(2020, 2, 27, 13, 52, 15, 397, DateTimeKind.Local).AddTicks(4522) },
                    { 12, true, new DateTime(2020, 2, 27, 13, 52, 15, 397, DateTimeKind.Local).AddTicks(4479), "Huawei", new Guid("edfd1f39-5281-4e52-8a48-a0400e428162"), "Huawei", 2, new DateTime(2020, 2, 27, 13, 52, 15, 397, DateTimeKind.Local).AddTicks(4487) },
                    { 11, true, new DateTime(2020, 2, 27, 13, 52, 15, 397, DateTimeKind.Local).AddTicks(4441), "Xiaomi", new Guid("3db8bdf6-48c7-4780-ab1e-d93005f60cb4"), "Xiaomi", 1, new DateTime(2020, 2, 27, 13, 52, 15, 397, DateTimeKind.Local).AddTicks(4451) }
                });

            migrationBuilder.InsertData(
                table: "Product_ProductType",
                columns: new[] { "ProductId", "ProductTypeId" },
                values: new object[] { 2, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "Identifier", "Name", "Price", "Tags", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 13, 52, 15, 401, DateTimeKind.Local).AddTicks(8247), @"
                        <table class=MsoNormalTable border=0 cellspacing=0 cellpadding=0 width=""100%""
                         style='width:100.0%;mso-cellspacing:0cm;mso-yfti-tbllook:1184;mso-padding-alt:
                         0cm 0cm 0cm 0cm'>
                         <tr style='mso-yfti-irow:0;mso-yfti-firstrow:yes'>
                          <td width=""15%"" rowspan=2 valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Model<o:p></o:p></span></b></p>
                          </td>
                          <td width=""15%"" valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Naziv<o:p></o:p></span></p>
                          </td>
                          <td width=""70%"" valign=top style='width:70.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Huawei P30 Lite Dual SIM 128GB 4GB
                          RAM (plava)</span></b><span lang=EN-US style='font-size:12.0pt;font-family:
                          ""Times New Roman"",serif;mso-fareast-font-family:""Times New Roman""'><o:p></o:p></span></p>
                          </td>
                         </tr>
                         <tr style='mso-yfti-irow:1'>
                          <td width=""15%"" valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Poznat kao<o:p></o:p></span></p>
                          </td>
                          <td width=""70%"" valign=top style='width:70.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>MAR-LX1A</span></b><span
                          lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'><o:p></o:p></span></p>
                          </td>
                         </tr>
                         <tr style='mso-yfti-irow:2'>
                          <td width=""15%"" rowspan=5 valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Osnovno<o:p></o:p></span></b></p>
                          </td>
                          <td width=""15%"" valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Market<o:p></o:p></span></p>
                          </td>
                          <td width=""70%"" valign=top style='width:70.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Mreže:</span></b><span lang=EN-US
                          style='font-size:12.0pt;font-family:""Times New Roman"",serif;mso-fareast-font-family:
                          ""Times New Roman""'> 850Mhz, 900Mhz, 1800Mhz, 1900Mhz, 2100Mhz, 2600Mhz,
                          HSDPA, LTE<o:p></o:p></span></p>
                          </td>
                         </tr>
                         <tr style='mso-yfti-irow:3'>
                          <td width=""15%"" valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Kućište<o:p></o:p></span></p>
                          </td>
                          <td width=""70%"" valign=top style='width:70.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Dimenzije:</span></b><span
                          lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'> 152.9 x 72.7 x 7.4 mm<o:p></o:p></span></p>
                          </td>
                         </tr>
                         <tr style='mso-yfti-irow:4'>
                          <td width=""15%"" valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Procesor<o:p></o:p></span></p>
                          </td>
                          <td width=""70%"" valign=top style='width:70.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Tip:</span></b><span lang=EN-US
                          style='font-size:12.0pt;font-family:""Times New Roman"",serif;mso-fareast-font-family:
                          ""Times New Roman""'> Octa-core, Hisilicon Kirin 710, Mali-G51 MP4<br>
                          <b>Takt:</b> Quad-core 2.2 GHz Cortex-A73 &amp; Quad-core 1.7 GHz Cortex-A53<o:p></o:p></span></p>
                          </td>
                         </tr>
                         <tr style='mso-yfti-irow:5'>
                          <td width=""15%"" valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Baterija<o:p></o:p></span></p>
                          </td>
                          <td width=""70%"" valign=top style='width:70.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Vrsta:</span></b><span lang=EN-US
                          style='font-size:12.0pt;font-family:""Times New Roman"",serif;mso-fareast-font-family:
                          ""Times New Roman""'> Li-Po (baterija nije zamenjiva bez asistencije servisa)<br>
                          <b>Kapacitet:</b> 3340 mAh<br>
                          <b>Režim razgovora:</b> do 22 h (3G)<br>
                          <b>Stand by režim:</b> do 595 h (3G)<o:p></o:p></span></p>
                          </td>
                         </tr>
                         <tr style='mso-yfti-irow:6'>
                          <td width=""15%"" valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Ostalo<o:p></o:p></span></p>
                          </td>
                          <td width=""70%"" valign=top style='width:70.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Ostalo:</span></b><span
                          lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'> dual sim, vibracija, senzor
                          otisak prsta, digitalni kompas, akcelerometar, Gyroscope<o:p></o:p></span></p>
                          </td>
                         </tr>
                         <tr style='mso-yfti-irow:7'>
                          <td width=""15%"" valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Ekran<o:p></o:p></span></b></p>
                          </td>
                          <td width=""15%"" valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Glavni<o:p></o:p></span></p>
                          </td>
                          <td width=""70%"" valign=top style='width:70.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Tip:</span></b><span lang=EN-US
                          style='font-size:12.0pt;font-family:""Times New Roman"",serif;mso-fareast-font-family:
                          ""Times New Roman""'> LTPS IPS LCD (6.15 inča) capacitive<br>
                          <b>Broj boja:</b> (24-bit) 16.777.216 boja<br>
                          <b>Rezolucija:</b> 1080x2312 piksela<br>
                          <b>Ostalo:</b> osetljiv na dodir, sposobnost dodira ekrana da registruje više
                          različitih pozicija, EMUI 9.0<o:p></o:p></span></p>
                          </td>
                         </tr>
                         <tr style='mso-yfti-irow:8'>
                          <td width=""15%"" rowspan=2 valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Kamera<o:p></o:p></span></b></p>
                          </td>
                          <td width=""15%"" valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Glavna<o:p></o:p></span></p>
                          </td>
                          <td width=""70%"" valign=top style='width:70.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Orijentacija sočiva:</span></b><span
                          lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'> sa zadnje strane<br>
                          <b>Broj piksela senzora:</b> 48 MP (f1.8, wide, PDAF) + 8 MP (13mm ultrawide)
                          + 2 MP (f/2.4, depth sensor)<br>
                          <b>Rezolucija fotografija:</b> 5290x4512 piksela<br>
                          <b>Rezolucija videa:</b> 1080p@30fps (gyro-EIS)<br>
                          <b>Ostalo:</b> video zapis, LED blic, digitalni zoom, automatsko označavanje
                          lokacije, detekcija lica, HDR, panorama mod<o:p></o:p></span></p>
                          </td>
                         </tr>
                         <tr style='mso-yfti-irow:9'>
                          <td width=""15%"" valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Pomoćna<o:p></o:p></span></p>
                          </td>
                          <td width=""70%"" valign=top style='width:70.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Orijentacija sočiva:</span></b><span
                          lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'> sa prednje strane<br>
                          <b>Broj piksela senzora:</b> 24 megapiksela<br>
                          <b>Rezolucija videa:</b> 1080p@30fps<br>
                          <b>Ostalo:</b> f/2.0, HDR<o:p></o:p></span></p>
                          </td>
                         </tr>
                         <tr style='mso-yfti-irow:10'>
                          <td width=""15%"" valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Zvuk<o:p></o:p></span></b></p>
                          </td>
                          <td width=""15%"" valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Reprodukcija<o:p></o:p></span></p>
                          </td>
                          <td width=""70%"" valign=top style='width:70.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Zvučnici:</span></b><span
                          lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'> mono zvučnik sa ugrađenim
                          pojačalom<br>
                          <b>Melodije:</b> polifone<br>
                          <b>Format melodija:</b> mp3, aac, aac+, eaac+, flac, wav, ogg, midi, amr<br>
                          <b>Ostalo:</b> spikerfon, specijalan mikrofon za smanjenje buke<o:p></o:p></span></p>
                          </td>
                         </tr>
                         <tr style='mso-yfti-irow:11'>
                          <td width=""15%"" rowspan=2 valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Memorija<o:p></o:p></span></b></p>
                          </td>
                          <td width=""15%"" valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Interna<o:p></o:p></span></p>
                          </td>
                          <td width=""70%"" valign=top style='width:70.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Kapacitet:</span></b><span
                          lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'> 128 GB (4 GB RAM)<o:p></o:p></span></p>
                          </td>
                         </tr>
                         <tr style='mso-yfti-irow:12'>
                          <td width=""15%"" valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Eksterna<o:p></o:p></span></p>
                          </td>
                          <td width=""70%"" valign=top style='width:70.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Formati:</span></b><span
                          lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'> microSD (Trans Flash),Maximalno
                          podržano : 512 GB (shared SIM slot)<br>
                          <b>Uz aparat:</b> ne ide kartica<o:p></o:p></span></p>
                          </td>
                         </tr>
                         <tr style='mso-yfti-irow:13'>
                          <td width=""15%"" rowspan=3 valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Softver<o:p></o:p></span></b></p>
                          </td>
                          <td width=""15%"" valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Operativni <br>
                          sistem<o:p></o:p></span></p>
                          </td>
                          <td width=""70%"" valign=top style='width:70.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Tip:</span></b><span lang=EN-US
                          style='font-size:12.0pt;font-family:""Times New Roman"",serif;mso-fareast-font-family:
                          ""Times New Roman""'> Android OS<br>
                          <b>Verzija:</b> v9.0 (Pie)<br>
                          <b>Formati:</b> mpeg4, H.263, H.264, xvid, wmv<o:p></o:p></span></p>
                          </td>
                         </tr>
                         <tr style='mso-yfti-irow:14'>
                          <td width=""15%"" valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Java<o:p></o:p></span></p>
                          </td>
                          <td width=""70%"" valign=top style='width:70.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Profil:</span></b><span
                          lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'> ne<br>
                          <b>Konfiguracija:</b> podržava isključivo Nano SIM karticu, čitač dokumenata<o:p></o:p></span></p>
                          </td>
                         </tr>
                         <tr style='mso-yfti-irow:15'>
                          <td width=""15%"" valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Funkcije<o:p></o:p></span></p>
                          </td>
                          <td width=""70%"" valign=top style='width:70.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Osnovne:</span></b><span
                          lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'> kalkulator, kalendar, alarm,
                          digitalni sat, notes, podsetnik, štoperica<br>
                          <b>Napredne:</b> komandovanje glasom, pozivanje glasom, snimanje glasa<o:p></o:p></span></p>
                          </td>
                         </tr>
                         <tr style='mso-yfti-irow:16'>
                          <td width=""15%"" valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Komunikacija<o:p></o:p></span></b></p>
                          </td>
                          <td width=""15%"" valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Udaljeno<o:p></o:p></span></p>
                          </td>
                          <td width=""70%"" valign=top style='width:70.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Prenos podataka:</span></b><span
                          lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'> GSM (9,6 Kb/s), GPRS (115 Kb/s),
                          EDGE (236 Kb/s), HSDPA, LTE<br>
                          <b>WAP pretraživač:</b> HTML5<br>
                          <b>Email protokoli:</b> IMAP, POP3, SMTP, Microsoft Exchange<br>
                          <b>Ostalo:</b> SMS, MMS, Email, Push Mail, IM<o:p></o:p></span></p>
                          </td>
                         </tr>
                         <tr style='mso-yfti-irow:17;mso-yfti-lastrow:yes'>
                          <td width=""15%"" valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Povezivanje<o:p></o:p></span></b></p>
                          </td>
                          <td width=""15%"" valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Podržane <br>
                          tehnologije<o:p></o:p></span></p>
                          </td>
                          <td width=""70%"" valign=top style='width:70.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>GPRS:</span></b><span lang=EN-US
                          style='font-size:12.0pt;font-family:""Times New Roman"",serif;mso-fareast-font-family:
                          ""Times New Roman""'> da<br>
                          <b>EDGE:</b> da<br>
                          <b>3G:</b> da, HSDPA, 42 Mbps; HSUPA, 5.76 Mbps; LTE, Cat6, 50 Mbps UL, 300
                          Mbps DL<br>
                          <b>WLAN:</b> da, Wi-Fi 802.11 a/b/g/n/ac, dual-band, Wi-Fi hotspot, Wi-Fi
                          Direct<br>
                          <b>Bluetooth:</b> da, v4.2 sa A2DP, LE, aptX HD<br>
                          <b>USB i spikerfon:</b> da, microUSB v2.0 (Type-C 1.0 reversible connector),
                          3.5' audio<br>
                          <b>GPS:</b> da, sa A-GPS podrškom i GLONASS, BDS<o:p></o:p></span></p>
                          </td>
                         </tr>
                        </table>", new Guid("722de11b-bdf9-4964-92d7-ad3ff467bd33"), "Huawei P30 Lite Dual SIM 128GB 4GB RAM", 500m, "Phones;Huawei;P30;Lite;", new DateTime(2020, 2, 27, 13, 52, 15, 401, DateTimeKind.Local).AddTicks(8257) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "Discount", "Identifier", "Name", "Price", "Tags", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 13, 52, 15, 403, DateTimeKind.Local).AddTicks(9860), @"
                        <table class=MsoNormalTable border=0 cellspacing=0 cellpadding=0 width=""100%""
                         style='width:100.0%;mso-cellspacing:0cm;mso-yfti-tbllook:1184;mso-padding-alt:
                         0cm 0cm 0cm 0cm'>
                         <tr style='mso-yfti-irow:0;mso-yfti-firstrow:yes'>
                          <td width=""15%"" rowspan=2 valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Model<o:p></o:p></span></b></p>
                          </td>
                          <td width=""15%"" valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Naziv<o:p></o:p></span></p>
                          </td>
                          <td width=""70%"" valign=top style='width:70.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Huawei P20 Dual SIM 64GB 4GB RAM
                          (twilight plava)</span></b><span lang=EN-US style='font-size:12.0pt;
                          font-family:""Times New Roman"",serif;mso-fareast-font-family:""Times New Roman""'><o:p></o:p></span></p>
                          </td>
                         </tr>
                         <tr style='mso-yfti-irow:1'>
                          <td width=""15%"" valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Poznat kao<o:p></o:p></span></p>
                          </td>
                          <td width=""70%"" valign=top style='width:70.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>EML-L29, EML-L09</span></b><span
                          lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'><o:p></o:p></span></p>
                          </td>
                         </tr>
                         <tr style='mso-yfti-irow:2'>
                          <td width=""15%"" rowspan=5 valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Osnovno<o:p></o:p></span></b></p>
                          </td>
                          <td width=""15%"" valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Market<o:p></o:p></span></p>
                          </td>
                          <td width=""70%"" valign=top style='width:70.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Mreže:</span></b><span lang=EN-US
                          style='font-size:12.0pt;font-family:""Times New Roman"",serif;mso-fareast-font-family:
                          ""Times New Roman""'> 850Mhz, 900Mhz, 1800Mhz, 1900Mhz, 2100Mhz, 2600Mhz,
                          HSDPA, LTE<o:p></o:p></span></p>
                          </td>
                         </tr>
                         <tr style='mso-yfti-irow:3'>
                          <td width=""15%"" valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Kućište<o:p></o:p></span></p>
                          </td>
                          <td width=""70%"" valign=top style='width:70.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Dimenzije:</span></b><span
                          lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'> 149.1 x 70.8 x 7.7 mm<o:p></o:p></span></p>
                          </td>
                         </tr>
                         <tr style='mso-yfti-irow:4'>
                          <td width=""15%"" valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Procesor<o:p></o:p></span></p>
                          </td>
                          <td width=""70%"" valign=top style='width:70.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Tip:</span></b><span lang=EN-US
                          style='font-size:12.0pt;font-family:""Times New Roman"",serif;mso-fareast-font-family:
                          ""Times New Roman""'> Octa-core, HiSilicon Kirin 970, Mali-G72 MP12<br>
                          <b>Takt:</b> Quad-core 2.4 GHz Cortex-A73 &amp; quad-core 1.8 GHz Cortex-A53 <o:p></o:p></span></p>
                          </td>
                         </tr>
                         <tr style='mso-yfti-irow:5'>
                          <td width=""15%"" valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Baterija<o:p></o:p></span></p>
                          </td>
                          <td width=""70%"" valign=top style='width:70.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Vrsta:</span></b><span lang=EN-US
                          style='font-size:12.0pt;font-family:""Times New Roman"",serif;mso-fareast-font-family:
                          ""Times New Roman""'> Li-Ion (baterija nije zamenjiva bez asistencije servisa)<br>
                          <b>Kapacitet:</b> 3400 mAh<br>
                          <b>Režim razgovora:</b> do 20 h (3G)<br>
                          <b>Stand by režim:</b> do 585 h (3G)<o:p></o:p></span></p>
                          </td>
                         </tr>
                         <tr style='mso-yfti-irow:6'>
                          <td width=""15%"" valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Ostalo<o:p></o:p></span></p>
                          </td>
                          <td width=""70%"" valign=top style='width:70.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Ostalo:</span></b><span
                          lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'> dual sim, vibracija, senzor
                          otisak prsta, digitalni kompas, akcelerometar, Gyroscope <o:p></o:p></span></p>
                          </td>
                         </tr>
                         <tr style='mso-yfti-irow:7'>
                          <td width=""15%"" valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Ekran<o:p></o:p></span></b></p>
                          </td>
                          <td width=""15%"" valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Glavni<o:p></o:p></span></p>
                          </td>
                          <td width=""70%"" valign=top style='width:70.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Tip:</span></b><span lang=EN-US
                          style='font-size:12.0pt;font-family:""Times New Roman"",serif;mso-fareast-font-family:
                          ""Times New Roman""'> LTPS IPS LCD (5.8 inča) capacitive<br>
                          <b>Broj boja:</b> (24-bit) 16.777.216 boja<br>
                          <b>Rezolucija:</b> 1080x2240 piksela<br>
                          <b>Ostalo:</b> osetljiv na dodir, sposobnost dodira ekrana da registruje više
                          različitih pozicija, Emotion UI 8.1 <o:p></o:p></span></p>
                          </td>
                         </tr>
                         <tr style='mso-yfti-irow:8'>
                          <td width=""15%"" rowspan=2 valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Kamera<o:p></o:p></span></b></p>
                          </td>
                          <td width=""15%"" valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Glavna<o:p></o:p></span></p>
                          </td>
                          <td width=""70%"" valign=top style='width:70.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Orijentacija sočiva:</span></b><span
                          lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'> sa zadnje strane<br>
                          <b>Broj piksela senzora:</b> Dual kamera 12 MP (f/1.8, OIS) + 20 MP (f/1.6,
                          27mm)<br>
                          <b>Rezolucija fotografija:</b> 4096x3080 piksela<br>
                          <b>Rezolucija videa:</b> 2160p@30fps, 1080p@60fps, 720p@960fps<br>
                          <b>Ostalo:</b> video zapis, laser i phase detectzija autofokus, LED blic, digitalni
                          zoom, automatsko označavanje lokacije, detekcija lica, HDR, panorama mod <o:p></o:p></span></p>
                          </td>
                         </tr>
                         <tr style='mso-yfti-irow:9'>
                          <td width=""15%"" valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Pomoćna<o:p></o:p></span></p>
                          </td>
                          <td width=""70%"" valign=top style='width:70.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Orijentacija sočiva:</span></b><span
                          lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'> sa prednje strane<br>
                          <b>Broj piksela senzora:</b> 24 megapiksela<br>
                          <b>Rezolucija videa:</b> 1080p@30fps<br>
                          <b>Ostalo:</b> f/2.0 <o:p></o:p></span></p>
                          </td>
                         </tr>
                         <tr style='mso-yfti-irow:10'>
                          <td width=""15%"" valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Zvuk<o:p></o:p></span></b></p>
                          </td>
                          <td width=""15%"" valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Reprodukcija<o:p></o:p></span></p>
                          </td>
                          <td width=""70%"" valign=top style='width:70.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Zvučnici:</span></b><span
                          lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'> mono zvučnik sa ugrađenim
                          pojačalom 24-bit/192kHz audio<br>
                          <b>Melodije:</b> polifone<br>
                          <b>Format melodija:</b> mp3, aac, aac+, eaac+, flac, wav, ogg, midi, amr<br>
                          <b>Ostalo:</b> spikerfon, specijalan mikrofon za smanjenje buke <o:p></o:p></span></p>
                          </td>
                         </tr>
                         <tr style='mso-yfti-irow:11'>
                          <td width=""15%"" rowspan=2 valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Memorija<o:p></o:p></span></b></p>
                          </td>
                          <td width=""15%"" valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Interna<o:p></o:p></span></p>
                          </td>
                          <td width=""70%"" valign=top style='width:70.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Kapacitet:</span></b><span
                          lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'> 64 GB (4 GB RAM)<o:p></o:p></span></p>
                          </td>
                         </tr>
                         <tr style='mso-yfti-irow:12'>
                          <td width=""15%"" valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Eksterna<o:p></o:p></span></p>
                          </td>
                          <td width=""70%"" valign=top style='width:70.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Formati:</span></b><span
                          lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'> nema opciju za memorijsku karticu<br>
                          <b>Uz aparat:</b> ne ide kartica<o:p></o:p></span></p>
                          </td>
                         </tr>
                         <tr style='mso-yfti-irow:13'>
                          <td width=""15%"" rowspan=3 valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Softver<o:p></o:p></span></b></p>
                          </td>
                          <td width=""15%"" valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Operativni <br>
                          sistem<o:p></o:p></span></p>
                          </td>
                          <td width=""70%"" valign=top style='width:70.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Tip:</span></b><span lang=EN-US
                          style='font-size:12.0pt;font-family:""Times New Roman"",serif;mso-fareast-font-family:
                          ""Times New Roman""'> Android OS<br>
                          <b>Verzija:</b> v8.1 (Oreo)<br>
                          <b>Formati:</b> mpeg4, H.263, H.264, xvid, wmv <o:p></o:p></span></p>
                          </td>
                         </tr>
                         <tr style='mso-yfti-irow:14'>
                          <td width=""15%"" valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Java<o:p></o:p></span></p>
                          </td>
                          <td width=""70%"" valign=top style='width:70.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Profil:</span></b><span
                          lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'> ne<br>
                          <b>Konfiguracija:</b> podržava isključivo Nano SIM karticu, čitač dokumenata,
                          NFC podrška <o:p></o:p></span></p>
                          </td>
                         </tr>
                         <tr style='mso-yfti-irow:15'>
                          <td width=""15%"" valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Funkcije<o:p></o:p></span></p>
                          </td>
                          <td width=""70%"" valign=top style='width:70.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Osnovne:</span></b><span
                          lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'> kalkulator, kalendar, alarm,
                          digitalni sat, notes, podsetnik, štoperica<br>
                          <b>Napredne:</b> komandovanje glasom, pozivanje glasom, snimanje glasa <o:p></o:p></span></p>
                          </td>
                         </tr>
                         <tr style='mso-yfti-irow:16'>
                          <td width=""15%"" valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Komunikacija<o:p></o:p></span></b></p>
                          </td>
                          <td width=""15%"" valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Udaljeno<o:p></o:p></span></p>
                          </td>
                          <td width=""70%"" valign=top style='width:70.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Prenos podataka:</span></b><span
                          lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'> GSM (9,6 Kb/s), GPRS (115 Kb/s),
                          EDGE (236 Kb/s), HSDPA, LTE<br>
                          <b>WAP pretraživač:</b> HTML5<br>
                          <b>Email protokoli:</b> IMAP, POP3, SMTP, Microsoft Exchange<br>
                          <b>Ostalo:</b> SMS, MMS, Email, Push Mail, IM <o:p></o:p></span></p>
                          </td>
                         </tr>
                         <tr style='mso-yfti-irow:17;mso-yfti-lastrow:yes'>
                          <td width=""15%"" valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Povezivanje<o:p></o:p></span></b></p>
                          </td>
                          <td width=""15%"" valign=top style='width:15.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>Podržane <br>
                          tehnologije<o:p></o:p></span></p>
                          </td>
                          <td width=""70%"" valign=top style='width:70.0%;padding:0cm 0cm 0cm 0cm'>
                          <p class=MsoNormal style='margin-bottom:0cm;margin-bottom:.0001pt;line-height:
                          normal'><b><span lang=EN-US style='font-size:12.0pt;font-family:""Times New Roman"",serif;
                          mso-fareast-font-family:""Times New Roman""'>GPRS:</span></b><span lang=EN-US
                          style='font-size:12.0pt;font-family:""Times New Roman"",serif;mso-fareast-font-family:
                          ""Times New Roman""'> da<br>
                          <b>EDGE:</b> da<br>
                          <b>3G:</b> da, HSDPA, 42 Mbps; HSUPA, 5.76 Mbps; LTE, Cat6, 50 Mbps UL, 300
                          Mbps DL<br>
                          <b>WLAN:</b> da, Wi-Fi 802.11 a/b/g/n/ac, dual-band, Wi-Fi hotspot, Wi-Fi
                          Direct<br>
                          <b>Bluetooth:</b> da, v4.2 sa A2DP, EDR, LE<br>
                          <b>USB i spikerfon:</b> da, microUSB 3.1 (Type-C 1.0 Reversible), nema ulaz
                          3.5' audio<br>
                          <b>GPS:</b> da, sa A-GPS podrškom i GLONASS <o:p></o:p></span></p>
                          </td>
                         </tr>
                        </table>", 0, new Guid("04f30d76-22a1-4148-84c8-6f9739d37f5b"), "Huawei P20 Dual SIM 64GB 4GB RAM", 309m, "Phones;Huawei;P20;Dual-Sim;", new DateTime(2020, 2, 27, 13, 52, 15, 403, DateTimeKind.Local).AddTicks(9871) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductPhotos",
                keyColumns: new[] { "ProductId", "PhotoPath" },
                keyValues: new object[] { 1, "/photos/phones/huawei/Huawei_P30_Lite_Blue_Front.jpg" });

            migrationBuilder.DeleteData(
                table: "ProductPhotos",
                keyColumns: new[] { "ProductId", "PhotoPath" },
                keyValues: new object[] { 2, "/photos/phones/huawei/Huawei_P20_Twilight_Front.jpg" });

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Product_ProductType",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "Identifier", "Name", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 12, 35, 58, 364, DateTimeKind.Local).AddTicks(2770), "Opis vrste 1", new Guid("3c68c977-546d-4834-8499-21fc31b52034"), "Vrsta 1", new DateTime(2020, 2, 27, 12, 35, 58, 364, DateTimeKind.Local).AddTicks(3383) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "Identifier", "Name", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 12, 35, 58, 364, DateTimeKind.Local).AddTicks(4198), "Opis vrste 2", new Guid("b84db2de-0394-4600-9afd-72433628e8c7"), "Vrsta 2", new DateTime(2020, 2, 27, 12, 35, 58, 364, DateTimeKind.Local).AddTicks(4218) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "Identifier", "Name", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 12, 35, 58, 364, DateTimeKind.Local).AddTicks(4238), "Opis vrste 3", new Guid("a2db4b86-0128-4c3b-b189-54a7377fc8b3"), "Vrsta 3", new DateTime(2020, 2, 27, 12, 35, 58, 364, DateTimeKind.Local).AddTicks(4241) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "Identifier", "Name", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 12, 35, 58, 364, DateTimeKind.Local).AddTicks(4252), "Opis vrste 4", new Guid("8faa0aa5-b2a7-419d-bd32-9d6248caee62"), "Vrsta 4", new DateTime(2020, 2, 27, 12, 35, 58, 364, DateTimeKind.Local).AddTicks(4255) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "Identifier", "Name", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 12, 35, 58, 364, DateTimeKind.Local).AddTicks(4265), "Opis vrste 5", new Guid("4319937e-baef-4930-bd85-a37c8f700e2b"), "Vrsta 5", new DateTime(2020, 2, 27, 12, 35, 58, 364, DateTimeKind.Local).AddTicks(4269) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Description", "Identifier", "Name", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 12, 35, 58, 364, DateTimeKind.Local).AddTicks(4933), "Opis Pod vrste 1", new Guid("d2a9e796-c9ce-4c89-a0fa-5a41c6b01aab"), "Pod Vrsta 1", new DateTime(2020, 2, 27, 12, 35, 58, 364, DateTimeKind.Local).AddTicks(4949) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description", "Identifier", "Name", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 12, 35, 58, 364, DateTimeKind.Local).AddTicks(4978), "Opis Pod vrste 2", new Guid("ec86c6da-c5f1-45b6-8984-ee705ea1b75f"), "Pod Vrsta 2", new DateTime(2020, 2, 27, 12, 35, 58, 364, DateTimeKind.Local).AddTicks(4982) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Description", "Identifier", "Name", "ParentProductTypeId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 12, 35, 58, 364, DateTimeKind.Local).AddTicks(4993), "Opis Pod vrste 3", new Guid("1c21e5dc-ff2d-4d87-a68d-9730e569a6b6"), "Pod Vrsta 3", 2, new DateTime(2020, 2, 27, 12, 35, 58, 364, DateTimeKind.Local).AddTicks(4996) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Description", "Identifier", "Name", "ParentProductTypeId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 12, 35, 58, 364, DateTimeKind.Local).AddTicks(5007), "Opis Pod vrste 4", new Guid("815315c2-c280-4b45-94b6-a5cf200c7c87"), "Pod Vrsta 4", 2, new DateTime(2020, 2, 27, 12, 35, 58, 364, DateTimeKind.Local).AddTicks(5010) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Description", "Identifier", "Name", "ParentProductTypeId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 12, 35, 58, 364, DateTimeKind.Local).AddTicks(5021), "Opis Pod vrste 5", new Guid("d94426d3-fca3-4cbc-bbf5-a4e0335126b5"), "Pod Vrsta 5", 3, new DateTime(2020, 2, 27, 12, 35, 58, 364, DateTimeKind.Local).AddTicks(5024) });

            migrationBuilder.InsertData(
                table: "Product_ProductType",
                columns: new[] { "ProductId", "ProductTypeId" },
                values: new object[,]
                {
                    { 1, 10 },
                    { 1, 7 },
                    { 2, 8 },
                    { 2, 9 }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "Identifier", "Name", "Price", "Tags", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 12, 35, 58, 366, DateTimeKind.Local).AddTicks(293), "Opis 1", new Guid("396cab4c-15a2-4bac-a9b9-250c41e8fe5a"), "Artikal 1", 100m, "Artikal;test;Nesto;Nesto 2;Proba;", new DateTime(2020, 2, 27, 12, 35, 58, 366, DateTimeKind.Local).AddTicks(296) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "Discount", "Identifier", "Name", "Price", "Tags", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 12, 35, 58, 366, DateTimeKind.Local).AddTicks(3148), "<i><b>Opis</b></i> 2", 1, new Guid("f14479e5-bd5b-44c6-8574-b093f77dff83"), "Artikal 2", 100m, "Artikal;test;Nesto;Nesto 2;Proba;", new DateTime(2020, 2, 27, 12, 35, 58, 366, DateTimeKind.Local).AddTicks(3152) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Active", "CreatedAt", "Description", "Discount", "Identifier", "Name", "Price", "Tags", "UpdatedAt" },
                values: new object[] { 3, true, new DateTime(2020, 2, 27, 12, 35, 58, 366, DateTimeKind.Local).AddTicks(3261), "Opis 2", 1, new Guid("d6dbd2f3-6af5-4b73-8315-989f8f23ec20"), "Artikal 2", 100m, "Artikal;test;Nesto;Nesto 2;Proba;", new DateTime(2020, 2, 27, 12, 35, 58, 366, DateTimeKind.Local).AddTicks(3264) });

            migrationBuilder.InsertData(
                table: "Product_ProductType",
                columns: new[] { "ProductId", "ProductTypeId" },
                values: new object[,]
                {
                    { 3, 9 },
                    { 3, 2 },
                    { 3, 10 }
                });
        }
    }
}
