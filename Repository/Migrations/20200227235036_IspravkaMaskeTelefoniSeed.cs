using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class IspravkaMaskeTelefoniSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product_ProductType",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 10, 9 });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 28, 0, 50, 35, 776, DateTimeKind.Local).AddTicks(1753), new Guid("b3f08ee2-a8d5-4eba-8ec7-4ba4b6ec7e19"), new DateTime(2020, 2, 28, 0, 50, 35, 776, DateTimeKind.Local).AddTicks(2390) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 28, 0, 50, 35, 776, DateTimeKind.Local).AddTicks(3069), new Guid("e68da03f-6630-4d19-a9bf-47c6e9cfff14"), new DateTime(2020, 2, 28, 0, 50, 35, 776, DateTimeKind.Local).AddTicks(3091) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 28, 0, 50, 35, 776, DateTimeKind.Local).AddTicks(3109), new Guid("ca5c96aa-ea1a-4ecd-ac59-40f725062d12"), new DateTime(2020, 2, 28, 0, 50, 35, 776, DateTimeKind.Local).AddTicks(3112) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 28, 0, 50, 35, 776, DateTimeKind.Local).AddTicks(3199), new Guid("32d2c3e2-3501-4a2a-a38b-b15aa87ac6d8"), new DateTime(2020, 2, 28, 0, 50, 35, 776, DateTimeKind.Local).AddTicks(3202) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 28, 0, 50, 35, 776, DateTimeKind.Local).AddTicks(3214), new Guid("3e7fd08b-ac71-455c-84f7-4398ba02ea0c"), new DateTime(2020, 2, 28, 0, 50, 35, 776, DateTimeKind.Local).AddTicks(3218) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 28, 0, 50, 35, 776, DateTimeKind.Local).AddTicks(3827), new Guid("0cdb700a-1ac4-4ebe-8240-21de3b18e3a1"), new DateTime(2020, 2, 28, 0, 50, 35, 776, DateTimeKind.Local).AddTicks(3842) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 28, 0, 50, 35, 776, DateTimeKind.Local).AddTicks(3871), new Guid("43eced6e-08a3-4e65-a316-dd6e535ae089"), new DateTime(2020, 2, 28, 0, 50, 35, 776, DateTimeKind.Local).AddTicks(3874) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 28, 0, 50, 35, 776, DateTimeKind.Local).AddTicks(3900), new Guid("508f3a11-3a99-4855-a880-270d35bf197b"), new DateTime(2020, 2, 28, 0, 50, 35, 776, DateTimeKind.Local).AddTicks(3904) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 28, 0, 50, 35, 776, DateTimeKind.Local).AddTicks(3915), new Guid("53a8f98b-b5cc-46e5-a059-68b594acba02"), new DateTime(2020, 2, 28, 0, 50, 35, 776, DateTimeKind.Local).AddTicks(3918) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 28, 0, 50, 35, 776, DateTimeKind.Local).AddTicks(3929), new Guid("671a3465-1de7-41e3-9755-959a535cc57b"), new DateTime(2020, 2, 28, 0, 50, 35, 776, DateTimeKind.Local).AddTicks(3933) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 28, 0, 50, 35, 776, DateTimeKind.Local).AddTicks(3944), new Guid("192a0a6a-f55f-44b5-8f7d-9462928aaf95"), new DateTime(2020, 2, 28, 0, 50, 35, 776, DateTimeKind.Local).AddTicks(3947) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 28, 0, 50, 35, 776, DateTimeKind.Local).AddTicks(3958), new Guid("75782445-cec9-46ce-b257-68b44e5d7d8d"), new DateTime(2020, 2, 28, 0, 50, 35, 776, DateTimeKind.Local).AddTicks(3961) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 28, 0, 50, 35, 776, DateTimeKind.Local).AddTicks(3972), new Guid("61761953-5d70-4202-b8e3-da7acbbb1b04"), new DateTime(2020, 2, 28, 0, 50, 35, 776, DateTimeKind.Local).AddTicks(3975) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 28, 0, 50, 35, 776, DateTimeKind.Local).AddTicks(3986), new Guid("0e5f5fe9-0a59-4259-bcb3-8bba395ee81d"), new DateTime(2020, 2, 28, 0, 50, 35, 776, DateTimeKind.Local).AddTicks(3990) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 28, 0, 50, 35, 776, DateTimeKind.Local).AddTicks(4000), new Guid("a6189afd-a689-46a8-a630-bbbf2b7d9997"), new DateTime(2020, 2, 28, 0, 50, 35, 776, DateTimeKind.Local).AddTicks(4004) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 28, 0, 50, 35, 776, DateTimeKind.Local).AddTicks(4019), new Guid("36f53413-ff5e-48d3-82c8-11e89fd90ad0"), new DateTime(2020, 2, 28, 0, 50, 35, 776, DateTimeKind.Local).AddTicks(4022) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 28, 0, 50, 35, 776, DateTimeKind.Local).AddTicks(4033), new Guid("a3d2529c-efd5-4218-8370-3e6077997f70"), new DateTime(2020, 2, 28, 0, 50, 35, 776, DateTimeKind.Local).AddTicks(4036) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 28, 0, 50, 35, 776, DateTimeKind.Local).AddTicks(4048), new Guid("8c2041a0-dbd1-46fe-8936-63b6a59c40a3"), new DateTime(2020, 2, 28, 0, 50, 35, 776, DateTimeKind.Local).AddTicks(4051) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 28, 0, 50, 35, 776, DateTimeKind.Local).AddTicks(4062), new Guid("1411a126-1917-48fb-a638-442255758b06"), new DateTime(2020, 2, 28, 0, 50, 35, 776, DateTimeKind.Local).AddTicks(4065) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 28, 0, 50, 35, 776, DateTimeKind.Local).AddTicks(4076), new Guid("bbb7500c-c961-49b6-9c7a-eca5bcf05de7"), new DateTime(2020, 2, 28, 0, 50, 35, 776, DateTimeKind.Local).AddTicks(4079) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 28, 0, 50, 35, 776, DateTimeKind.Local).AddTicks(4090), new Guid("7351d8ef-ea03-4958-b452-525e295ec62c"), new DateTime(2020, 2, 28, 0, 50, 35, 776, DateTimeKind.Local).AddTicks(4094) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 28, 0, 50, 35, 776, DateTimeKind.Local).AddTicks(4105), new Guid("d201bb38-b7c0-4bf6-9f63-c019e6875d94"), new DateTime(2020, 2, 28, 0, 50, 35, 776, DateTimeKind.Local).AddTicks(4108) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 28, 0, 50, 35, 776, DateTimeKind.Local).AddTicks(4119), new Guid("17f3b613-dd06-430a-9790-ec9e935076f3"), new DateTime(2020, 2, 28, 0, 50, 35, 776, DateTimeKind.Local).AddTicks(4122) });

            migrationBuilder.InsertData(
                table: "Product_ProductType",
                columns: new[] { "ProductId", "ProductTypeId" },
                values: new object[] { 10, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 28, 0, 50, 35, 778, DateTimeKind.Local).AddTicks(4414), @"
                        <table border=0 cellpadding=0 cellspacing=0 width=641 style='border-collapse:
                             collapse;width:481pt;box-sizing: border-box;border-image: initial;font-variant-ligatures: normal;
                             font-variant-caps: normal;font-variant-numeric: inherit;font-variant-east-asian: inherit;
                             font-stretch: inherit;line-height:inherit;orphans: 2;text-align:start;
                             widows: 2;-webkit-text-stroke-width: 0px;text-decoration-style: initial;
                             text-decoration-color: initial;max-height: 28px'>
                            <!--StartFragment-->
                             <col width=115 style='mso-width-source:userset;mso-width-alt:4205;width:86pt'>
                             <col width=158 style='mso-width-source:userset;mso-width-alt:5778;width:119pt'>
                             <col width=368 style='mso-width-source:userset;mso-width-alt:13458;width:276pt'>
                             <tr height=20 style='height:15.0pt;box-sizing: border-box'>
                              <td height=20 class=xl65 width=115 style='height:15.0pt;width:86pt'>NETWORK</td>
                              <td class=xl65 width=158 style='width:119pt;box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial;transition: all 0.15s ease-out 0s'><a
                              href=""https://www.gsmarena.com/network-bands.php3"" target=""_parent""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Technology</span></a></td>
                              <td width=368 style='width:276pt;box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial;
                              transition: all 0.15s ease-out 0s'><a
                              href=""https://www.gsmarena.com/huawei_p30_pro-9635.php"" target=""_parent""
                              data-spec=nettech style='box-sizing: border-box'><span style='color:black;
                              text-decoration:none'>GSM / HSPA / LTE</span></a></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'>LAUNCH</td>
                              <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=phone-life-cycle""
                              target=""_parent"" style='box-sizing: border-box'><span style='color:black;
                              font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Announced</span></a></td>
                              <td data-spec=year style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'>2019,
                              March</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a
                              href=""https://www.gsmarena.com/glossary.php3?term=phone-life-cycle""
                              target=""_parent"" style='box-sizing: border-box'><span style='color:black;
                              font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Status</span></a></td>
                              <td data-spec=status style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-color:initial;
                              border-image: initial'>Available. Released 2019, March</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'>BODY</td>
                              <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/huawei_p30_pro-9635.php"" target=""_parent""
                              onclick=""helpW('h_dimens.htm');"" style='box-sizing: border-box'><span
                              style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Dimensions</span></a></td>
                              <td data-spec=dimensions style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'>158
                              x 73.4 x 8.4 mm (6.22 x 2.89 x 0.33 in)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/huawei_p30_pro-9635.php""
                              target=""_parent"" onclick=""helpW('h_weight.htm');"" style='box-sizing: border-box'><span
                              style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Weight</span></a></td>
                              <td data-spec=weight style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'>192
                              g (6.77 oz)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=build""
                              target=""_parent"" style='box-sizing: border-box'><span style='color:black;
                              font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Build</span></a></td>
                              <td data-spec=build style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'>Glass
                              front (Aluminosilicate glass), glass back (Aluminosilicate glass), aluminum
                              frame</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=sim""
                              target=""_parent"" style='box-sizing: border-box'><span style='color:black;
                              font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>SIM</span></a></td>
                              <td data-spec=sim style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'>Single
                              SIM (Nano-SIM) or Hybrid Dual SIM (Nano-SIM, dual stand-by)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td data-spec=bodyother style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-color:initial;
                              border-image: initial'>IP68 dust/water resistant (up to 2m for 30 mins)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'>DISPLAY</td>
                              <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=display-type""
                              target=""_parent"" style='box-sizing: border-box'><span style='color:black;
                              font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Type</span></a></td>
                              <td data-spec=displaytype style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>OLED
                              capacitive touchscreen, 16M colors</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/huawei_p30_pro-9635.php""
                              target=""_parent"" onclick=""helpW('h_dsize.htm');"" style='box-sizing: border-box'><span
                              style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Size</span></a></td>
                              <td data-spec=displaysize style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>6.47
                              inches, 102.8 cm<font class=""font6""><sup style='box-sizing: border-box;
                              font-style:inherit;font-variant:inherit;font-weight:inherit;font-stretch: inherit'>2</sup></font><font
                              class=""font5"">&nbsp;(~88.6% screen-to-body ratio)</font></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a
                              href=""https://www.gsmarena.com/glossary.php3?term=resolution"" target=""_parent""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Resolution</span></a></td>
                              <td data-spec=displayresolution style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>1080
                              x 2340 pixels, 19.5:9 ratio (~398 ppi density)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td data-spec=displayother style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-color:
                              initial;border-image: initial'>DCI-P3</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td>HDR10</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'>PLATFORM</td>
                              <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=os"" target=""_parent""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>OS</span></a></td>
                              <td data-spec=os style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'>Android
                              9.0 (Pie), upgradable to Android 10.0; EMUI 10</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=chipset""
                              target=""_parent"" style='box-sizing: border-box'><span style='color:black;
                              font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Chipset</span></a></td>
                              <td data-spec=chipset style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'>HiSilicon
                              Kirin 980 (7 nm)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=cpu""
                              target=""_parent"" style='box-sizing: border-box'><span style='color:black;
                              font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>CPU</span></a></td>
                              <td data-spec=cpu style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'>Octa-core
                              (2x2.6 GHz Cortex-A76 &amp; 2x1.92 GHz Cortex-A76 &amp; 4x1.8 GHz Cortex-A55)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=gpu""
                              target=""_parent"" style='box-sizing: border-box'><span style='color:black;
                              font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>GPU</span></a></td>
                              <td data-spec=gpu style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-color:initial;
                              border-image: initial'>Mali-G76 MP10</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'>MEMORY</td>
                              <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=memory-card-slot""
                              target=""_parent"" style='box-sizing: border-box'><span style='color:black;
                              font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Card slot</span></a></td>
                              <td data-spec=memoryslot style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'>NM
                              (Nano Memory), up to 256GB (uses shared SIM slot)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a
                              href=""https://www.gsmarena.com/glossary.php3?term=dynamic-memory""
                              target=""_parent"" style='box-sizing: border-box'><span style='color:black;
                              font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Internal</span></a></td>
                              <td data-spec=internalmemory style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>128GB
                              6GB RAM, 128GB 8GB RAM, 256GB 8GB RAM, 512GB 8GB RAM</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td data-spec=memoryother style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-color:
                              initial;border-image: initial'>UFS 2.1</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'>MAIN CAMERA</td>
                              <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=camera"" target=""_parent""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Quad</span></a></td>
                              <td data-spec=cam1modules style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>40
                              MP, f/1.6, 27mm (wide), 1/1.7&quot;, PDAF, OIS</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td>Periscope 8 MP, f/3.4, 125mm (telephoto), 1/4&quot;, PDAF, OIS, 5x
                              optical zoom</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td>20 MP, f/2.2, 16mm (ultrawide), 1/2.7&quot;, PDAF</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td>TOF 3D, (depth)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=camera""
                              target=""_parent"" style='box-sizing: border-box'><span style='color:black;
                              font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Features</span></a></td>
                              <td data-spec=cam1features style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Leica
                              optics, dual-LED dual-tone flash, panorama, HDR</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=camera""
                              target=""_parent"" style='box-sizing: border-box'><span style='color:black;
                              font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Video</span></a></td>
                              <td data-spec=cam1video style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-color:initial;
                              border-image: initial'>2160p@30fps, 1080p@60fps, 1080p@30fps (gyro-EIS),
                              720p@960fps</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'>SELFIE CAMERA</td>
                              <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=secondary-camera""
                              target=""_parent"" style='box-sizing: border-box'><span style='color:black;
                              font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Single</span></a></td>
                              <td data-spec=cam2modules style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>32
                              MP, f/2.0, 26mm (wide), 1/2.8&quot;, 0.8µm</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a
                              href=""https://www.gsmarena.com/glossary.php3?term=secondary-camera""
                              target=""_parent"" style='box-sizing: border-box'><span style='color:black;
                              font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Features</span></a></td>
                              <td data-spec=cam2features style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>HDR</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a
                              href=""https://www.gsmarena.com/glossary.php3?term=secondary-camera""
                              target=""_parent"" style='box-sizing: border-box'><span style='color:black;
                              font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Video</span></a></td>
                              <td data-spec=cam2video style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-color:initial;
                              border-image: initial'>1080p@30fps</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'>SOUND</td>
                              <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=loudspeaker""
                              target=""_parent"" style='box-sizing: border-box'><span style='color:black;
                              font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Loudspeaker</span></a></td>
                              <td style='box-sizing: border-box;border-top-style:initial;border-right-style:
                              initial;border-left-style:initial;border-top-color:initial;border-right-color:
                              initial;border-left-color:initial;border-image: initial'>Yes</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a
                              href=""https://www.gsmarena.com/glossary.php3?term=audio-jack"" target=""_parent""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>3.5mm
                              jack</span></a></td>
                              <td style='box-sizing: border-box;border-top-style:initial;border-right-style:
                              initial;border-left-style:initial;border-top-color:initial;border-right-color:
                              initial;border-left-color:initial;border-image: initial'>No</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td data-spec=optionalother style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-color:
                              initial;border-image: initial'>32-bit/384kHz audio</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'>COMMS</td>
                              <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=wi-fi"" target=""_parent""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>WLAN</span></a></td>
                              <td data-spec=wlan style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'>Wi-Fi
                              802.11 a/b/g/n/ac, dual-band, Wi-Fi Direct, hotspot</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=bluetooth""
                              target=""_parent"" style='box-sizing: border-box'><span style='color:black;
                              font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Bluetooth</span></a></td>
                              <td data-spec=bluetooth style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'>5.0,
                              A2DP, aptX HD, LE</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=gps""
                              target=""_parent"" style='box-sizing: border-box'><span style='color:black;
                              font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>GPS</span></a></td>
                              <td data-spec=gps style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'>Yes,
                              with dual-band A-GPS, GLONASS, BDS, GALILEO, QZSS</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=nfc""
                              target=""_parent"" style='box-sizing: border-box'><span style='color:black;
                              font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>NFC</span></a></td>
                              <td data-spec=nfc style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'>Yes</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=irda""
                              target=""_parent"" style='box-sizing: border-box'><span style='color:black;
                              font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Infrared port</span></a></td>
                              <td style='box-sizing: border-box;border-top-style:initial;border-right-style:
                              initial;border-left-style:initial;border-top-color:initial;border-right-color:
                              initial;border-left-color:initial;border-image: initial'>Yes</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=fm-radio""
                              target=""_parent"" style='box-sizing: border-box'><span style='color:black;
                              font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Radio</span></a></td>
                              <td data-spec=radio style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'>No</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=usb""
                              target=""_parent"" style='box-sizing: border-box'><span style='color:black;
                              font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>USB</span></a></td>
                              <td data-spec=usb style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-color:initial;
                              border-image: initial'>3.1, Type-C 1.0 reversible connector</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'>FEATURES</td>
                              <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-color:initial;
                              border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=sensors"" target=""_parent""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Sensors</span></a></td>
                              <td data-spec=sensors style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-color:initial;
                              border-image: initial'>Fingerprint (under display, optical), accelerometer,
                              gyro, proximity, compass, color spectrum</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'>BATTERY</td>
                              <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'></td>
                              <td data-spec=batdescription1 style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Non-removable
                              Li-Po 4200 mAh battery</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a
                              href=""https://www.gsmarena.com/glossary.php3?term=battery-charging""
                              target=""_parent"" style='box-sizing: border-box'><span style='color:black;
                              font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Charging</span></a></td>
                              <td style='box-sizing: border-box;border-top-style:initial;border-right-style:
                              initial;border-left-style:initial;border-color:initial;border-image: initial'>Fast
                              battery charging 40W (70% in 30 min)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td>Fast wireless charging 15W</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td>Power bank/Reverse wireless charging</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'>MISC</td>
                              <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=build"" target=""_parent""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Colors</span></a></td>
                              <td data-spec=colors style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'>Aurora,
                              Amber Sunrise, Breathing Crystal, Black, Pearl White, Misty Lavender, Mystic
                              Blue</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=models""
                              target=""_parent"" style='box-sizing: border-box'><span style='color:black;
                              font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Models</span></a></td>
                              <td data-spec=models style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'>VOG-L29,
                              VOG-L09, VOG-AL00, VOG-TL00, VOG-L04, VOG-AL10</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=price""
                              target=""_parent"" style='box-sizing: border-box'><span style='color:black;
                              font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Price</span></a></td>
                              <td data-spec=price style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-color:initial;
                              border-image: initial'><a
                              href=""https://www.gsmarena.com/huawei_p30_pro-price-9635.php"" target=""_parent""
                              style='box-sizing: border-box'><span style='color:black;text-decoration:none'>$ 580.00
                              / € 537.99 / £ 496.42 / ₹ 51,455</span></a></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'>TESTS</td>
                              <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=benchmarking""
                              target=""_parent"" style='box-sizing: border-box'><span style='color:black;
                              font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Performance</span></a></td>
                              <td data-spec=tbench style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'>AnTuTu:
                              316156 (v7), 401208 (v8)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td>GeekBench: 10014 (v4.4), 2521 (v5.1)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td>GFXBench: 29fps (ES 3.1 onscreen)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a
                              href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p2.php""
                              target=""_parent"" style='box-sizing: border-box'><span style='color:black;
                              font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Display</span></a></td>
                              <td style='box-sizing: border-box;border-top-style:initial;border-right-style:
                              initial;border-left-style:initial;border-top-color:initial;border-right-color:
                              initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/huawei_p30_pro-review-1910p3.php#dt""
                              target=""_parent"" style='box-sizing: border-box'><span style='color:black;
                              text-decoration:none'>Contrast ratio: Infinite (nominal), 5.119 (sunlight)</span></a></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a
                              href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p5.php""
                              target=""_parent"" style='box-sizing: border-box'><span style='color:black;
                              font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Camera</span></a></td>
                              <td style='box-sizing: border-box;border-top-style:initial;border-right-style:
                              initial;border-left-style:initial;border-top-color:initial;border-right-color:
                              initial;border-left-color:initial;border-image: initial'>Photo&nbsp;/&nbsp;Video</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a
                              href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p3.php""
                              target=""_parent"" style='box-sizing: border-box'><span style='color:black;
                              font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Loudspeaker</span></a></td>
                              <td style='box-sizing: border-box;border-top-style:initial;border-right-style:
                              initial;border-left-style:initial;border-top-color:initial;border-right-color:
                              initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/huawei_p30_pro-review-1910p3.php#lt""
                              target=""_parent"" style='box-sizing: border-box'><span style='color:black;
                              text-decoration:none'>Voice 70dB / Noise 73dB / Ring 90dB</span></a></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a
                              href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p4.php""
                              target=""_parent"" style='box-sizing: border-box'><span style='color:black;
                              font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Audio quality</span></a></td>
                              <td style='box-sizing: border-box;border-top-style:initial;border-right-style:
                              initial;border-left-style:initial;border-top-color:initial;border-right-color:
                              initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/huawei_p30_pro-review-1910p3.php#aq""
                              target=""_parent"" style='box-sizing: border-box'><span style='color:black;
                              text-decoration:none'>Noise -90.5dB / Crosstalk -93.0dB</span></a></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a
                              href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p6.php""
                              target=""_parent"" style='box-sizing: border-box'><span style='color:black;
                              font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Battery life</span></a></td>
                              <td data-spec=batlife style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'>
                              <div style='box-sizing: border-box'><a
                              href=""https://www.gsmarena.com/huawei_p30_pro-9635.php"" target=""_parent""
                              onclick=""showBatteryPopup(event, 9635); "" style='box-sizing: border-box'><span
                              style='color:black;text-decoration:none'>Endurance rating 100h</span></a></div>
                              </td>
                             </tr>
                            <!--EndFragment-->
                            </table>", new Guid("3e336303-fd67-4a4e-99d1-49cfc8df1536"), new DateTime(2020, 2, 28, 0, 50, 35, 778, DateTimeKind.Local).AddTicks(4418) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 28, 0, 50, 35, 779, DateTimeKind.Local).AddTicks(1832), @"
                        
                                <table border=0 cellpadding=0 cellspacing=0 width=800 style='border-collapse:
                                 collapse;width:600pt;box-sizing: border-box;border-image: initial;font-variant-ligatures: normal;
                                 font-variant-caps: normal;font-variant-numeric: inherit;font-variant-east-asian: inherit;
                                 font-stretch: inherit;line-height:inherit;orphans: 2;text-align:start;
                                 widows: 2;-webkit-text-stroke-width: 0px;text-decoration-style: initial;
                                 text-decoration-color: initial;max-height: 28px'>
                                <!--StartFragment-->
                                 <col width=103 style='mso-width-source:userset;mso-width-alt:3766;width:77pt'>
                                 <col width=90 style='mso-width-source:userset;mso-width-alt:3291;width:68pt'>
                                 <col width=607 style='mso-width-source:userset;mso-width-alt:22198;width:455pt'>
                                 <tr height=20 style='height:15.0pt;box-sizing: border-box'>
                                  <td height=20 class=xl65 width=103 style='height:15.0pt;width:77pt'>NETWORK</td>
                                  <td class=xl65 width=90 style='width:68pt;box-sizing: border-box;border-top-style:
                                  initial;border-right-style:initial;border-left-style:initial;border-top-color:
                                  initial;border-right-color:initial;border-left-color:initial;border-image: initial;
                                  transition: all 0.15s ease-out 0s'><a
                                  href=""https://www.gsmarena.com/network-bands.php3"" style='box-sizing: border-box'><span
                                  style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                                  mso-font-charset:0'>Technology</span></a></td>
                                  <td width=607 style='width:455pt;box-sizing: border-box;border-top-style:
                                  initial;border-right-style:initial;border-left-style:initial;border-top-color:
                                  initial;border-right-color:initial;border-left-color:initial;border-image: initial;
                                  transition: all 0.15s ease-out 0s'><a
                                  href=""https://www.gsmarena.com/huawei_p20_pro-9106.php"" data-spec=nettech
                                  style='box-sizing: border-box'><span style='color:black;text-decoration:none'>GSM
                                  / HSPA / LTE</span></a></td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65></td>
                                  <td></td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'>LAUNCH</td>
                                  <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-top-color:initial;
                                  border-right-color:initial;border-left-color:initial;border-image: initial'><a
                                  href=""https://www.gsmarena.com/glossary.php3?term=phone-life-cycle""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Announced</span></a></td>
                                  <td data-spec=year style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-top-color:initial;
                                  border-right-color:initial;border-left-color:initial;border-image: initial'>2018,
                                  March</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a
                                  href=""https://www.gsmarena.com/glossary.php3?term=phone-life-cycle""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Status</span></a></td>
                                  <td data-spec=status style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-color:initial;
                                  border-image: initial'>Available. Released 2018, April</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'>BODY</td>
                                  <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-top-color:initial;
                                  border-right-color:initial;border-left-color:initial;border-image: initial'><a
                                  href=""https://www.gsmarena.com/huawei_p20_pro-9106.php""
                                  onclick=""helpW('h_dimens.htm');"" style='box-sizing: border-box'><span
                                  style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                                  mso-font-charset:0'>Dimensions</span></a></td>
                                  <td data-spec=dimensions style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-top-color:initial;
                                  border-right-color:initial;border-left-color:initial;border-image: initial'>155
                                  x 73.9 x 7.8 mm (6.10 x 2.91 x 0.31 in)</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a href=""https://www.gsmarena.com/huawei_p20_pro-9106.php""
                                  onclick=""helpW('h_weight.htm');"" style='box-sizing: border-box'><span
                                  style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                                  mso-font-charset:0'>Weight</span></a></td>
                                  <td data-spec=weight style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-top-color:initial;
                                  border-right-color:initial;border-left-color:initial;border-image: initial'>180
                                  g (6.35 oz)</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=build""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Build</span></a></td>
                                  <td data-spec=build style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-top-color:initial;
                                  border-right-color:initial;border-left-color:initial;border-image: initial'>Glass
                                  front (Gorilla Glass 5), glass back, aluminum frame</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=sim""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>SIM</span></a></td>
                                  <td data-spec=sim style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-top-color:initial;
                                  border-right-color:initial;border-left-color:initial;border-image: initial'>Single
                                  SIM (Nano-SIM) or Dual SIM (Nano-SIM, dual stand-by)</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65></td>
                                  <td data-spec=bodyother style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-color:initial;
                                  border-image: initial'>IP67 dust/water resistant (up to 1m for 30 mins)</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65></td>
                                  <td></td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'>DISPLAY</td>
                                  <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-top-color:initial;
                                  border-right-color:initial;border-left-color:initial;border-image: initial'><a
                                  href=""https://www.gsmarena.com/glossary.php3?term=display-type""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Type</span></a></td>
                                  <td data-spec=displaytype style='box-sizing: border-box;border-top-style:
                                  initial;border-right-style:initial;border-left-style:initial;border-top-color:
                                  initial;border-right-color:initial;border-left-color:initial;border-image: initial'>OLED
                                  capacitive touchscreen, 16M colors</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a href=""https://www.gsmarena.com/huawei_p20_pro-9106.php""
                                  onclick=""helpW('h_dsize.htm');"" style='box-sizing: border-box'><span
                                  style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                                  mso-font-charset:0'>Size</span></a></td>
                                  <td data-spec=displaysize style='box-sizing: border-box;border-top-style:
                                  initial;border-right-style:initial;border-left-style:initial;border-top-color:
                                  initial;border-right-color:initial;border-left-color:initial;border-image: initial'>6.1
                                  inches, 93.9 cm<font class=""font6""><sup style='box-sizing: border-box;
                                  font-style:inherit;font-variant:inherit;font-weight:inherit;font-stretch: inherit'>2</sup></font><font
                                  class=""font5"">&nbsp;(~82.0% screen-to-body ratio)</font></td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a
                                  href=""https://www.gsmarena.com/glossary.php3?term=resolution""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Resolution</span></a></td>
                                  <td data-spec=displayresolution style='box-sizing: border-box;border-top-style:
                                  initial;border-right-style:initial;border-left-style:initial;border-top-color:
                                  initial;border-right-color:initial;border-left-color:initial;border-image: initial'>1080
                                  x 2240 pixels, 18.7:9 ratio (~408 ppi density)</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a
                                  href=""https://www.gsmarena.com/glossary.php3?term=screen-protection""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Protection</span></a></td>
                                  <td data-spec=displayprotection style='box-sizing: border-box;border-top-style:
                                  initial;border-right-style:initial;border-left-style:initial;border-color:
                                  initial;border-image: initial'>Corning Gorilla Glass 5</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65></td>
                                  <td></td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'>PLATFORM</td>
                                  <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-top-color:initial;
                                  border-right-color:initial;border-left-color:initial;border-image: initial'><a
                                  href=""https://www.gsmarena.com/glossary.php3?term=os"" style='box-sizing: border-box'><span
                                  style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                                  mso-font-charset:0'>OS</span></a></td>
                                  <td data-spec=os style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-top-color:initial;
                                  border-right-color:initial;border-left-color:initial;border-image: initial'>Android
                                  8.1 (Oreo), planned upgrade to Android 10.0; EMUI 9.1</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=chipset""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Chipset</span></a></td>
                                  <td data-spec=chipset style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-top-color:initial;
                                  border-right-color:initial;border-left-color:initial;border-image: initial'>Hisilicon
                                  Kirin 970 (10 nm)</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=cpu""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>CPU</span></a></td>
                                  <td data-spec=cpu style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-top-color:initial;
                                  border-right-color:initial;border-left-color:initial;border-image: initial'>Octa-core
                                  (4x2.4 GHz Cortex-A73 &amp; 4x1.8 GHz Cortex-A53)</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=gpu""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>GPU</span></a></td>
                                  <td data-spec=gpu style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-color:initial;
                                  border-image: initial'>Mali-G72 MP12</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'>MEMORY</td>
                                  <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-top-color:initial;
                                  border-right-color:initial;border-left-color:initial;border-image: initial'><a
                                  href=""https://www.gsmarena.com/glossary.php3?term=memory-card-slot""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Card
                                  slot</span></a></td>
                                  <td data-spec=memoryslot style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-top-color:initial;
                                  border-right-color:initial;border-left-color:initial;border-image: initial'>No</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a
                                  href=""https://www.gsmarena.com/glossary.php3?term=dynamic-memory""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Internal</span></a></td>
                                  <td data-spec=internalmemory style='box-sizing: border-box;border-top-style:
                                  initial;border-right-style:initial;border-left-style:initial;border-top-color:
                                  initial;border-right-color:initial;border-left-color:initial;border-image: initial'>64GB
                                  6GB RAM, 128GB 6GB RAM, 128GB 8GB RAM, 256GB 6GB RAM, 256GB 8GB RAM</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65></td>
                                  <td data-spec=memoryother style='box-sizing: border-box;border-top-style:
                                  initial;border-right-style:initial;border-left-style:initial;border-color:
                                  initial;border-image: initial'>UFS 2.1</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65></td>
                                  <td></td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'>MAIN CAMERA</td>
                                  <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-top-color:initial;
                                  border-right-color:initial;border-left-color:initial;border-image: initial'><a
                                  href=""https://www.gsmarena.com/glossary.php3?term=camera"" style='box-sizing: border-box'><span
                                  style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                                  mso-font-charset:0'>Triple</span></a></td>
                                  <td data-spec=cam1modules style='box-sizing: border-box;border-top-style:
                                  initial;border-right-style:initial;border-left-style:initial;border-top-color:
                                  initial;border-right-color:initial;border-left-color:initial;border-image: initial'>40
                                  MP, f/1.8, 27mm (wide), 1/1.7&quot;, PDAF, Laser AF, OIS</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65></td>
                                  <td>8 MP, f/2.4, 80mm (telephoto), 1/4&quot;, PDAF, Laser AF, OIS, 3x optical
                                  zoom</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65></td>
                                  <td>20 MP B/W, f/1.6, 27mm (wide), 1/2.7&quot;, PDAF, Laser AF, OIS</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=camera""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Features</span></a></td>
                                  <td data-spec=cam1features style='box-sizing: border-box;border-top-style:
                                  initial;border-right-style:initial;border-left-style:initial;border-top-color:
                                  initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Leica
                                  optics, LED flash, HDR, panorama</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=camera""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Video</span></a></td>
                                  <td data-spec=cam1video style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-color:initial;
                                  border-image: initial'>2160p@30fps, 1080p@60fps, 1080p@30fps (gyro-EIS),
                                  720p@960fps</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65></td>
                                  <td></td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'>SELFIE CAMERA</td>
                                  <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-top-color:initial;
                                  border-right-color:initial;border-left-color:initial;border-image: initial'><a
                                  href=""https://www.gsmarena.com/glossary.php3?term=secondary-camera""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Single</span></a></td>
                                  <td data-spec=cam2modules style='box-sizing: border-box;border-top-style:
                                  initial;border-right-style:initial;border-left-style:initial;border-top-color:
                                  initial;border-right-color:initial;border-left-color:initial;border-image: initial'>24
                                  MP, f/2.0, 26mm (wide), 1/2.8&quot;, 0.9µm</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a
                                  href=""https://www.gsmarena.com/glossary.php3?term=secondary-camera""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Features</span></a></td>
                                  <td data-spec=cam2features style='box-sizing: border-box;border-top-style:
                                  initial;border-right-style:initial;border-left-style:initial;border-top-color:
                                  initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Leica
                                  optics</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a
                                  href=""https://www.gsmarena.com/glossary.php3?term=secondary-camera""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Video</span></a></td>
                                  <td data-spec=cam2video style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-color:initial;
                                  border-image: initial'>1080p@30fps</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65></td>
                                  <td></td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'>SOUND</td>
                                  <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-top-color:initial;
                                  border-right-color:initial;border-left-color:initial;border-image: initial'><a
                                  href=""https://www.gsmarena.com/glossary.php3?term=loudspeaker""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Loudspeaker</span></a></td>
                                  <td style='box-sizing: border-box;border-top-style:initial;border-right-style:
                                  initial;border-left-style:initial;border-top-color:initial;border-right-color:
                                  initial;border-left-color:initial;border-image: initial'>Yes, with stereo
                                  speakers</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a
                                  href=""https://www.gsmarena.com/glossary.php3?term=audio-jack""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>3.5mm
                                  jack</span></a></td>
                                  <td style='box-sizing: border-box;border-top-style:initial;border-right-style:
                                  initial;border-left-style:initial;border-top-color:initial;border-right-color:
                                  initial;border-left-color:initial;border-image: initial'>No</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65></td>
                                  <td data-spec=optionalother style='box-sizing: border-box;border-top-style:
                                  initial;border-right-style:initial;border-left-style:initial;border-color:
                                  initial;border-image: initial'>32-bit/384kHz audio</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'>COMMS</td>
                                  <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-top-color:initial;
                                  border-right-color:initial;border-left-color:initial;border-image: initial'><a
                                  href=""https://www.gsmarena.com/glossary.php3?term=wi-fi"" style='box-sizing: border-box'><span
                                  style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                                  mso-font-charset:0'>WLAN</span></a></td>
                                  <td data-spec=wlan style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-top-color:initial;
                                  border-right-color:initial;border-left-color:initial;border-image: initial'>Wi-Fi
                                  802.11 a/b/g/n/ac, dual-band, Wi-Fi Direct, hotspot</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=bluetooth""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Bluetooth</span></a></td>
                                  <td data-spec=bluetooth style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-top-color:initial;
                                  border-right-color:initial;border-left-color:initial;border-image: initial'>4.2,
                                  A2DP, LE, EDR, aptX HD</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=gps""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>GPS</span></a></td>
                                  <td data-spec=gps style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-top-color:initial;
                                  border-right-color:initial;border-left-color:initial;border-image: initial'>Yes,
                                  with A-GPS, GLONASS, GALILEO</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=nfc""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>NFC</span></a></td>
                                  <td data-spec=nfc style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-top-color:initial;
                                  border-right-color:initial;border-left-color:initial;border-image: initial'>Yes</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=irda""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Infrared
                                  port</span></a></td>
                                  <td style='box-sizing: border-box;border-top-style:initial;border-right-style:
                                  initial;border-left-style:initial;border-top-color:initial;border-right-color:
                                  initial;border-left-color:initial;border-image: initial'>Yes</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=fm-radio""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Radio</span></a></td>
                                  <td data-spec=radio style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-top-color:initial;
                                  border-right-color:initial;border-left-color:initial;border-image: initial'>No</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=usb""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>USB</span></a></td>
                                  <td data-spec=usb style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-color:initial;
                                  border-image: initial'>3.1, Type-C 1.0 reversible connector</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65></td>
                                  <td></td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'>FEATURES</td>
                                  <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-color:initial;
                                  border-image: initial'><a
                                  href=""https://www.gsmarena.com/glossary.php3?term=sensors"" style='box-sizing: border-box'><span
                                  style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                                  mso-font-charset:0'>Sensors</span></a></td>
                                  <td data-spec=sensors style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-color:initial;
                                  border-image: initial'>Fingerprint (front-mounted), accelerometer, gyro,
                                  proximity, compass, color spectrum</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65></td>
                                  <td></td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'>BATTERY</td>
                                  <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-top-color:initial;
                                  border-right-color:initial;border-left-color:initial;border-image: initial'></td>
                                  <td data-spec=batdescription1 style='box-sizing: border-box;border-top-style:
                                  initial;border-right-style:initial;border-left-style:initial;border-top-color:
                                  initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Non-removable
                                  Li-Po 4000 mAh battery</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a
                                  href=""https://www.gsmarena.com/glossary.php3?term=battery-charging""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Charging</span></a></td>
                                  <td style='box-sizing: border-box;border-top-style:initial;border-right-style:
                                  initial;border-left-style:initial;border-color:initial;border-image: initial'>Fast
                                  battery charging 22.5W (58% in 30 min)</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65></td>
                                  <td></td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'>MISC</td>
                                  <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-top-color:initial;
                                  border-right-color:initial;border-left-color:initial;border-image: initial'><a
                                  href=""https://www.gsmarena.com/glossary.php3?term=build"" style='box-sizing: border-box'><span
                                  style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                                  mso-font-charset:0'>Colors</span></a></td>
                                  <td data-spec=colors style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-top-color:initial;
                                  border-right-color:initial;border-left-color:initial;border-image: initial'>Black,
                                  Gold</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=models""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Models</span></a></td>
                                  <td data-spec=models style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-top-color:initial;
                                  border-right-color:initial;border-left-color:initial;border-image: initial'>CLT-L29C,
                                  CLT-L29, CLT-L09C, CLT-L09, CLT-AL00, CLT-AL01, CLT-TL01, CLT-AL00L, CLT-L04,
                                  HW-01K</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=price""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Price</span></a></td>
                                  <td data-spec=price style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-color:initial;
                                  border-image: initial'><a
                                  href=""https://www.gsmarena.com/huawei_p20_pro-price-9106.php""
                                  style='box-sizing: border-box'><span style='color:black;text-decoration:none'>$ 659.99
                                  / € 410.00 / £ 299.30</span></a></td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65></td>
                                  <td></td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'>TESTS</td>
                                  <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-top-color:initial;
                                  border-right-color:initial;border-left-color:initial;border-image: initial'><a
                                  href=""https://www.gsmarena.com/glossary.php3?term=benchmarking""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Performance</span></a></td>
                                  <td data-spec=tbench style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-top-color:initial;
                                  border-right-color:initial;border-left-color:initial;border-image: initial'>AnTuTu:
                                  209884 (v7)</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65></td>
                                  <td>GeekBench: 6679 (v4.4)</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65></td>
                                  <td>GFXBench: 21fps (ES 3.1 onscreen)</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a
                                  href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p2.php""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Display</span></a></td>
                                  <td style='box-sizing: border-box;border-top-style:initial;border-right-style:
                                  initial;border-left-style:initial;border-top-color:initial;border-right-color:
                                  initial;border-left-color:initial;border-image: initial'><a
                                  href=""https://www.gsmarena.com/huawei_p20_pro-review-1747p3.php""
                                  style='box-sizing: border-box'><span style='color:black;text-decoration:none'>Contrast
                                  ratio: Infinite (nominal), 4.087 (sunlight)</span></a></td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a
                                  href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p5.php""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Camera</span></a></td>
                                  <td style='box-sizing: border-box;border-top-style:initial;border-right-style:
                                  initial;border-left-style:initial;border-top-color:initial;border-right-color:
                                  initial;border-left-color:initial;border-image: initial'>Photo&nbsp;/&nbsp;Video</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a
                                  href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p3.php""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Loudspeaker</span></a></td>
                                  <td style='box-sizing: border-box;border-top-style:initial;border-right-style:
                                  initial;border-left-style:initial;border-top-color:initial;border-right-color:
                                  initial;border-left-color:initial;border-image: initial'><a
                                  href=""https://www.gsmarena.com/huawei_p20_pro-review-1747p3.php#ls""
                                  style='box-sizing: border-box'><span style='color:black;text-decoration:none'>Voice
                                  71dB / Noise 69dB / Ring 91dB</span></a></td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a
                                  href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p4.php""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Audio
                                  quality</span></a></td>
                                  <td style='box-sizing: border-box;border-top-style:initial;border-right-style:
                                  initial;border-left-style:initial;border-top-color:initial;border-right-color:
                                  initial;border-left-color:initial;border-image: initial'><a
                                  href=""https://www.gsmarena.com/huawei_p20_pro-review-1747p3.php#aq""
                                  style='box-sizing: border-box'><span style='color:black;text-decoration:none'>Noise
                                  -92.1dB / Crosstalk -92.1dB</span></a></td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a
                                  href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p6.php""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Battery
                                  life</span></a></td>
                                  <td data-spec=batlife style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-top-color:initial;
                                  border-right-color:initial;border-left-color:initial;border-image: initial'>
                                  <div style='box-sizing: border-box'><a
                                  href=""https://www.gsmarena.com/huawei_p20_pro-9106.php""
                                  onclick=""showBatteryPopup(event, 9106); "" style='box-sizing: border-box'><span
                                  style='color:black;text-decoration:none'>Endurance rating 89h</span></a></div>
                                  </td>
                                 </tr>
                                <!--EndFragment-->
                                </table>", new Guid("e482ddd6-c669-4d7a-9083-8b6769f76e82"), new DateTime(2020, 2, 28, 0, 50, 35, 779, DateTimeKind.Local).AddTicks(1836) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 28, 0, 50, 35, 779, DateTimeKind.Local).AddTicks(2149), @"
                                <table border=0 cellpadding=0 cellspacing=0 width=799 style='border-collapse:
                                 collapse;width:600pt;box-sizing: border-box;border-image: initial;font-variant-ligatures: normal;
                                 font-variant-caps: normal;font-variant-numeric: inherit;font-variant-east-asian: inherit;
                                 font-stretch: inherit;line-height:inherit;orphans: 2;text-align:start;
                                 widows: 2;-webkit-text-stroke-width: 0px;text-decoration-style: initial;
                                 text-decoration-color: initial;max-height: 28px'>
                                <!--StartFragment-->
                                 <col width=102 style='mso-width-source:userset;mso-width-alt:3730;width:77pt'>
                                 <col width=90 style='mso-width-source:userset;mso-width-alt:3291;width:68pt'>
                                 <col width=607 style='mso-width-source:userset;mso-width-alt:22198;width:455pt'>
                                 <tr height=20 style='height:15.0pt;box-sizing: border-box'>
                                  <td height=20 class=xl65 width=102 style='height:15.0pt;width:77pt'>NETWORK</td>
                                  <td class=xl65 width=90 style='width:68pt;box-sizing: border-box;border-top-style:
                                  initial;border-right-style:initial;border-left-style:initial;border-top-color:
                                  initial;border-right-color:initial;border-left-color:initial;border-image: initial;
                                  transition: all 0.15s ease-out 0s'><a
                                  href=""https://www.gsmarena.com/network-bands.php3"" style='box-sizing: border-box'><span
                                  style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                                  mso-font-charset:0'>Technology</span></a></td>
                                  <td class=xl66 width=607 style='width:455pt;box-sizing: border-box;
                                  border-top-style:initial;border-right-style:initial;border-left-style:initial;
                                  border-top-color:initial;border-right-color:initial;border-left-color:initial;
                                  border-image: initial;transition: all 0.15s ease-out 0s'><a
                                  href=""https://www.gsmarena.com/lg_v50_thinq_5g-9607.php"" data-spec=nettech
                                  style='box-sizing: border-box'><span style='color:black;text-decoration:none'>GSM
                                  / CDMA / HSPA / EVDO / LTE / 5G</span></a></td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65></td>
                                  <td class=xl66></td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'>LAUNCH</td>
                                  <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-top-color:initial;
                                  border-right-color:initial;border-left-color:initial;border-image: initial'><a
                                  href=""https://www.gsmarena.com/glossary.php3?term=phone-life-cycle""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Announced</span></a></td>
                                  <td class=xl66 data-spec=year style='box-sizing: border-box;border-top-style:
                                  initial;border-right-style:initial;border-left-style:initial;border-top-color:
                                  initial;border-right-color:initial;border-left-color:initial;border-image: initial'>2019,
                                  February</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a
                                  href=""https://www.gsmarena.com/glossary.php3?term=phone-life-cycle""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Status</span></a></td>
                                  <td class=xl66 data-spec=status style='box-sizing: border-box;border-top-style:
                                  initial;border-right-style:initial;border-left-style:initial;border-color:
                                  initial;border-image: initial'>Available. Released 2019, May</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'>BODY</td>
                                  <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-top-color:initial;
                                  border-right-color:initial;border-left-color:initial;border-image: initial'><a
                                  href=""https://www.gsmarena.com/lg_v50_thinq_5g-9607.php""
                                  onclick=""helpW('h_dimens.htm');"" style='box-sizing: border-box'><span
                                  style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                                  mso-font-charset:0'>Dimensions</span></a></td>
                                  <td class=xl66 data-spec=dimensions style='box-sizing: border-box;border-top-style:
                                  initial;border-right-style:initial;border-left-style:initial;border-top-color:
                                  initial;border-right-color:initial;border-left-color:initial;border-image: initial'>159.2
                                  x 76.1 x 8.3 mm (6.27 x 3.00 x 0.33 in)</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a href=""https://www.gsmarena.com/lg_v50_thinq_5g-9607.php""
                                  onclick=""helpW('h_weight.htm');"" style='box-sizing: border-box'><span
                                  style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                                  mso-font-charset:0'>Weight</span></a></td>
                                  <td class=xl66 data-spec=weight style='box-sizing: border-box;border-top-style:
                                  initial;border-right-style:initial;border-left-style:initial;border-top-color:
                                  initial;border-right-color:initial;border-left-color:initial;border-image: initial'>183
                                  g (6.46 oz)</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=build""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Build</span></a></td>
                                  <td class=xl66 data-spec=build style='box-sizing: border-box;border-top-style:
                                  initial;border-right-style:initial;border-left-style:initial;border-top-color:
                                  initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Glass
                                  front (Gorilla Glass 5), glass back (Gorilla Glass 6), aluminum frame</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=sim""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>SIM</span></a></td>
                                  <td class=xl66 data-spec=sim style='box-sizing: border-box;border-top-style:
                                  initial;border-right-style:initial;border-left-style:initial;border-top-color:
                                  initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Single
                                  SIM (Nano-SIM) or Dual SIM (Nano-SIM, dual stand-by)</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65></td>
                                  <td class=xl66 data-spec=bodyother style='box-sizing: border-box;border-top-style:
                                  initial;border-right-style:initial;border-left-style:initial;border-color:
                                  initial;border-image: initial'>IP68 dust/water resistant (up to 1.5m for 30
                                  mins)</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65></td>
                                  <td class=xl66>MIL-STD-810G compliant</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65></td>
                                  <td class=xl66></td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'>DISPLAY</td>
                                  <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-top-color:initial;
                                  border-right-color:initial;border-left-color:initial;border-image: initial'><a
                                  href=""https://www.gsmarena.com/glossary.php3?term=display-type""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Type</span></a></td>
                                  <td class=xl66 data-spec=displaytype style='box-sizing: border-box;
                                  border-top-style:initial;border-right-style:initial;border-left-style:initial;
                                  border-top-color:initial;border-right-color:initial;border-left-color:initial;
                                  border-image: initial'>P-OLED capacitive touchscreen, 16M colors</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a href=""https://www.gsmarena.com/lg_v50_thinq_5g-9607.php""
                                  onclick=""helpW('h_dsize.htm');"" style='box-sizing: border-box'><span
                                  style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                                  mso-font-charset:0'>Size</span></a></td>
                                  <td class=xl66 data-spec=displaysize style='box-sizing: border-box;
                                  border-top-style:initial;border-right-style:initial;border-left-style:initial;
                                  border-top-color:initial;border-right-color:initial;border-left-color:initial;
                                  border-image: initial'>6.4 inches, 100.2 cm<font class=""font6""><sup
                                  style='box-sizing: border-box;font-style:inherit;font-variant:inherit;
                                  font-weight:inherit;font-stretch: inherit'>2</sup></font><font class=""font5"">&nbsp;(~82.7%
                                  screen-to-body ratio)</font></td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a
                                  href=""https://www.gsmarena.com/glossary.php3?term=resolution""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Resolution</span></a></td>
                                  <td class=xl66 data-spec=displayresolution style='box-sizing: border-box;
                                  border-top-style:initial;border-right-style:initial;border-left-style:initial;
                                  border-top-color:initial;border-right-color:initial;border-left-color:initial;
                                  border-image: initial'>1440 x 3120 pixels, 19.5:9 ratio (~538 ppi density)</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a
                                  href=""https://www.gsmarena.com/glossary.php3?term=screen-protection""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Protection</span></a></td>
                                  <td class=xl66 data-spec=displayprotection style='box-sizing: border-box;
                                  border-top-style:initial;border-right-style:initial;border-left-style:initial;
                                  border-top-color:initial;border-right-color:initial;border-left-color:initial;
                                  border-image: initial'>Corning Gorilla Glass 5</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65></td>
                                  <td class=xl66 data-spec=displayother style='box-sizing: border-box;
                                  border-top-style:initial;border-right-style:initial;border-left-style:initial;
                                  border-color:initial;border-image: initial'>Dolby Vision</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65></td>
                                  <td class=xl66>HDR10</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65></td>
                                  <td class=xl66>Always-on display</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'>PLATFORM</td>
                                  <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-top-color:initial;
                                  border-right-color:initial;border-left-color:initial;border-image: initial'><a
                                  href=""https://www.gsmarena.com/glossary.php3?term=os"" style='box-sizing: border-box'><span
                                  style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                                  mso-font-charset:0'>OS</span></a></td>
                                  <td class=xl66 data-spec=os style='box-sizing: border-box;border-top-style:
                                  initial;border-right-style:initial;border-left-style:initial;border-top-color:
                                  initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Android
                                  9.0 (Pie), upgradable to Android 10.0</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=chipset""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Chipset</span></a></td>
                                  <td class=xl66 data-spec=chipset style='box-sizing: border-box;border-top-style:
                                  initial;border-right-style:initial;border-left-style:initial;border-top-color:
                                  initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Qualcomm
                                  SM8150 Snapdragon 855 (7 nm)</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=cpu""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>CPU</span></a></td>
                                  <td class=xl66 data-spec=cpu style='box-sizing: border-box;border-top-style:
                                  initial;border-right-style:initial;border-left-style:initial;border-top-color:
                                  initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Octa-core
                                  (1x2.84 GHz Kryo 485 &amp; 3x2.42 GHz Kryo 485 &amp; 4x1.78 GHz Kryo 485)</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=gpu""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>GPU</span></a></td>
                                  <td class=xl66 data-spec=gpu style='box-sizing: border-box;border-top-style:
                                  initial;border-right-style:initial;border-left-style:initial;border-color:
                                  initial;border-image: initial'>Adreno 640</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'>MEMORY</td>
                                  <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-top-color:initial;
                                  border-right-color:initial;border-left-color:initial;border-image: initial'><a
                                  href=""https://www.gsmarena.com/glossary.php3?term=memory-card-slot""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Card
                                  slot</span></a></td>
                                  <td class=xl66 data-spec=memoryslot style='box-sizing: border-box;border-top-style:
                                  initial;border-right-style:initial;border-left-style:initial;border-top-color:
                                  initial;border-right-color:initial;border-left-color:initial;border-image: initial'>microSDXC
                                  (dedicated slot)</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a
                                  href=""https://www.gsmarena.com/glossary.php3?term=dynamic-memory""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Internal</span></a></td>
                                  <td class=xl66 data-spec=internalmemory style='box-sizing: border-box;
                                  border-top-style:initial;border-right-style:initial;border-left-style:initial;
                                  border-top-color:initial;border-right-color:initial;border-left-color:initial;
                                  border-image: initial'>128GB 6GB RAM</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65></td>
                                  <td class=xl66 data-spec=memoryother style='box-sizing: border-box;
                                  border-top-style:initial;border-right-style:initial;border-left-style:initial;
                                  border-color:initial;border-image: initial'>UFS 2.1</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65></td>
                                  <td class=xl66></td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'>MAIN CAMERA</td>
                                  <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-top-color:initial;
                                  border-right-color:initial;border-left-color:initial;border-image: initial'><a
                                  href=""https://www.gsmarena.com/glossary.php3?term=camera"" style='box-sizing: border-box'><span
                                  style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                                  mso-font-charset:0'>Triple</span></a></td>
                                  <td class=xl66 data-spec=cam1modules style='box-sizing: border-box;
                                  border-top-style:initial;border-right-style:initial;border-left-style:initial;
                                  border-top-color:initial;border-right-color:initial;border-left-color:initial;
                                  border-image: initial'>12 MP, 27mm (standard), f/1.5, 1/2.55&quot;, 1.4µm,
                                  dual pixel PDAF, 3-axis OIS</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65></td>
                                  <td class=xl66>12 MP, 52mm (telephoto), f/2.4, 1/3.4&quot;, 1.0µm, 2x optical
                                  zoom, PDAF, OIS</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65></td>
                                  <td class=xl66>16 MP, 16mm (ultrawide), f/1.9, 1/3.1&quot;, 1.0µm, no AF</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=camera""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Features</span></a></td>
                                  <td class=xl66 data-spec=cam1features style='box-sizing: border-box;
                                  border-top-style:initial;border-right-style:initial;border-left-style:initial;
                                  border-top-color:initial;border-right-color:initial;border-left-color:initial;
                                  border-image: initial'>LED flash, HDR, panorama</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=camera""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Video</span></a></td>
                                  <td class=xl66 data-spec=cam1video style='box-sizing: border-box;border-top-style:
                                  initial;border-right-style:initial;border-left-style:initial;border-color:
                                  initial;border-image: initial'>2160p@30/60fps, 1080p@30/60/240fps,
                                  24-bit/192kHz stereo sound rec., HDR10 video, gyro-EIS</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65></td>
                                  <td class=xl66></td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'>SELFIE CAMERA</td>
                                  <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-top-color:initial;
                                  border-right-color:initial;border-left-color:initial;border-image: initial'><a
                                  href=""https://www.gsmarena.com/glossary.php3?term=secondary-camera""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Dual</span></a></td>
                                  <td class=xl66 data-spec=cam2modules style='box-sizing: border-box;
                                  border-top-style:initial;border-right-style:initial;border-left-style:initial;
                                  border-top-color:initial;border-right-color:initial;border-left-color:initial;
                                  border-image: initial'>8 MP, f/1.9, 26mm (standard), 1/4&quot;, 1.12µm</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65></td>
                                  <td class=xl66>5 MP, 21mm (wide), f/2.2, 1/5&quot;, 1.12µm</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a
                                  href=""https://www.gsmarena.com/glossary.php3?term=secondary-camera""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Features</span></a></td>
                                  <td class=xl66 data-spec=cam2features style='box-sizing: border-box;
                                  border-top-style:initial;border-right-style:initial;border-left-style:initial;
                                  border-top-color:initial;border-right-color:initial;border-left-color:initial;
                                  border-image: initial'>HDR</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a
                                  href=""https://www.gsmarena.com/glossary.php3?term=secondary-camera""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Video</span></a></td>
                                  <td class=xl66 data-spec=cam2video style='box-sizing: border-box;border-top-style:
                                  initial;border-right-style:initial;border-left-style:initial;border-color:
                                  initial;border-image: initial'>1080p@60fps</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65></td>
                                  <td class=xl66></td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'>SOUND</td>
                                  <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-top-color:initial;
                                  border-right-color:initial;border-left-color:initial;border-image: initial'><a
                                  href=""https://www.gsmarena.com/glossary.php3?term=loudspeaker""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Loudspeaker</span></a></td>
                                  <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-top-color:initial;
                                  border-right-color:initial;border-left-color:initial;border-image: initial'>Yes,
                                  with stereo speakers</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a
                                  href=""https://www.gsmarena.com/glossary.php3?term=audio-jack""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>3.5mm
                                  jack</span></a></td>
                                  <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-top-color:initial;
                                  border-right-color:initial;border-left-color:initial;border-image: initial'>Yes</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65></td>
                                  <td class=xl66 data-spec=optionalother style='box-sizing: border-box;
                                  border-top-style:initial;border-right-style:initial;border-left-style:initial;
                                  border-color:initial;border-image: initial'>32-bit/192kHz audio</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65></td>
                                  <td class=xl66>24-bit/192kHz audio recording</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65></td>
                                  <td class=xl66>Tuned with Meridian Audio</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'>COMMS</td>
                                  <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-top-color:initial;
                                  border-right-color:initial;border-left-color:initial;border-image: initial'><a
                                  href=""https://www.gsmarena.com/glossary.php3?term=wi-fi"" style='box-sizing: border-box'><span
                                  style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                                  mso-font-charset:0'>WLAN</span></a></td>
                                  <td class=xl66 data-spec=wlan style='box-sizing: border-box;border-top-style:
                                  initial;border-right-style:initial;border-left-style:initial;border-top-color:
                                  initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Wi-Fi
                                  802.11 a/b/g/n/ac, dual-band, Wi-Fi Direct, DLNA, hotspot</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=bluetooth""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Bluetooth</span></a></td>
                                  <td class=xl66 data-spec=bluetooth style='box-sizing: border-box;border-top-style:
                                  initial;border-right-style:initial;border-left-style:initial;border-top-color:
                                  initial;border-right-color:initial;border-left-color:initial;border-image: initial'>5.0,
                                  A2DP, LE, aptX HD</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=gps""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>GPS</span></a></td>
                                  <td class=xl66 data-spec=gps style='box-sizing: border-box;border-top-style:
                                  initial;border-right-style:initial;border-left-style:initial;border-top-color:
                                  initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Yes,
                                  with A-GPS, GLONASS, GALILEO</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=nfc""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>NFC</span></a></td>
                                  <td class=xl66 data-spec=nfc style='box-sizing: border-box;border-top-style:
                                  initial;border-right-style:initial;border-left-style:initial;border-top-color:
                                  initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Yes</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=fm-radio""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Radio</span></a></td>
                                  <td class=xl66 data-spec=radio style='box-sizing: border-box;border-top-style:
                                  initial;border-right-style:initial;border-left-style:initial;border-top-color:
                                  initial;border-right-color:initial;border-left-color:initial;border-image: initial'>FM
                                  radio</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=usb""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>USB</span></a></td>
                                  <td class=xl66 data-spec=usb style='box-sizing: border-box;border-top-style:
                                  initial;border-right-style:initial;border-left-style:initial;border-color:
                                  initial;border-image: initial'>3.1, Type-C 1.0 reversible connector</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65></td>
                                  <td class=xl66></td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'>FEATURES</td>
                                  <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-color:initial;
                                  border-image: initial'><a
                                  href=""https://www.gsmarena.com/glossary.php3?term=sensors"" style='box-sizing: border-box'><span
                                  style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                                  mso-font-charset:0'>Sensors</span></a></td>
                                  <td class=xl66 data-spec=sensors style='box-sizing: border-box;border-top-style:
                                  initial;border-right-style:initial;border-left-style:initial;border-color:
                                  initial;border-image: initial'>Fingerprint (rear-mounted), accelerometer,
                                  gyro, proximity, compass, barometer</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65></td>
                                  <td class=xl66></td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'>BATTERY</td>
                                  <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-top-color:initial;
                                  border-right-color:initial;border-left-color:initial;border-image: initial'></td>
                                  <td class=xl66 data-spec=batdescription1 style='box-sizing: border-box;
                                  border-top-style:initial;border-right-style:initial;border-left-style:initial;
                                  border-top-color:initial;border-right-color:initial;border-left-color:initial;
                                  border-image: initial'>Non-removable Li-Po 4000 mAh battery</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a
                                  href=""https://www.gsmarena.com/glossary.php3?term=battery-charging""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Charging</span></a></td>
                                  <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-color:initial;
                                  border-image: initial'>Fast battery charging 18W: 50% in 36 min (Quick Charge
                                  3.0)</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65></td>
                                  <td class=xl66>USB Power Delivery 2.0</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65></td>
                                  <td class=xl66>Qi fast wireless charging 10W</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65></td>
                                  <td class=xl66></td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'>MISC</td>
                                  <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-top-color:initial;
                                  border-right-color:initial;border-left-color:initial;border-image: initial'><a
                                  href=""https://www.gsmarena.com/glossary.php3?term=build"" style='box-sizing: border-box'><span
                                  style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                                  mso-font-charset:0'>Colors</span></a></td>
                                  <td class=xl66 data-spec=colors style='box-sizing: border-box;border-top-style:
                                  initial;border-right-style:initial;border-left-style:initial;border-top-color:
                                  initial;border-right-color:initial;border-left-color:initial;border-image: initial'>New
                                  Aurora Black</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=models""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Models</span></a></td>
                                  <td class=xl66 data-spec=models style='box-sizing: border-box;border-top-style:
                                  initial;border-right-style:initial;border-left-style:initial;border-top-color:
                                  initial;border-right-color:initial;border-left-color:initial;border-image: initial'>LM-V500,
                                  LM-V500N, LM-V500EM, LM-V500XM, LM-V450PM, LM-V450</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=price""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Price</span></a></td>
                                  <td class=xl66 data-spec=price style='box-sizing: border-box;border-top-style:
                                  initial;border-right-style:initial;border-left-style:initial;border-color:
                                  initial;border-image: initial'><a
                                  href=""https://www.gsmarena.com/lg_v50_thinq_5g-price-9607.php""
                                  style='box-sizing: border-box'><span style='color:black;text-decoration:none'>$ 558.95
                                  / £ 721.38</span></a></td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65></td>
                                  <td class=xl66></td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'>TESTS</td>
                                  <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-top-color:initial;
                                  border-right-color:initial;border-left-color:initial;border-image: initial'><a
                                  href=""https://www.gsmarena.com/glossary.php3?term=benchmarking""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Performance</span></a></td>
                                  <td class=xl66 data-spec=tbench style='box-sizing: border-box;border-top-style:
                                  initial;border-right-style:initial;border-left-style:initial;border-top-color:
                                  initial;border-right-color:initial;border-left-color:initial;border-image: initial'>AnTuTu:
                                  343758 (v7), 421934 (v8)</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65></td>
                                  <td class=xl66>GeekBench: 10928 (v4.4), 2672 (v5.1)</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65></td>
                                  <td class=xl66>GFXBench: 22fps (ES 3.1 onscreen)</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a
                                  href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p2.php""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Display</span></a></td>
                                  <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-top-color:initial;
                                  border-right-color:initial;border-left-color:initial;border-image: initial'><a
                                  href=""https://www.gsmarena.com/lg_v50_thinq_5g-review-2047p4.php#dt""
                                  style='box-sizing: border-box'><span style='color:black;text-decoration:none'>Contrast
                                  ratio: 194000:1 (nominal)</span></a></td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a
                                  href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p5.php""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Camera</span></a></td>
                                  <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-top-color:initial;
                                  border-right-color:initial;border-left-color:initial;border-image: initial'>Photo&nbsp;/&nbsp;Video</td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a
                                  href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p3.php""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Loudspeaker</span></a></td>
                                  <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-top-color:initial;
                                  border-right-color:initial;border-left-color:initial;border-image: initial'><a
                                  href=""https://www.gsmarena.com/lg_v50_thinq_5g-review-2047p4.php#lt""
                                  style='box-sizing: border-box'><span style='color:black;text-decoration:none'>Voice
                                  70dB / Noise 74dB / Ring 78dB</span></a></td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a
                                  href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p4.php""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Audio
                                  quality</span></a></td>
                                  <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                                  border-right-style:initial;border-left-style:initial;border-top-color:initial;
                                  border-right-color:initial;border-left-color:initial;border-image: initial'><a
                                  href=""https://www.gsmarena.com/lg_v50_thinq_5g-review-2047p4.php#aq""
                                  style='box-sizing: border-box'><span style='color:black;text-decoration:none'>Noise
                                  -92.5dB / Crosstalk -92.6dB</span></a></td>
                                 </tr>
                                 <tr height=20 style='height:15.0pt'>
                                  <td height=20 class=xl65 style='height:15.0pt'></td>
                                  <td class=xl65><a
                                  href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p6.php""
                                  style='box-sizing: border-box'><span style='color:black;font-weight:700;
                                  text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Battery
                                  life</span></a></td>
                                  <td class=xl66 data-spec=batlife style='box-sizing: border-box;border-top-style:
                                  initial;border-right-style:initial;border-left-style:initial;border-top-color:
                                  initial;border-right-color:initial;border-left-color:initial;border-image: initial'>
                                  <div style='box-sizing: border-box'><a
                                  href=""https://www.gsmarena.com/lg_v50_thinq_5g-9607.php""
                                  onclick=""showBatteryPopup(event, 9607); "" style='box-sizing: border-box'><span
                                  style='color:black;text-decoration:none'>Endurance rating 96h</span></a></div>
                                  </td>
                                 </tr>
                                <!--EndFragment-->
                                </table>", new Guid("d492d607-44ca-465c-b689-b672aaccded2"), new DateTime(2020, 2, 28, 0, 50, 35, 779, DateTimeKind.Local).AddTicks(2152) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 28, 0, 50, 35, 779, DateTimeKind.Local).AddTicks(2232), @"
                            <table border=0 cellpadding=0 cellspacing=0 width=786 style='border-collapse:
                             collapse;width:590pt;box-sizing: border-box;border-image: initial;font-variant-ligatures: normal;
                             font-variant-caps: normal;font-variant-numeric: inherit;font-variant-east-asian: inherit;
                             font-stretch: inherit;line-height:inherit;orphans: 2;text-align:start;
                             widows: 2;-webkit-text-stroke-width: 0px;text-decoration-style: initial;
                             text-decoration-color: initial;max-height: 28px'>
                            <!--StartFragment-->
                             <col width=103 style='mso-width-source:userset;mso-width-alt:3766;width:77pt'>
                             <col width=90 style='mso-width-source:userset;mso-width-alt:3291;width:68pt'>
                             <col width=593 style='mso-width-source:userset;mso-width-alt:21686;width:445pt'>
                             <tr height=20 style='height:15.0pt;box-sizing: border-box'>
                              <td height=20 class=xl65 width=103 style='height:15.0pt;width:77pt'>NETWORK</td>
                              <td class=xl65 width=90 style='width:68pt;box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial;
                              transition: all 0.15s ease-out 0s'><a
                              href=""https://www.gsmarena.com/network-bands.php3"" style='box-sizing: border-box'><span
                              style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Technology</span></a></td>
                              <td class=xl66 width=593 style='width:445pt;box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial;transition: all 0.15s ease-out 0s'><a
                              href=""https://www.gsmarena.com/lg_v40_thinq-9300.php"" data-spec=nettech
                              style='box-sizing: border-box'><span style='color:black;text-decoration:none'>GSM
                              / CDMA / HSPA / EVDO / LTE</span></a></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td class=xl66></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'>LAUNCH</td>
                              <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=phone-life-cycle""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Announced</span></a></td>
                              <td class=xl66 data-spec=year style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>2018,
                              October</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a
                              href=""https://www.gsmarena.com/glossary.php3?term=phone-life-cycle""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Status</span></a></td>
                              <td class=xl66 data-spec=status style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-color:
                              initial;border-image: initial'>Available. Released 2018, October</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'>BODY</td>
                              <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/lg_v40_thinq-9300.php""
                              onclick=""helpW('h_dimens.htm');"" style='box-sizing: border-box'><span
                              style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Dimensions</span></a></td>
                              <td class=xl66 data-spec=dimensions style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>158.8
                              x 75.7 x 7.6 mm (6.25 x 2.98 x 0.30 in)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/lg_v40_thinq-9300.php""
                              onclick=""helpW('h_weight.htm');"" style='box-sizing: border-box'><span
                              style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Weight</span></a></td>
                              <td class=xl66 data-spec=weight style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>169
                              g (5.96 oz)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=build""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Build</span></a></td>
                              <td class=xl66 data-spec=build style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Glass
                              front (Gorilla Glass 5), glass back (Gorilla Glass 5), aluminum frame</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=sim""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>SIM</span></a></td>
                              <td class=xl66 data-spec=sim style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Single
                              SIM (Nano-SIM) or Dual SIM (Nano-SIM, dual stand-by)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td class=xl66 data-spec=bodyother style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-color:
                              initial;border-image: initial'>IP68 dust/water resistant (up to 1.5m for 30
                              mins)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td class=xl66>MIL-STD-810G compliant</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td class=xl66></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'>DISPLAY</td>
                              <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=display-type""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Type</span></a></td>
                              <td class=xl66 data-spec=displaytype style='box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial'>P-OLED capacitive touchscreen, 16M colors</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/lg_v40_thinq-9300.php""
                              onclick=""helpW('h_dsize.htm');"" style='box-sizing: border-box'><span
                              style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Size</span></a></td>
                              <td class=xl66 data-spec=displaysize style='box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial'>6.4 inches, 100.5 cm<font class=""font6""><sup
                              style='box-sizing: border-box;font-style:inherit;font-variant:inherit;
                              font-weight:inherit;font-stretch: inherit'>2</sup></font><font class=""font5"">&nbsp;(~83.6%
                              screen-to-body ratio)</font></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a
                              href=""https://www.gsmarena.com/glossary.php3?term=resolution""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Resolution</span></a></td>
                              <td class=xl66 data-spec=displayresolution style='box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial'>1440 x 3120 pixels, 19.5:9 ratio (~537 ppi density)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a
                              href=""https://www.gsmarena.com/glossary.php3?term=screen-protection""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Protection</span></a></td>
                              <td class=xl66 data-spec=displayprotection style='box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial'>Corning Gorilla Glass 5</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td class=xl66 data-spec=displayother style='box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-color:initial;border-image: initial'>Dolby Vision</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td class=xl66>HDR10</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td class=xl66>Always-on display</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'>PLATFORM</td>
                              <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=os"" style='box-sizing: border-box'><span
                              style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>OS</span></a></td>
                              <td class=xl66 data-spec=os style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Android
                              8.1 (Oreo), upgradable to Android 9.0 (Pie)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=chipset""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Chipset</span></a></td>
                              <td class=xl66 data-spec=chipset style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Qualcomm
                              SDM845 Snapdragon 845 (10 nm)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=cpu""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>CPU</span></a></td>
                              <td class=xl66 data-spec=cpu style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Octa-core
                              (4x2.8 GHz Kryo 385 Gold &amp; 4x1.7 GHz Kryo 385 Silver)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=gpu""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>GPU</span></a></td>
                              <td class=xl66 data-spec=gpu style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-color:
                              initial;border-image: initial'>Adreno 630</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'>MEMORY</td>
                              <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=memory-card-slot""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Card
                              slot</span></a></td>
                              <td class=xl66 data-spec=memoryslot style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>microSDXC
                              (dedicated slot)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a
                              href=""https://www.gsmarena.com/glossary.php3?term=dynamic-memory""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Internal</span></a></td>
                              <td class=xl66 data-spec=internalmemory style='box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial'>64GB 6GB RAM, 128GB 6GB RAM</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td class=xl66 data-spec=memoryother style='box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-color:initial;border-image: initial'>UFS 2.1</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td class=xl66></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'>MAIN CAMERA</td>
                              <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=camera"" style='box-sizing: border-box'><span
                              style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Triple</span></a></td>
                              <td class=xl66 data-spec=cam1modules style='box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial'>12 MP, 27mm (standard), f/1.5, 1/2.55&quot;, 1.4µm,
                              dual pixel PDAF, 3-axis OIS</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td class=xl66>12 MP, 52mm (telephoto), f/2.4, 1.0µm, 2x optical zoom, PDAF,
                              OIS</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td class=xl66>16 MP, 16mm (ultrawide), f/1.9, 1/3.1&quot;, 1.0µm, no AF</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=camera""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Features</span></a></td>
                              <td class=xl66 data-spec=cam1features style='box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial'>LED flash, HDR, panorama</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=camera""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Video</span></a></td>
                              <td class=xl66 data-spec=cam1video style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-color:
                              initial;border-image: initial'>2160p@30/60fps, 1080p@30/60/240fps,
                              24-bit/192kHz stereo sound rec., HDR video, gyro-EIS</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td class=xl66></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'>SELFIE CAMERA</td>
                              <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=secondary-camera""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Dual</span></a></td>
                              <td class=xl66 data-spec=cam2modules style='box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial'>8 MP, f/1.9, 26mm (standard), 1/3.2&quot;, 1.4µm</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td class=xl66>5 MP, 21mm (wide), f/2.2, 1.4µm</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a
                              href=""https://www.gsmarena.com/glossary.php3?term=secondary-camera""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Features</span></a></td>
                              <td class=xl66 data-spec=cam2features style='box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial'>HDR</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a
                              href=""https://www.gsmarena.com/glossary.php3?term=secondary-camera""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Video</span></a></td>
                              <td class=xl66 data-spec=cam2video style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-color:
                              initial;border-image: initial'>1080p@30fps</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td class=xl66></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'>SOUND</td>
                              <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=loudspeaker""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Loudspeaker</span></a></td>
                              <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'>Yes</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a
                              href=""https://www.gsmarena.com/glossary.php3?term=audio-jack""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>3.5mm
                              jack</span></a></td>
                              <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'>Yes</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td class=xl66 data-spec=optionalother style='box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-color:initial;border-image: initial'>32-bit/192kHz audio</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td class=xl66>24-bit/48kHz audio recording</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td class=xl66>Tuned with Meridian Audio</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'>COMMS</td>
                              <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=wi-fi"" style='box-sizing: border-box'><span
                              style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>WLAN</span></a></td>
                              <td class=xl66 data-spec=wlan style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Wi-Fi
                              802.11 a/b/g/n/ac, dual-band, Wi-Fi Direct, DLNA, hotspot</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=bluetooth""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Bluetooth</span></a></td>
                              <td class=xl66 data-spec=bluetooth style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>5.0,
                              A2DP, LE, aptX HD</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=gps""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>GPS</span></a></td>
                              <td class=xl66 data-spec=gps style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Yes,
                              with A-GPS, GLONASS, GALILEO</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=nfc""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>NFC</span></a></td>
                              <td class=xl66 data-spec=nfc style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Yes</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=fm-radio""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Radio</span></a></td>
                              <td class=xl66 data-spec=radio style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Stereo
                              FM radio with RDS</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=usb""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>USB</span></a></td>
                              <td class=xl66 data-spec=usb style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-color:
                              initial;border-image: initial'>2.0, Type-C 1.0 reversible connector</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td class=xl66></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'>FEATURES</td>
                              <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-color:initial;
                              border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=sensors"" style='box-sizing: border-box'><span
                              style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Sensors</span></a></td>
                              <td class=xl66 data-spec=sensors style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-color:
                              initial;border-image: initial'>Fingerprint (rear-mounted), accelerometer,
                              gyro, proximity, compass, barometer</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td class=xl66></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'>BATTERY</td>
                              <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'></td>
                              <td class=xl66 data-spec=batdescription1 style='box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial'>Non-removable Li-Po 3300 mAh battery</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a
                              href=""https://www.gsmarena.com/glossary.php3?term=battery-charging""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Charging</span></a></td>
                              <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-color:initial;
                              border-image: initial'>Fast battery charging 18W: 50% in 36 min (Quick Charge
                              3.0)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td class=xl66>USB Power Delivery 2.0</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td class=xl66>Qi fast wireless charging 10W</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td class=xl66></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'>MISC</td>
                              <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=build"" style='box-sizing: border-box'><span
                              style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Colors</span></a></td>
                              <td class=xl66 data-spec=colors style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>New
                              Platinum Gray, Carmine Red, New Aurora Black, New Moroccan Blue</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=models""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Models</span></a></td>
                              <td class=xl66 data-spec=models style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>V405,
                              LM-V405, LM-V409N</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=price""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Price</span></a></td>
                              <td class=xl66 data-spec=price style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-color:
                              initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/lg_v40_thinq-price-9300.php"" style='box-sizing: border-box'><span
                              style='color:black;text-decoration:none'>$ 218.95 / € 359.71 / £ 250.00 /
                              ₹ 29,999</span></a></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td class=xl66></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'>TESTS</td>
                              <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=benchmarking""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Performance</span></a></td>
                              <td class=xl66 data-spec=tbench style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>AnTuTu:
                              254304 (v7)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td class=xl66>GeekBench: 8568 (v4.4)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td class=xl66>GFXBench: 16fps (ES 3.1 onscreen)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a
                              href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p2.php""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Display</span></a></td>
                              <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/lg_v40_thinq-review-1855p3.php""
                              style='box-sizing: border-box'><span style='color:black;text-decoration:none'>Contrast
                              ratio: 161500:1 (nominal), 4.256 (sunlight)</span></a></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a
                              href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p5.php""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Camera</span></a></td>
                              <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'>Photo&nbsp;/&nbsp;Video</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a
                              href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p3.php""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Loudspeaker</span></a></td>
                              <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/lg_v40_thinq-review-1855p3.php#ls""
                              style='box-sizing: border-box'><span style='color:black;text-decoration:none'>Voice
                              68dB / Noise 74dB / Ring 77dB</span></a></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a
                              href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p4.php""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Audio
                              quality</span></a></td>
                              <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/lg_v40_thinq-review-1855p3.php#aq""
                              style='box-sizing: border-box'><span style='color:black;text-decoration:none'>Noise
                              -93.3dB / Crosstalk -94.1dB</span></a></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a
                              href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p6.php""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Battery
                              life</span></a></td>
                              <td class=xl66 data-spec=batlife style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>
                              <div style='box-sizing: border-box'><a
                              href=""https://www.gsmarena.com/lg_v40_thinq-9300.php""
                              onclick=""showBatteryPopup(event, 9300); "" style='box-sizing: border-box'><span
                              style='color:black;text-decoration:none'>Endurance rating 64h</span></a></div>
                              </td>
                             </tr>
                            <!--EndFragment-->
                            </table>", new Guid("eab2ef4e-a0a1-4902-b625-2d97fe17670e"), new DateTime(2020, 2, 28, 0, 50, 35, 779, DateTimeKind.Local).AddTicks(2236) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 28, 0, 50, 35, 779, DateTimeKind.Local).AddTicks(2314), @"
                            <table border=0 cellpadding=0 cellspacing=0 width=639 style='border-collapse:
                             collapse;width:480pt;box-sizing: border-box;border-image: initial;font-variant-ligatures: normal;
                             font-variant-caps: normal;font-variant-numeric: inherit;font-variant-east-asian: inherit;
                             font-stretch: inherit;line-height:inherit;orphans: 2;text-align:start;
                             widows: 2;-webkit-text-stroke-width: 0px;text-decoration-style: initial;
                             text-decoration-color: initial;max-height: 28px'>
                            <!--StartFragment-->
                             <col width=102 style='mso-width-source:userset;mso-width-alt:3730;width:77pt'>
                             <col width=90 style='mso-width-source:userset;mso-width-alt:3291;width:68pt'>
                             <col width=447 style='mso-width-source:userset;mso-width-alt:16347;width:335pt'>
                             <tr height=20 style='height:15.0pt;box-sizing: border-box'>
                              <td height=20 class=xl65 width=102 style='height:15.0pt;width:77pt'>NETWORK</td>
                              <td class=xl65 width=90 style='width:68pt;box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial;
                              transition: all 0.15s ease-out 0s'><a
                              href=""https://www.gsmarena.com/network-bands.php3"" style='box-sizing: border-box'><span
                              style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Technology</span></a></td>
                              <td class=xl66 width=447 style='width:335pt;box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial;transition: all 0.15s ease-out 0s'><a
                              href=""https://www.gsmarena.com/nokia_7_2-9833.php"" data-spec=nettech
                              style='box-sizing: border-box'><span style='color:black;text-decoration:none'>GSM
                              / HSPA / LTE</span></a></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td class=xl66></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'>LAUNCH</td>
                              <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=phone-life-cycle""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Announced</span></a></td>
                              <td class=xl66 data-spec=year style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>2019,
                              September</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt;box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial' data-spec=year></td>
                              <td class=xl65><a
                              href=""https://www.gsmarena.com/glossary.php3?term=phone-life-cycle""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Status</span></a></td>
                              <td class=xl66 data-spec=status style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-color:
                              initial;border-image: initial'>Available. Released 2019, September</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt;box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-color:initial;border-image: initial' data-spec=status>BODY</td>
                              <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/nokia_7_2-9833.php""
                              onclick=""helpW('h_dimens.htm');"" style='box-sizing: border-box'><span
                              style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Dimensions</span></a></td>
                              <td class=xl66 data-spec=dimensions style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>159.9
                              x 75.2 x 8.3 mm (6.30 x 2.96 x 0.33 in)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt;box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial' data-spec=dimensions></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/nokia_7_2-9833.php""
                              onclick=""helpW('h_weight.htm');"" style='box-sizing: border-box'><span
                              style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Weight</span></a></td>
                              <td class=xl66 data-spec=weight style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>180
                              g (6.35 oz)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt;box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial' data-spec=weight></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=build""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Build</span></a></td>
                              <td class=xl66 data-spec=build style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Glass
                              front (Gorilla Glass 3), glass back (Gorilla Glass 3), plastic frame</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt;box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial' data-spec=build></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=sim""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>SIM</span></a></td>
                              <td class=xl66 data-spec=sim style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-color:
                              initial;border-image: initial'>Single SIM (Nano-SIM) or Dual SIM (Nano-SIM,
                              dual stand-by)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt;box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-color:initial;border-image: initial' data-spec=sim></td>
                              <td class=xl65></td>
                              <td class=xl66></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'>DISPLAY</td>
                              <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=display-type""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Type</span></a></td>
                              <td class=xl66 data-spec=displaytype style='box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial'>IPS LCD capacitive touchscreen, 16M colors</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt;box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial' data-spec=displaytype></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/nokia_7_2-9833.php""
                              onclick=""helpW('h_dsize.htm');"" style='box-sizing: border-box'><span
                              style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Size</span></a></td>
                              <td class=xl66 data-spec=displaysize style='box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial'>6.3 inches, 99.1 cm<font class=""font6""><sup
                              style='box-sizing: border-box;font-style:inherit;font-variant:inherit;
                              font-weight:inherit;font-stretch: inherit'>2</sup></font><font class=""font5"">&nbsp;(~82.4%
                              screen-to-body ratio)</font></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a
                              href=""https://www.gsmarena.com/glossary.php3?term=resolution""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Resolution</span></a></td>
                              <td class=xl66 data-spec=displayresolution style='box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial'>1080 x 2280 pixels, 19:9 ratio (~400 ppi density)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt;box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial' data-spec=displayresolution></td>
                              <td class=xl65><a
                              href=""https://www.gsmarena.com/glossary.php3?term=screen-protection""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Protection</span></a></td>
                              <td class=xl66 data-spec=displayprotection style='box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial'>Corning Gorilla Glass 3</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt;box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial' data-spec=displayprotection></td>
                              <td class=xl65></td>
                              <td class=xl66 data-spec=displayother style='box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-color:initial;border-image: initial'>HDR10</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td class=xl66>Always-on display</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'>PLATFORM</td>
                              <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=os"" style='box-sizing: border-box'><span
                              style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>OS</span></a></td>
                              <td class=xl66 data-spec=os style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Android
                              9.0 (Pie); Android One</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt;box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial' data-spec=os></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=chipset""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Chipset</span></a></td>
                              <td class=xl66 data-spec=chipset style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Qualcomm
                              SDM660 Snapdragon 660 (14 nm)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt;box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial' data-spec=chipset></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=cpu""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>CPU</span></a></td>
                              <td class=xl66 data-spec=cpu style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Octa-core
                              (4x2.2 GHz Kryo 260 Gold &amp; 4x1.8 GHz Kryo 260 Silver)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt;box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial' data-spec=cpu></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=gpu""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>GPU</span></a></td>
                              <td class=xl66 data-spec=gpu style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-color:
                              initial;border-image: initial'>Adreno 512</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt;box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-color:initial;border-image: initial' data-spec=gpu>MEMORY</td>
                              <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=memory-card-slot""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Card
                              slot</span></a></td>
                              <td class=xl66 data-spec=memoryslot style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>microSDXC
                              (dedicated slot)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt;box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial' data-spec=memoryslot></td>
                              <td class=xl65><a
                              href=""https://www.gsmarena.com/glossary.php3?term=dynamic-memory""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Internal</span></a></td>
                              <td class=xl66 data-spec=internalmemory style='box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial'>64GB 4GB RAM, 64GB 6GB RAM, 128GB 6GB RAM</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt;box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial' data-spec=internalmemory></td>
                              <td class=xl65></td>
                              <td class=xl66 data-spec=memoryother style='box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-color:initial;border-image: initial'>eMMC 5.1</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt;box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-color:initial;border-image: initial' data-spec=memoryother></td>
                              <td class=xl65></td>
                              <td class=xl66></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'>MAIN CAMERA</td>
                              <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=camera"" style='box-sizing: border-box'><span
                              style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Triple</span></a></td>
                              <td class=xl66 data-spec=cam1modules style='box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial'>48 MP, f/1.8, (wide), 1/2.0&quot;, 0.8µm, PDAF</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td class=xl66>8 MP, f/2.2, 13mm (ultrawide), 1/4.0&quot;, 1.12µm</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td class=xl66>5 MP, f/2.4, (depth)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=camera""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Features</span></a></td>
                              <td class=xl66 data-spec=cam1features style='box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial'>Zeiss optics, LED flash, panorama, HDR</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt;box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial' data-spec=cam1features></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=camera""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Video</span></a></td>
                              <td class=xl66 data-spec=cam1video style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-color:
                              initial;border-image: initial'>2160p@30fps, 1080p@30fps (gyro-EIS)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt;box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-color:initial;border-image: initial' data-spec=cam1video></td>
                              <td class=xl65></td>
                              <td class=xl66></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'>SELFIE CAMERA</td>
                              <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=secondary-camera""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Single</span></a></td>
                              <td class=xl66 data-spec=cam2modules style='box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial'>20 MP, f/2.0, (wide), 1/3&quot;, 0.9µm</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt;box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial' data-spec=cam2modules></td>
                              <td class=xl65><a
                              href=""https://www.gsmarena.com/glossary.php3?term=secondary-camera""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Features</span></a></td>
                              <td class=xl66 data-spec=cam2features style='box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial'>Zeiss optics, HDR</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt;box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial' data-spec=cam2features></td>
                              <td class=xl65><a
                              href=""https://www.gsmarena.com/glossary.php3?term=secondary-camera""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Video</span></a></td>
                              <td class=xl66 data-spec=cam2video style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-color:
                              initial;border-image: initial'>1080p@30fps</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt;box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-color:initial;border-image: initial' data-spec=cam2video></td>
                              <td class=xl65></td>
                              <td class=xl66></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'>SOUND</td>
                              <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=loudspeaker""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Loudspeaker</span></a></td>
                              <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'>Yes</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt;box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial'></td>
                              <td class=xl65><a
                              href=""https://www.gsmarena.com/glossary.php3?term=audio-jack""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>3.5mm
                              jack</span></a></td>
                              <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-color:initial;
                              border-image: initial'>Yes</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt;box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-color:initial;border-image: initial'></td>
                              <td class=xl65></td>
                              <td class=xl66></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'>COMMS</td>
                              <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=wi-fi"" style='box-sizing: border-box'><span
                              style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>WLAN</span></a></td>
                              <td class=xl66 data-spec=wlan style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Wi-Fi
                              802.11 b/g/n/ac, dual-band, Wi-Fi Direct, hotspot</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt;box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial' data-spec=wlan></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=bluetooth""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Bluetooth</span></a></td>
                              <td class=xl66 data-spec=bluetooth style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>5.0,
                              A2DP, EDR, LE, aptX</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt;box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial' data-spec=bluetooth></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=gps""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>GPS</span></a></td>
                              <td class=xl66 data-spec=gps style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Yes,
                              with A-GPS, GLONASS, GALILEO, BDS</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt;box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial' data-spec=gps></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=nfc""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>NFC</span></a></td>
                              <td class=xl66 data-spec=nfc style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Yes
                              (excl. India)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt;box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial' data-spec=nfc></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=fm-radio""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Radio</span></a></td>
                              <td class=xl66 data-spec=radio style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>FM
                              radio</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt;box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial' data-spec=radio></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=usb""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>USB</span></a></td>
                              <td class=xl66 data-spec=usb style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-color:
                              initial;border-image: initial'>2.0, Type-C 1.0 reversible connector, USB
                              On-The-Go</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt;box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-color:initial;border-image: initial' data-spec=usb></td>
                              <td class=xl65></td>
                              <td class=xl66></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'>FEATURES</td>
                              <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-color:initial;
                              border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=sensors"" style='box-sizing: border-box'><span
                              style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Sensors</span></a></td>
                              <td class=xl66 data-spec=sensors style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-color:
                              initial;border-image: initial'>Fingerprint (rear-mounted), accelerometer,
                              gyro, proximity, compass</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt;box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-color:initial;border-image: initial' data-spec=sensors></td>
                              <td class=xl65></td>
                              <td class=xl66></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'>BATTERY</td>
                              <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'></td>
                              <td class=xl66 data-spec=batdescription1 style='box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial'>Non-removable Li-Po 3500 mAh battery</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt;box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial' data-spec=batdescription1></td>
                              <td class=xl65><a
                              href=""https://www.gsmarena.com/glossary.php3?term=battery-charging""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Charging</span></a></td>
                              <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-color:initial;
                              border-image: initial'>Battery charging 10W</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt;box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-color:initial;border-image: initial'></td>
                              <td class=xl65></td>
                              <td class=xl66></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'>MISC</td>
                              <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=build"" style='box-sizing: border-box'><span
                              style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Colors</span></a></td>
                              <td class=xl66 data-spec=colors style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Cyan
                              Green, Charcoal, Ice</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt;box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial' data-spec=colors></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=models""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Models</span></a></td>
                              <td class=xl66 data-spec=models style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>TA-1193,
                              TA-1178, TA-1196, TA-1181</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt;box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial' data-spec=models></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=sar""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>SAR</span></a></td>
                              <td class=xl66 data-spec=sar-us style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>1.15
                              W/kg (head) &nbsp; &nbsp; 0.90 W/kg (body) &nbsp; &nbsp;</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt;box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial' data-spec=sar-us></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=sar""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>SAR
                              EU</span></a></td>
                              <td class=xl66 data-spec=sar-eu style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>0.99
                              W/kg (head) &nbsp; &nbsp; 1.44 W/kg (body) &nbsp; &nbsp;</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt;box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial' data-spec=sar-eu></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=price""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Price</span></a></td>
                              <td class=xl66 data-spec=price style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-color:
                              initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/nokia_7_2-price-9833.php"" style='box-sizing: border-box'><span
                              style='color:black;text-decoration:none'>$ 324.99 / € 240.00 / £ 203.99 /
                              ₹ 15,049</span></a></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td class=xl66></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'>TESTS</td>
                              <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=benchmarking""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Performance</span></a></td>
                              <td class=xl66 data-spec=tbench style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>AnTuTu:
                              139495 (v7), 164484 (v8)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td class=xl66>GeekBench: 5440 (v4.4), 1398 (v5.1)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td class=xl66>GFXBench: 8.1fps (ES 3.1 onscreen)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a
                              href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p2.php""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Display</span></a></td>
                              <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/nokia_7_2-9833.php"" style='box-sizing: border-box'><span
                              style='color:black;text-decoration:none'>Contrast ratio: 1342:1 (nominal)</span></a></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a
                              href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p5.php""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Camera</span></a></td>
                              <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'>Photo&nbsp;/&nbsp;Video</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a
                              href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p3.php""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Loudspeaker</span></a></td>
                              <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/nokia_7_2-9833.php"" style='box-sizing: border-box'><span
                              style='color:black;text-decoration:none'>Voice 66dB / Noise 71dB / Ring 85dB</span></a></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a
                              href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p4.php""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Audio
                              quality</span></a></td>
                              <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/nokia_7_2-9833.php"" style='box-sizing: border-box'><span
                              style='color:black;text-decoration:none'>Noise -93.0dB / Crosstalk -93.4dB</span></a></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a
                              href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p6.php""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Battery
                              life</span></a></td>
                              <td class=xl66 data-spec=batlife style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>
                              <div style='box-sizing: border-box'><a
                              href=""https://www.gsmarena.com/nokia_7_2-9833.php""
                              onclick=""showBatteryPopup(event, 9833); "" style='box-sizing: border-box'><span
                              style='color:black;text-decoration:none'>Endurance rating 69h</span></a></div>
                              </td>
                             </tr>
                            <!--EndFragment-->
                            </table>", new Guid("595fc82e-9e5c-4216-8479-0714896963f9"), new DateTime(2020, 2, 28, 0, 50, 35, 779, DateTimeKind.Local).AddTicks(2317) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Description", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 28, 0, 50, 35, 779, DateTimeKind.Local).AddTicks(2460), @"
                            <table border=0 cellpadding=0 cellspacing=0 width=639 style='border-collapse:
                             collapse;width:480pt;box-sizing: border-box;border-image: initial;font-variant-ligatures: normal;
                             font-variant-caps: normal;font-variant-numeric: inherit;font-variant-east-asian: inherit;
                             font-stretch: inherit;line-height:inherit;orphans: 2;text-align:start;
                             widows: 2;-webkit-text-stroke-width: 0px;text-decoration-style: initial;
                             text-decoration-color: initial;max-height: 28px'>
                            <!--StartFragment-->
                             <col width=102 style='mso-width-source:userset;mso-width-alt:3730;width:77pt'>
                             <col width=90 style='mso-width-source:userset;mso-width-alt:3291;width:68pt'>
                             <col width=447 style='mso-width-source:userset;mso-width-alt:16347;width:335pt'>
                             <tr height=20 style='height:15.0pt;box-sizing: border-box'>
                              <td height=20 class=xl65 width=102 style='height:15.0pt;width:77pt'>NETWORK</td>
                              <td class=xl65 width=90 style='width:68pt;box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial;
                              transition: all 0.15s ease-out 0s'><a
                              href=""https://www.gsmarena.com/network-bands.php3"" style='box-sizing: border-box'><span
                              style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Technology</span></a></td>
                              <td class=xl66 width=447 style='width:335pt;box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial;transition: all 0.15s ease-out 0s'><a
                              href=""https://www.gsmarena.com/nokia_6_2-9834.php"" data-spec=nettech
                              style='box-sizing: border-box'><span style='color:black;text-decoration:none'>GSM
                              / HSPA / LTE</span></a></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td class=xl66></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'>LAUNCH</td>
                              <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=phone-life-cycle""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Announced</span></a></td>
                              <td class=xl66 data-spec=year style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>2019,
                              September</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a
                              href=""https://www.gsmarena.com/glossary.php3?term=phone-life-cycle""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Status</span></a></td>
                              <td class=xl66 data-spec=status style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-color:
                              initial;border-image: initial'>Available. Released 2019, October</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'>BODY</td>
                              <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/nokia_6_2-9834.php""
                              onclick=""helpW('h_dimens.htm');"" style='box-sizing: border-box'><span
                              style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Dimensions</span></a></td>
                              <td class=xl66 data-spec=dimensions style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>159.9
                              x 75.1 x 8.3 mm (6.30 x 2.96 x 0.33 in)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/nokia_6_2-9834.php""
                              onclick=""helpW('h_weight.htm');"" style='box-sizing: border-box'><span
                              style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Weight</span></a></td>
                              <td class=xl66 data-spec=weight style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>180
                              g (6.35 oz)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=build""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Build</span></a></td>
                              <td class=xl66 data-spec=build style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Glass
                              front (Gorilla Glass 3), glass back (Gorilla Glass 3), plastic frame</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=sim""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>SIM</span></a></td>
                              <td class=xl66 data-spec=sim style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-color:
                              initial;border-image: initial'>Single SIM (Nano-SIM) or Dual SIM (Nano-SIM,
                              dual stand-by)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td class=xl66></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'>DISPLAY</td>
                              <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=display-type""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Type</span></a></td>
                              <td class=xl66 data-spec=displaytype style='box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial'>IPS LCD capacitive touchscreen, 16M colors</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/nokia_6_2-9834.php""
                              onclick=""helpW('h_dsize.htm');"" style='box-sizing: border-box'><span
                              style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Size</span></a></td>
                              <td class=xl66 data-spec=displaysize style='box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial'>6.3 inches, 99.1 cm<font class=""font6""><sup
                              style='box-sizing: border-box;font-style:inherit;font-variant:inherit;
                              font-weight:inherit;font-stretch: inherit'>2</sup></font><font class=""font5"">&nbsp;(~82.5%
                              screen-to-body ratio)</font></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a
                              href=""https://www.gsmarena.com/glossary.php3?term=resolution""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Resolution</span></a></td>
                              <td class=xl66 data-spec=displayresolution style='box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial'>1080 x 2280 pixels, 19:9 ratio (~400 ppi density)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a
                              href=""https://www.gsmarena.com/glossary.php3?term=screen-protection""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Protection</span></a></td>
                              <td class=xl66 data-spec=displayprotection style='box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial'>Corning Gorilla Glass 3</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td class=xl66 data-spec=displayother style='box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-color:initial;border-image: initial'>HDR10</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td class=xl66>Always-on display</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'>PLATFORM</td>
                              <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=os"" style='box-sizing: border-box'><span
                              style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>OS</span></a></td>
                              <td class=xl66 data-spec=os style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Android
                              9.0 (Pie); Android One</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=chipset""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Chipset</span></a></td>
                              <td class=xl66 data-spec=chipset style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Qualcomm
                              SDM636 Snapdragon 636 (14 nm)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=cpu""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>CPU</span></a></td>
                              <td class=xl66 data-spec=cpu style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Octa-core
                              (4x1.8 GHz Kryo 260 Gold &amp; 4x1.6 GHz Kryo 260 Silver)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=gpu""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>GPU</span></a></td>
                              <td class=xl66 data-spec=gpu style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-color:
                              initial;border-image: initial'>Adreno 509</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'>MEMORY</td>
                              <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=memory-card-slot""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Card
                              slot</span></a></td>
                              <td class=xl66 data-spec=memoryslot style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>microSDXC
                              (dedicated slot)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a
                              href=""https://www.gsmarena.com/glossary.php3?term=dynamic-memory""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Internal</span></a></td>
                              <td class=xl66 data-spec=internalmemory style='box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial'>32GB 3GB RAM, 64GB 4GB RAM, 128GB 4GB RAM</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td class=xl66 data-spec=memoryother style='box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-color:initial;border-image: initial'>eMMC 5.1</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td class=xl66></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'>MAIN CAMERA</td>
                              <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=camera"" style='box-sizing: border-box'><span
                              style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Triple</span></a></td>
                              <td class=xl66 data-spec=cam1modules style='box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial'>16 MP, f/1.8, 27mm (wide), 1.0µm, PDAF</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td class=xl66>8 MP, f/2.2, 13mm (ultrawide), 1/4.0&quot;, 1.12µm</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td class=xl66>5 MP, f/2.4, (depth)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=camera""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Features</span></a></td>
                              <td class=xl66 data-spec=cam1features style='box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial'>LED flash, panorama, HDR</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=camera""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Video</span></a></td>
                              <td class=xl66 data-spec=cam1video style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-color:
                              initial;border-image: initial'>2160p@30fps, 1080p@30fps</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td class=xl66></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'>SELFIE CAMERA</td>
                              <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=secondary-camera""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Single</span></a></td>
                              <td class=xl66 data-spec=cam2modules style='box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial'>8 MP, f/2.0, 1/4&quot;, 1.12µm</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a
                              href=""https://www.gsmarena.com/glossary.php3?term=secondary-camera""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Features</span></a></td>
                              <td class=xl66 data-spec=cam2features style='box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial'>HDR</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a
                              href=""https://www.gsmarena.com/glossary.php3?term=secondary-camera""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Video</span></a></td>
                              <td class=xl66 data-spec=cam2video style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-color:
                              initial;border-image: initial'>1080p@30fps</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td class=xl66></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'>SOUND</td>
                              <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=loudspeaker""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Loudspeaker</span></a></td>
                              <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'>Yes</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a
                              href=""https://www.gsmarena.com/glossary.php3?term=audio-jack""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>3.5mm
                              jack</span></a></td>
                              <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-color:initial;
                              border-image: initial'>Yes</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td class=xl66></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'>COMMS</td>
                              <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=wi-fi"" style='box-sizing: border-box'><span
                              style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>WLAN</span></a></td>
                              <td class=xl66 data-spec=wlan style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Wi-Fi
                              802.11 b/g/n/ac, dual-band, Wi-Fi Direct, hotspot</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=bluetooth""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Bluetooth</span></a></td>
                              <td class=xl66 data-spec=bluetooth style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>5.0,
                              A2DP, EDR, LE, aptX</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=gps""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>GPS</span></a></td>
                              <td class=xl66 data-spec=gps style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Yes,
                              with A-GPS, GLONASS, GALILEO, BDS</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=nfc""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>NFC</span></a></td>
                              <td class=xl66 data-spec=nfc style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Yes
                              (excl. India)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=fm-radio""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Radio</span></a></td>
                              <td class=xl66 data-spec=radio style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>FM
                              radio</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=usb""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>USB</span></a></td>
                              <td class=xl66 data-spec=usb style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-color:
                              initial;border-image: initial'>2.0, Type-C 1.0 reversible connector, USB
                              On-The-Go</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td class=xl66></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'>FEATURES</td>
                              <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-color:initial;
                              border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=sensors"" style='box-sizing: border-box'><span
                              style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Sensors</span></a></td>
                              <td class=xl66 data-spec=sensors style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-color:
                              initial;border-image: initial'>Fingerprint (rear-mounted), accelerometer,
                              gyro, proximity, compass</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td class=xl66></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td class=xl66></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'>BATTERY</td>
                              <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'></td>
                              <td class=xl66 data-spec=batdescription1 style='box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial'>Non-removable Li-Po 3500 mAh battery</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a
                              href=""https://www.gsmarena.com/glossary.php3?term=battery-charging""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Charging</span></a></td>
                              <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-color:initial;
                              border-image: initial'>Battery charging 10W</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td class=xl66></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'>MISC</td>
                              <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=build"" style='box-sizing: border-box'><span
                              style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Colors</span></a></td>
                              <td class=xl66 data-spec=colors style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Ceramic
                              Black, Ice</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=models""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Models</span></a></td>
                              <td class=xl66 data-spec=models style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>TA-1200,
                              TA-1198, TA-1201, TA-1187</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=sar""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>SAR</span></a></td>
                              <td class=xl66 data-spec=sar-us style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>1.04
                              W/kg (head) &nbsp; &nbsp; 1.05 W/kg (body) &nbsp; &nbsp;</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=sar""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>SAR
                              EU</span></a></td>
                              <td class=xl66 data-spec=sar-eu style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>0.97
                              W/kg (head) &nbsp; &nbsp; 1.42 W/kg (body) &nbsp; &nbsp;</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=price""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Price</span></a></td>
                              <td class=xl66 data-spec=price style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-color:
                              initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/nokia_6_2-price-9834.php"" style='box-sizing: border-box'><span
                              style='color:black;text-decoration:none'>$ 248.99 / € 215.99 / £ 179.99 /
                              ₹ 11,750</span></a></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td class=xl66></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'>TESTS</td>
                              <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=benchmarking""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Performance</span></a></td>
                              <td class=xl66 data-spec=tbench style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>AnTuTu:
                              114947 (v7), 140736 (v8)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td class=xl66>GeekBench: 4882 (v4.4)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65></td>
                              <td class=xl66>GFXBench: 5.7fps (ES 3.1 onscreen)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a
                              href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p2.php""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Display</span></a></td>
                              <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/nokia_6_2-review-2023p3.php#dt""
                              style='box-sizing: border-box'><span style='color:black;text-decoration:none'>Contrast
                              ratio: 1525:1 (nominal)</span></a></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a
                              href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p5.php""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Camera</span></a></td>
                              <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'>Photo&nbsp;/&nbsp;Video</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a
                              href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p3.php""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Loudspeaker</span></a></td>
                              <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/nokia_6_2-review-2023p3.php#lt""
                              style='box-sizing: border-box'><span style='color:black;text-decoration:none'>Voice
                              65dB / Noise 70dB / Ring 79dB</span></a></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a
                              href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p4.php""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Audio
                              quality</span></a></td>
                              <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/nokia_6_2-review-2023p3.php#aq""
                              style='box-sizing: border-box'><span style='color:black;text-decoration:none'>Noise
                              -91.0dB / Crosstalk -94.8dB</span></a></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl65 style='height:15.0pt'></td>
                              <td class=xl65><a
                              href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p6.php""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Battery
                              life</span></a></td>
                              <td class=xl66 data-spec=batlife style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>
                              <div style='box-sizing: border-box'><a
                              href=""https://www.gsmarena.com/nokia_6_2-9834.php""
                              onclick=""showBatteryPopup(event, 9834); "" style='box-sizing: border-box'><span
                              style='color:black;text-decoration:none'>Endurance rating 73h</span></a></div>
                              </td>
                             </tr>
                            <!--EndFragment-->
                            </table>", new Guid("1a5d935a-6f08-4574-9bca-a5e4391c084b"), new DateTime(2020, 2, 28, 0, 50, 35, 779, DateTimeKind.Local).AddTicks(2464) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 28, 0, 50, 35, 779, DateTimeKind.Local).AddTicks(2540), @"
                            <table border=0 cellpadding=0 cellspacing=0 width=738 style='border-collapse:
                             collapse;width:554pt;box-sizing: border-box;border-image: initial;font-variant-ligatures: normal;
                             font-variant-caps: normal;font-variant-numeric: inherit;font-variant-east-asian: inherit;
                             font-stretch: inherit;line-height:inherit;orphans: 2;text-align:start;
                             widows: 2;-webkit-text-stroke-width: 0px;text-decoration-style: initial;
                             text-decoration-color: initial;max-height: 28px'>
                            <!--StartFragment-->
                             <col width=103 style='mso-width-source:userset;mso-width-alt:3766;width:77pt'>
                             <col width=90 style='mso-width-source:userset;mso-width-alt:3291;width:68pt'>
                             <col width=545 style='mso-width-source:userset;mso-width-alt:19931;width:409pt'>
                             <tr height=20 style='height:15.0pt;box-sizing: border-box'>
                              <td height=20 class=xl67 width=103 style='height:15.0pt;width:77pt'>NETWORK</td>
                              <td class=xl67 width=90 style='width:68pt;box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial;
                              transition: all 0.15s ease-out 0s'><a
                              href=""https://www.gsmarena.com/network-bands.php3"" style='box-sizing: border-box'><span
                              style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Technology</span></a></td>
                              <td class=xl68 width=545 style='width:409pt;box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial;transition: all 0.15s ease-out 0s'><a
                              href=""https://www.gsmarena.com/apple_iphone_11_pro_max-9846.php""
                              data-spec=nettech style='box-sizing: border-box'><span style='color:black;
                              text-decoration:none'>GSM / CDMA / HSPA / EVDO / LTE</span></a></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67></td>
                              <td class=xl68></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'>LAUNCH</td>
                              <td class=xl67 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=phone-life-cycle""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Announced</span></a></td>
                              <td class=xl68 data-spec=year style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>2019,
                              September</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67><a
                              href=""https://www.gsmarena.com/glossary.php3?term=phone-life-cycle""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Status</span></a></td>
                              <td class=xl68 data-spec=status style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-color:
                              initial;border-image: initial'>Available. Released 2019, September</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'>BODY</td>
                              <td class=xl67 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/apple_iphone_11_pro_max-9846.php""
                              onclick=""helpW('h_dimens.htm');"" style='box-sizing: border-box'><span
                              style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Dimensions</span></a></td>
                              <td class=xl68 data-spec=dimensions style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>158
                              x 77.8 x 8.1 mm (6.22 x 3.06 x 0.32 in)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67><a
                              href=""https://www.gsmarena.com/apple_iphone_11_pro_max-9846.php""
                              onclick=""helpW('h_weight.htm');"" style='box-sizing: border-box'><span
                              style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Weight</span></a></td>
                              <td class=xl68 data-spec=weight style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>226
                              g (7.97 oz)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67><a href=""https://www.gsmarena.com/glossary.php3?term=build""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Build</span></a></td>
                              <td class=xl68 data-spec=build style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Glass
                              front (Gorilla Glass), glass back (Gorilla Glass), stainless steel frame</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67><a href=""https://www.gsmarena.com/glossary.php3?term=sim""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>SIM</span></a></td>
                              <td class=xl68 data-spec=sim style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Single
                              SIM (Nano-SIM and/or eSIM) or Dual SIM (Nano-SIM, dual stand-by) - for China</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67></td>
                              <td class=xl68 data-spec=bodyother style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-color:
                              initial;border-image: initial'>IP68 dust/water resistant (up to 4m for 30
                              mins)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67></td>
                              <td class=xl68>Apple Pay (Visa, MasterCard, AMEX certified)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67></td>
                              <td class=xl68></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'>DISPLAY</td>
                              <td class=xl67 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=display-type""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Type</span></a></td>
                              <td class=xl68 data-spec=displaytype style='box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial'>Super Retina XDR OLED capacitive touchscreen, 16M
                              colors</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67><a
                              href=""https://www.gsmarena.com/apple_iphone_11_pro_max-9846.php""
                              onclick=""helpW('h_dsize.htm');"" style='box-sizing: border-box'><span
                              style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Size</span></a></td>
                              <td class=xl68 data-spec=displaysize style='box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial'>6.5 inches, 102.9 cm<font class=""font6""><sup
                              style='box-sizing: border-box;font-style:inherit;font-variant:inherit;
                              font-weight:inherit;font-stretch: inherit'>2</sup></font><font class=""font5"">&nbsp;(~83.7%
                              screen-to-body ratio)</font></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67><a
                              href=""https://www.gsmarena.com/glossary.php3?term=resolution""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Resolution</span></a></td>
                              <td class=xl68 data-spec=displayresolution style='box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial'>1242 x 2688 pixels, 19.5:9 ratio (~458 ppi density)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67><a
                              href=""https://www.gsmarena.com/glossary.php3?term=screen-protection""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Protection</span></a></td>
                              <td class=xl68 data-spec=displayprotection style='box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial'>Scratch-resistant glass, oleophobic coating</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67></td>
                              <td class=xl68 data-spec=displayother style='box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-color:initial;border-image: initial'>800 nits max brightness</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67></td>
                              <td class=xl68>Dolby Vision</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67></td>
                              <td class=xl68>HDR10</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67></td>
                              <td class=xl68>Wide color gamut</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67></td>
                              <td class=xl68>True-tone</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67></td>
                              <td class=xl68>120Hz touch-sensing</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'>PLATFORM</td>
                              <td class=xl67 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=os"" style='box-sizing: border-box'><span
                              style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>OS</span></a></td>
                              <td class=xl68 data-spec=os style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>iOS
                              13, upgradable to iOS 13.3</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67><a href=""https://www.gsmarena.com/glossary.php3?term=chipset""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Chipset</span></a></td>
                              <td class=xl68 data-spec=chipset style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Apple
                              A13 Bionic (7 nm+)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67><a href=""https://www.gsmarena.com/glossary.php3?term=cpu""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>CPU</span></a></td>
                              <td class=xl68 data-spec=cpu style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Hexa-core
                              (2x2.65 GHz Lightning + 4x1.8 GHz Thunder)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67><a href=""https://www.gsmarena.com/glossary.php3?term=gpu""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>GPU</span></a></td>
                              <td class=xl68 data-spec=gpu style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-color:
                              initial;border-image: initial'>Apple GPU (4-core graphics)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'>MEMORY</td>
                              <td class=xl67 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=memory-card-slot""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Card
                              slot</span></a></td>
                              <td class=xl68 data-spec=memoryslot style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>No</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67><a
                              href=""https://www.gsmarena.com/glossary.php3?term=dynamic-memory""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Internal</span></a></td>
                              <td class=xl68 data-spec=internalmemory style='box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial'>64GB 4GB RAM, 256GB 4GB RAM, 512GB 4GB RAM</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67></td>
                              <td class=xl68 data-spec=memoryother style='box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-color:initial;border-image: initial'>NVMe</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67></td>
                              <td class=xl68></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'>MAIN CAMERA</td>
                              <td class=xl67 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=camera"" style='box-sizing: border-box'><span
                              style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Triple</span></a></td>
                              <td class=xl68 data-spec=cam1modules style='box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial'>12 MP, f/1.8, 26mm (wide), 1/2.55&quot;, 1.4µm, dual
                              pixel PDAF, OIS</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67></td>
                              <td class=xl68>12 MP, f/2.0, 52mm (telephoto), 1/3.4&quot;, 1.0µm, PDAF, OIS,
                              2x optical zoom</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67></td>
                              <td class=xl68>12 MP, f/2.4, 13mm (ultrawide)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67><a href=""https://www.gsmarena.com/glossary.php3?term=camera""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Features</span></a></td>
                              <td class=xl68 data-spec=cam1features style='box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial'>Quad-LED dual-tone flash, HDR (photo/panorama)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67><a href=""https://www.gsmarena.com/glossary.php3?term=camera""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Video</span></a></td>
                              <td class=xl68 data-spec=cam1video style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-color:
                              initial;border-image: initial'>2160p@24/30/60fps, 1080p@30/60/120/240fps,
                              HDR, stereo sound rec.</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67></td>
                              <td class=xl68></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'>SELFIE CAMERA</td>
                              <td class=xl67 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=secondary-camera""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Dual</span></a></td>
                              <td class=xl68 data-spec=cam2modules style='box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial'>12 MP, f/2.2, 23mm (wide)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67></td>
                              <td class=xl68>SL 3D, (depth/biometrics sensor)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67><a
                              href=""https://www.gsmarena.com/glossary.php3?term=secondary-camera""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Features</span></a></td>
                              <td class=xl68 data-spec=cam2features style='box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial'>HDR</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67><a
                              href=""https://www.gsmarena.com/glossary.php3?term=secondary-camera""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Video</span></a></td>
                              <td class=xl68 data-spec=cam2video style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-color:
                              initial;border-image: initial'>2160p@24/30/60fps, 1080p@30/60/120fps,
                              gyro-EIS</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67></td>
                              <td class=xl68></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'>SOUND</td>
                              <td class=xl67 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=loudspeaker""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Loudspeaker</span></a></td>
                              <td class=xl68 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'>Yes,
                              with stereo speakers</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67><a
                              href=""https://www.gsmarena.com/glossary.php3?term=audio-jack""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>3.5mm
                              jack</span></a></td>
                              <td class=xl68 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-color:initial;
                              border-image: initial'>No</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67></td>
                              <td class=xl68></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'>COMMS</td>
                              <td class=xl67 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=wi-fi"" style='box-sizing: border-box'><span
                              style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>WLAN</span></a></td>
                              <td class=xl68 data-spec=wlan style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Wi-Fi
                              802.11 a/b/g/n/ac/ax, dual-band, hotspot</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67><a href=""https://www.gsmarena.com/glossary.php3?term=bluetooth""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Bluetooth</span></a></td>
                              <td class=xl68 data-spec=bluetooth style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>5.0,
                              A2DP, LE</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67><a href=""https://www.gsmarena.com/glossary.php3?term=gps""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>GPS</span></a></td>
                              <td class=xl68 data-spec=gps style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Yes,
                              with A-GPS, GLONASS, GALILEO, QZSS</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67><a href=""https://www.gsmarena.com/glossary.php3?term=nfc""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>NFC</span></a></td>
                              <td class=xl68 data-spec=nfc style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Yes</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67><a href=""https://www.gsmarena.com/glossary.php3?term=fm-radio""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Radio</span></a></td>
                              <td class=xl68 data-spec=radio style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>No</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67><a href=""https://www.gsmarena.com/glossary.php3?term=usb""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>USB</span></a></td>
                              <td class=xl68 data-spec=usb style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-color:
                              initial;border-image: initial'>2.0, proprietary reversible connector</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67></td>
                              <td class=xl68></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'>FEATURES</td>
                              <td class=xl67 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=sensors"" style='box-sizing: border-box'><span
                              style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Sensors</span></a></td>
                              <td class=xl68 data-spec=sensors style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Face
                              ID, accelerometer, gyro, proximity, compass, barometer</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67></td>
                              <td class=xl68 data-spec=featuresother style='box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-color:initial;border-image: initial'>Siri natural language commands
                              and dictation</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67></td>
                              <td class=xl68></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'>BATTERY</td>
                              <td class=xl67 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'></td>
                              <td class=xl68 data-spec=batdescription1 style='box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial'>Non-removable Li-Ion 3969 mAh battery (15.04 Wh)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67><a
                              href=""https://www.gsmarena.com/glossary.php3?term=battery-charging""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Charging</span></a></td>
                              <td class=xl68 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'>Fast
                              battery charging 18W: 50% in 30 min</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67></td>
                              <td class=xl68>USB Power Delivery 2.0</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67></td>
                              <td class=xl68>Qi wireless charging</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67><a href=""https://www.gsmarena.com/glossary.php3?term=talk-time""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Talk
                              time</span></a></td>
                              <td class=xl68 data-spec=battalktime1 style='box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-top-color:initial;border-right-color:initial;border-left-color:initial;
                              border-image: initial'>Up to 20 h (multimedia)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67><a
                              href=""https://www.gsmarena.com/glossary.php3?term=music-playback-time""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Music
                              play</span></a></td>
                              <td class=xl68 data-spec=batmusicplayback1 style='box-sizing: border-box;
                              border-top-style:initial;border-right-style:initial;border-left-style:initial;
                              border-color:initial;border-image: initial'>Up to 80 h</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67></td>
                              <td class=xl68></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'>MISC</td>
                              <td class=xl67 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=build"" style='box-sizing: border-box'><span
                              style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                              mso-font-charset:0'>Colors</span></a></td>
                              <td class=xl68 data-spec=colors style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Space
                              Gray, Silver, Gold, Midnight Green (matte colors)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67><a href=""https://www.gsmarena.com/glossary.php3?term=models""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Models</span></a></td>
                              <td class=xl68 data-spec=models style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>A2218,
                              A2161, A2220</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67><a href=""https://www.gsmarena.com/glossary.php3?term=sar""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>SAR</span></a></td>
                              <td class=xl68 data-spec=sar-us style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>1.16
                              W/kg (head) &nbsp; &nbsp; 1.17 W/kg (body) &nbsp; &nbsp;</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67><a href=""https://www.gsmarena.com/glossary.php3?term=sar""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>SAR
                              EU</span></a></td>
                              <td class=xl68 data-spec=sar-eu style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>0.95
                              W/kg (head) &nbsp; &nbsp; 0.99 W/kg (body) &nbsp; &nbsp;</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67><a href=""https://www.gsmarena.com/glossary.php3?term=price""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Price</span></a></td>
                              <td class=xl68 data-spec=price style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-color:
                              initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/apple_iphone_11_pro_max-price-9846.php""
                              style='box-sizing: border-box'><span style='color:black;text-decoration:none'>$ 1,099.99
                              / € 1,184.99 / £ 1,049.00 / ₹ 106,900</span></a></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67></td>
                              <td class=xl68></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'>TESTS</td>
                              <td class=xl67 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/glossary.php3?term=benchmarking""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Performance</span></a></td>
                              <td class=xl68 data-spec=tbench style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>AnTuTu:
                              459713 (v7), 536883 (v8)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67></td>
                              <td class=xl68>GeekBench: 13870 (v4.4), 3503 (v5.1)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67></td>
                              <td class=xl68>GFXBench: 57fps (ES 3.1 onscreen)</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67><a
                              href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p2.php""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Display</span></a></td>
                              <td class=xl68 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/apple_iphone_11_pro_max-review-1991p3.php#dt""
                              style='box-sizing: border-box'><span style='color:black;text-decoration:none'>Contrast
                              ratio: Infinite (nominal)</span></a></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67><a
                              href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p5.php""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Camera</span></a></td>
                              <td class=xl68 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'>Photo&nbsp;/&nbsp;Video</td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67><a
                              href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p3.php""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Loudspeaker</span></a></td>
                              <td class=xl68 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/apple_iphone_11_pro_max-review-1991p3.php#lt""
                              style='box-sizing: border-box'><span style='color:black;text-decoration:none'>Voice
                              71dB / Noise 74dB / Ring 79dB</span></a></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67><a
                              href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p4.php""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Audio
                              quality</span></a></td>
                              <td class=xl68 style='box-sizing: border-box;border-top-style:initial;
                              border-right-style:initial;border-left-style:initial;border-top-color:initial;
                              border-right-color:initial;border-left-color:initial;border-image: initial'><a
                              href=""https://www.gsmarena.com/apple_iphone_11_pro_max-review-1991p3.php#aq""
                              style='box-sizing: border-box'><span style='color:black;text-decoration:none'>Noise
                              -94.3dB / Crosstalk -81.5dB</span></a></td>
                             </tr>
                             <tr height=20 style='height:15.0pt'>
                              <td height=20 class=xl67 style='height:15.0pt'></td>
                              <td class=xl67><a
                              href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p6.php""
                              style='box-sizing: border-box'><span style='color:black;font-weight:700;
                              text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Battery
                              life</span></a></td>
                              <td class=xl68 data-spec=batlife style='box-sizing: border-box;border-top-style:
                              initial;border-right-style:initial;border-left-style:initial;border-top-color:
                              initial;border-right-color:initial;border-left-color:initial;border-image: initial'>
                              <div style='box-sizing: border-box'><a
                              href=""https://www.gsmarena.com/apple_iphone_11_pro_max-9846.php""
                              onclick=""showBatteryPopup(event, 9846); "" style='box-sizing: border-box'><span
                              style='color:black;text-decoration:none'>Endurance rating 102h</span></a></div>
                              </td>
                             </tr>
                            <!--EndFragment-->
                            </table>", new Guid("052052f6-ef9b-45a6-bd78-08c5e0f842c4"), new DateTime(2020, 2, 28, 0, 50, 35, 779, DateTimeKind.Local).AddTicks(2543) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Description", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 28, 0, 50, 35, 779, DateTimeKind.Local).AddTicks(2618), @"
                        <table border=0 cellpadding=0 cellspacing=0 width=666 style='border-collapse:
                         collapse;width:501pt;box-sizing: border-box;border-image: initial;font-variant-ligatures: normal;
                         font-variant-caps: normal;font-variant-numeric: inherit;font-variant-east-asian: inherit;
                         font-stretch: inherit;line-height:inherit;orphans: 2;text-align:start;
                         widows: 2;-webkit-text-stroke-width: 0px;text-decoration-style: initial;
                         text-decoration-color: initial;max-height: 28px'>
                        <!--StartFragment-->
                         <col width=102 style='mso-width-source:userset;mso-width-alt:3730;width:77pt'>
                         <col width=90 style='mso-width-source:userset;mso-width-alt:3291;width:68pt'>
                         <col width=474 style='mso-width-source:userset;mso-width-alt:17334;width:356pt'>
                         <tr height=20 style='height:15.0pt;box-sizing: border-box'>
                          <td height=20 class=xl65 width=102 style='height:15.0pt;width:77pt'>NETWORK</td>
                          <td class=xl65 width=90 style='width:68pt;box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial;
                          transition: all 0.15s ease-out 0s'><a
                          href=""https://www.gsmarena.com/network-bands.php3"" style='box-sizing: border-box'><span
                          style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                          mso-font-charset:0'>Technology</span></a></td>
                          <td class=xl66 width=474 style='width:356pt;box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial;transition: all 0.15s ease-out 0s'><a
                          href=""https://www.gsmarena.com/apple_iphone_x-8858.php"" data-spec=nettech
                          style='box-sizing: border-box'><span style='color:black;text-decoration:none'>GSM
                          / HSPA / LTE</span></a></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>LAUNCH</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=phone-life-cycle""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Announced</span></a></td>
                          <td class=xl66 data-spec=year style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>2017,
                          September</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/glossary.php3?term=phone-life-cycle""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Status</span></a></td>
                          <td class=xl66 data-spec=status style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-color:
                          initial;border-image: initial'>Available. Released 2017, October</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>BODY</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/apple_iphone_x-8858.php""
                          onclick=""helpW('h_dimens.htm');"" style='box-sizing: border-box'><span
                          style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                          mso-font-charset:0'>Dimensions</span></a></td>
                          <td class=xl66 data-spec=dimensions style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>143.6
                          x 70.9 x 7.7 mm (5.65 x 2.79 x 0.30 in)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/apple_iphone_x-8858.php""
                          onclick=""helpW('h_weight.htm');"" style='box-sizing: border-box'><span
                          style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                          mso-font-charset:0'>Weight</span></a></td>
                          <td class=xl66 data-spec=weight style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>174
                          g (6.14 oz)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=build""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Build</span></a></td>
                          <td class=xl66 data-spec=build style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Glass
                          front (Gorilla Glass), glass back (Gorilla Glass), stainless steel frame</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=sim""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>SIM</span></a></td>
                          <td class=xl66 data-spec=sim style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Nano-SIM</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66 data-spec=bodyother style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-color:
                          initial;border-image: initial'>IP67 dust/water resistant (up to 1m for 30
                          mins)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66>Apple Pay (Visa, MasterCard, AMEX certified)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>DISPLAY</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=display-type""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Type</span></a></td>
                          <td class=xl66 data-spec=displaytype style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial'>Super Retina OLED capacitive touchscreen, 16M colors</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/apple_iphone_x-8858.php""
                          onclick=""helpW('h_dsize.htm');"" style='box-sizing: border-box'><span
                          style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                          mso-font-charset:0'>Size</span></a></td>
                          <td class=xl66 data-spec=displaysize style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial'>5.8 inches, 84.4 cm<font class=""font6""><sup
                          style='box-sizing: border-box;font-style:inherit;font-variant:inherit;
                          font-weight:inherit;font-stretch: inherit'>2</sup></font><font class=""font5"">&nbsp;(~82.9%
                          screen-to-body ratio)</font></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/glossary.php3?term=resolution""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Resolution</span></a></td>
                          <td class=xl66 data-spec=displayresolution style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial'>1125 x 2436 pixels, 19.5:9 ratio (~458 ppi density)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/glossary.php3?term=screen-protection""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Protection</span></a></td>
                          <td class=xl66 data-spec=displayprotection style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial'>Scratch-resistant glass, oleophobic coating</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66 data-spec=displayother style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-color:initial;border-image: initial'>625 nits max brightness</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66>Dolby Vision</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66>HDR10</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66>Wide color gamut</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66>3D Touch</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66>True-tone</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66>120Hz touch-sensing</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>PLATFORM</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=os"" style='box-sizing: border-box'><span
                          style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                          mso-font-charset:0'>OS</span></a></td>
                          <td class=xl66 data-spec=os style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>iOS
                          11.1.1, upgradable to iOS 13.3</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=chipset""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Chipset</span></a></td>
                          <td class=xl66 data-spec=chipset style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Apple
                          A11 Bionic (10 nm)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=cpu""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>CPU</span></a></td>
                          <td class=xl66 data-spec=cpu style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Hexa-core
                          2.39 GHz (2x Monsoon + 4x Mistral)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=gpu""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>GPU</span></a></td>
                          <td class=xl66 data-spec=gpu style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-color:
                          initial;border-image: initial'>Apple GPU (three-core graphics)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>MEMORY</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=memory-card-slot""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Card
                          slot</span></a></td>
                          <td class=xl66 data-spec=memoryslot style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>No</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/glossary.php3?term=dynamic-memory""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Internal</span></a></td>
                          <td class=xl66 data-spec=internalmemory style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial'>64GB 3GB RAM, 256GB 3GB RAM</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66 data-spec=memoryother style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-color:initial;border-image: initial'>NVMe</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>MAIN CAMERA</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=camera"" style='box-sizing: border-box'><span
                          style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                          mso-font-charset:0'>Dual</span></a></td>
                          <td class=xl66 data-spec=cam1modules style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial'>12 MP, f/1.8, 28mm (wide), 1/3&quot;, 1.22µm, dual
                          pixel PDAF, OIS</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66>12 MP, f/2.4, 52mm (telephoto), 1/3.4&quot;, 1.0µm, PDAF, OIS,
                          2x optical zoom</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=camera""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Features</span></a></td>
                          <td class=xl66 data-spec=cam1features style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial'>Quad-LED dual-tone flash, HDR (photo/panorama),
                          panorama, HDR</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=camera""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Video</span></a></td>
                          <td class=xl66 data-spec=cam1video style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-color:
                          initial;border-image: initial'>2160p@24/30/60fps, 1080p@30/60/120/240fps</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>SELFIE CAMERA</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=secondary-camera""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Dual</span></a></td>
                          <td class=xl66 data-spec=cam2modules style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial'>7 MP, f/2.2, 32mm (standard)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66>SL 3D, (depth/biometrics sensor)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/glossary.php3?term=secondary-camera""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Features</span></a></td>
                          <td class=xl66 data-spec=cam2features style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial'>HDR</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/glossary.php3?term=secondary-camera""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Video</span></a></td>
                          <td class=xl66 data-spec=cam2video style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-color:
                          initial;border-image: initial'>1080p@30fps</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>SOUND</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=loudspeaker""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Loudspeaker</span></a></td>
                          <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'>Yes,
                          with stereo speakers</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/glossary.php3?term=audio-jack""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>3.5mm
                          jack</span></a></td>
                          <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-color:initial;
                          border-image: initial'>No</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>COMMS</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=wi-fi"" style='box-sizing: border-box'><span
                          style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                          mso-font-charset:0'>WLAN</span></a></td>
                          <td class=xl66 data-spec=wlan style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Wi-Fi
                          802.11 a/b/g/n/ac, dual-band, hotspot</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=bluetooth""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Bluetooth</span></a></td>
                          <td class=xl66 data-spec=bluetooth style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>5.0,
                          A2DP, LE</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=gps""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>GPS</span></a></td>
                          <td class=xl66 data-spec=gps style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Yes,
                          with A-GPS, GLONASS, GALILEO, QZSS</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=nfc""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>NFC</span></a></td>
                          <td class=xl66 data-spec=nfc style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Yes</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=fm-radio""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Radio</span></a></td>
                          <td class=xl66 data-spec=radio style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>No</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=usb""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>USB</span></a></td>
                          <td class=xl66 data-spec=usb style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-color:
                          initial;border-image: initial'>2.0, proprietary reversible connector</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>FEATURES</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=sensors"" style='box-sizing: border-box'><span
                          style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                          mso-font-charset:0'>Sensors</span></a></td>
                          <td class=xl66 data-spec=sensors style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Face
                          ID, accelerometer, gyro, proximity, compass, barometer</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66 data-spec=featuresother style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-color:initial;border-image: initial'>Siri natural language commands
                          and dictation</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>BATTERY</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'></td>
                          <td class=xl66 data-spec=batdescription1 style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial'>Non-removable Li-Ion 2716 mAh battery (10.35 Wh)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/glossary.php3?term=battery-charging""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Charging</span></a></td>
                          <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'>Fast
                          battery charging 15W: 50% in 30 min</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66>USB Power Delivery 2.0</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66>Qi wireless charging</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=talk-time""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Talk
                          time</span></a></td>
                          <td class=xl66 data-spec=battalktime1 style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial'>Up to 21 h (3G)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/glossary.php3?term=music-playback-time""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Music
                          play</span></a></td>
                          <td class=xl66 data-spec=batmusicplayback1 style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-color:initial;border-image: initial'>Up to 60 h</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>MISC</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=build"" style='box-sizing: border-box'><span
                          style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                          mso-font-charset:0'>Colors</span></a></td>
                          <td class=xl66 data-spec=colors style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Space
                          Gray, Silver</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=models""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Models</span></a></td>
                          <td class=xl66 data-spec=models style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>A1865,
                          A1901, A1902, A1903</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=sar""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>SAR</span></a></td>
                          <td class=xl66 data-spec=sar-us style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>1.09
                          W/kg (head) &nbsp; &nbsp; 1.17 W/kg (body) &nbsp; &nbsp;</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=price""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Price</span></a></td>
                          <td class=xl66 data-spec=price style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-color:
                          initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/apple_iphone_x-price-8858.php""
                          style='box-sizing: border-box'><span style='color:black;text-decoration:none'>$ 398.00
                          / € 455.00 / £ 649.97 / ₹ 69,558</span></a></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>TESTS</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=benchmarking""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Performance</span></a></td>
                          <td class=xl66 data-spec=tbench style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>AnTuTu:
                          233100 (v7)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66>GeekBench: 10215 (v4.4)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66>GFXBench: 28fps (ES 3.1 onscreen)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p2.php""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Display</span></a></td>
                          <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/apple_iphone_x-review-1681p3.php#dt""
                          style='box-sizing: border-box'><span style='color:black;text-decoration:none'>Contrast
                          ratio: Infinity (nominal), 5.013 (sunlight)</span></a></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p5.php""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Camera</span></a></td>
                          <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'>Photo&nbsp;/&nbsp;Video</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p3.php""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Loudspeaker</span></a></td>
                          <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/apple_iphone_x-review-1681p6.php#lt""
                          style='box-sizing: border-box'><span style='color:black;text-decoration:none'>Voice
                          68dB / Noise 74dB / Ring 76dB</span></a></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p4.php""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Audio
                          quality</span></a></td>
                          <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/apple_iphone_x-review-1681p7.php#aq""
                          style='box-sizing: border-box'><span style='color:black;text-decoration:none'>Noise
                          -93.7dB / Crosstalk -82.8dB</span></a></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p6.php""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Battery
                          life</span></a></td>
                          <td class=xl66 data-spec=batlife style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>
                          <div style='box-sizing: border-box'><a
                          href=""https://www.gsmarena.com/apple_iphone_x-8858.php""
                          onclick=""showBatteryPopup(event, 8858); "" style='box-sizing: border-box'><span
                          style='color:black;text-decoration:none'>Endurance rating 74h</span></a></div>
                          </td>
                         </tr>
                        <!--EndFragment-->
                        </table>", new Guid("2db8abb1-570d-4f62-a5e8-55d4a514719b"), new DateTime(2020, 2, 28, 0, 50, 35, 779, DateTimeKind.Local).AddTicks(2622) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Description", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 28, 0, 50, 35, 779, DateTimeKind.Local).AddTicks(2706), @"
                        <table border=0 cellpadding=0 cellspacing=0 width=687 style='border-collapse:
                         collapse;width:516pt;box-sizing: border-box;border-image: initial;font-variant-ligatures: normal;
                         font-variant-caps: normal;font-variant-numeric: inherit;font-variant-east-asian: inherit;
                         font-stretch: inherit;line-height:inherit;orphans: 2;text-align:start;
                         widows: 2;-webkit-text-stroke-width: 0px;text-decoration-style: initial;
                         text-decoration-color: initial;max-height: 28px'>
                        <!--StartFragment-->
                         <col width=103 style='mso-width-source:userset;mso-width-alt:3766;width:77pt'>
                         <col width=90 style='mso-width-source:userset;mso-width-alt:3291;width:68pt'>
                         <col width=494 style='mso-width-source:userset;mso-width-alt:18066;width:371pt'>
                         <tr height=20 style='height:15.0pt;box-sizing: border-box'>
                          <td height=20 class=xl65 width=103 style='height:15.0pt;width:77pt'>NETWORK</td>
                          <td class=xl65 width=90 style='width:68pt;box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial;
                          transition: all 0.15s ease-out 0s'><a
                          href=""https://www.gsmarena.com/network-bands.php3"" style='box-sizing: border-box'><span
                          style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                          mso-font-charset:0'>Technology</span></a></td>
                          <td class=xl66 width=494 style='width:371pt;box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial;transition: all 0.15s ease-out 0s'><a
                          href=""https://www.gsmarena.com/samsung_galaxy_note10_lite-10003.php""
                          data-spec=nettech style='box-sizing: border-box'><span style='color:black;
                          text-decoration:none'>GSM / HSPA / LTE</span></a></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>LAUNCH</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=phone-life-cycle""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Announced</span></a></td>
                          <td class=xl66 data-spec=year style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>2020,
                          January 3</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/glossary.php3?term=phone-life-cycle""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Status</span></a></td>
                          <td class=xl66 data-spec=status style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-color:
                          initial;border-image: initial'>Available. Released 2020, January 21</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>BODY</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/samsung_galaxy_note10_lite-10003.php""
                          onclick=""helpW('h_dimens.htm');"" style='box-sizing: border-box'><span
                          style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                          mso-font-charset:0'>Dimensions</span></a></td>
                          <td class=xl66 data-spec=dimensions style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>163.7
                          x 76.1 x 8.7 mm (6.44 x 3.00 x 0.34 in)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/samsung_galaxy_note10_lite-10003.php""
                          onclick=""helpW('h_weight.htm');"" style='box-sizing: border-box'><span
                          style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                          mso-font-charset:0'>Weight</span></a></td>
                          <td class=xl66 data-spec=weight style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>199
                          g (7.02 oz)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=sim""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>SIM</span></a></td>
                          <td class=xl66 data-spec=sim style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Single
                          SIM (Nano-SIM) or Dual SIM (Nano-SIM, dual stand-by)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66 data-spec=bodyother style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-color:
                          initial;border-image: initial'>Stylus (Bluetooth integration, accelerometer,
                          gyro)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>DISPLAY</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=display-type""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Type</span></a></td>
                          <td class=xl66 data-spec=displaytype style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial'>Super AMOLED capacitive touchscreen, 16M colors</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/samsung_galaxy_note10_lite-10003.php""
                          onclick=""helpW('h_dsize.htm');"" style='box-sizing: border-box'><span
                          style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                          mso-font-charset:0'>Size</span></a></td>
                          <td class=xl66 data-spec=displaysize style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial'>6.7 inches, 107.8 cm<font class=""font6""><sup
                          style='box-sizing: border-box;font-style:inherit;font-variant:inherit;
                          font-weight:inherit;font-stretch: inherit'>2</sup></font><font class=""font5"">&nbsp;(~86.6%
                          screen-to-body ratio)</font></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/glossary.php3?term=resolution""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Resolution</span></a></td>
                          <td class=xl66 data-spec=displayresolution style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial'>1080 x 2400 pixels, 20:9 ratio (~394 ppi density)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66 data-spec=displayother style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-color:initial;border-image: initial'>Always-on display</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66>HDR</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>PLATFORM</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=os"" style='box-sizing: border-box'><span
                          style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                          mso-font-charset:0'>OS</span></a></td>
                          <td class=xl66 data-spec=os style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Android
                          10.0; One UI 2</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=chipset""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Chipset</span></a></td>
                          <td class=xl66 data-spec=chipset style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Exynos
                          9810 (10 nm)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=cpu""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>CPU</span></a></td>
                          <td class=xl66 data-spec=cpu style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Octa-core
                          (4x2.7 GHz Mongoose M3 &amp; 4x1.7 GHz Cortex-A55)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=gpu""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>GPU</span></a></td>
                          <td class=xl66 data-spec=gpu style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-color:
                          initial;border-image: initial'>Mali-G72 MP18</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>MEMORY</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=memory-card-slot""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Card
                          slot</span></a></td>
                          <td class=xl66 data-spec=memoryslot style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>microSDXC
                          (uses shared SIM slot)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/glossary.php3?term=dynamic-memory""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Internal</span></a></td>
                          <td class=xl66 data-spec=internalmemory style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial'>128GB 6GB RAM, 128GB 8GB RAM</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66 data-spec=memoryother style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-color:initial;border-image: initial'>UFS 2.1</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>MAIN CAMERA</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=camera"" style='box-sizing: border-box'><span
                          style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                          mso-font-charset:0'>Triple</span></a></td>
                          <td class=xl66 data-spec=cam1modules style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial'>12 MP, f/1.7, 27mm (wide), 1/2.55&quot;, 1.4µm, Dual
                          Pixel PDAF, OIS</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66>12 MP, f/2.4, 52mm (telephoto), 1/3.6&quot;, 1.0µm, PDAF, OIS,
                          2x optical zoom</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66>12 MP, f/2.2, 12mm (ultrawide)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=camera""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Features</span></a></td>
                          <td class=xl66 data-spec=cam1features style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial'>LED flash, panorama, HDR</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=camera""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Video</span></a></td>
                          <td class=xl66 data-spec=cam1video style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-color:
                          initial;border-image: initial'>2160p@30/60fps, 1080p@30/60/240fps; gyro-EIS</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>SELFIE CAMERA</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=secondary-camera""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Single</span></a></td>
                          <td class=xl66 data-spec=cam2modules style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial'>32 MP, f/2.2, 25mm (wide), 1/2.8&quot;, 0.8µm</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/glossary.php3?term=secondary-camera""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Features</span></a></td>
                          <td class=xl66 data-spec=cam2features style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial'>HDR</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/glossary.php3?term=secondary-camera""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Video</span></a></td>
                          <td class=xl66 data-spec=cam2video style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-color:
                          initial;border-image: initial'>2160p@30fps, 1080p@30fps</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>SOUND</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=loudspeaker""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Loudspeaker</span></a></td>
                          <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'>Yes</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/glossary.php3?term=audio-jack""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>3.5mm
                          jack</span></a></td>
                          <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-color:initial;
                          border-image: initial'>Yes</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>COMMS</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=wi-fi"" style='box-sizing: border-box'><span
                          style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                          mso-font-charset:0'>WLAN</span></a></td>
                          <td class=xl66 data-spec=wlan style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Wi-Fi
                          802.11 a/b/g/n/ac, dual-band, Wi-Fi Direct, hotspot</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=bluetooth""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Bluetooth</span></a></td>
                          <td class=xl66 data-spec=bluetooth style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>5.0,
                          A2DP, LE</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=gps""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>GPS</span></a></td>
                          <td class=xl66 data-spec=gps style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Yes,
                          with A-GPS, GLONASS, GALILEO, BDS</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=nfc""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>NFC</span></a></td>
                          <td class=xl66 data-spec=nfc style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Yes</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=usb""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>USB</span></a></td>
                          <td class=xl66 data-spec=usb style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-color:
                          initial;border-image: initial'>2.0, Type-C 1.0 reversible connector</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>FEATURES</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=sensors"" style='box-sizing: border-box'><span
                          style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                          mso-font-charset:0'>Sensors</span></a></td>
                          <td class=xl66 data-spec=sensors style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Fingerprint
                          (under display, optical), accelerometer, gyro, proximity, compass</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66 data-spec=featuresother style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-color:initial;border-image: initial'>ANT+</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>BATTERY</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'></td>
                          <td class=xl66 data-spec=batdescription1 style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial'>Non-removable Li-Po 4500 mAh battery</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/glossary.php3?term=battery-charging""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Charging</span></a></td>
                          <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-color:initial;
                          border-image: initial'>Fast battery charging 25W</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>MISC</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=build"" style='box-sizing: border-box'><span
                          style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                          mso-font-charset:0'>Colors</span></a></td>
                          <td class=xl66 data-spec=colors style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Aura
                          Glow, Aura Black, Aura Red</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=models""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Models</span></a></td>
                          <td class=xl66 data-spec=models style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>SM-N770F,
                          SM-N770F/DS, SM-N770F/DSM</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=sar""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>SAR</span></a></td>
                          <td class=xl66 data-spec=sar-us style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>0.88
                          W/kg (head) &nbsp; &nbsp; 0.65 W/kg (body) &nbsp; &nbsp;</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=sar""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>SAR
                          EU</span></a></td>
                          <td class=xl66 data-spec=sar-eu style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>0.29
                          W/kg (head) &nbsp; &nbsp; 1.08 W/kg (body) &nbsp; &nbsp;</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=price""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Price</span></a></td>
                          <td class=xl66 data-spec=price style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-color:
                          initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/samsung_galaxy_note10_lite-price-10003.php""
                          style='box-sizing: border-box'><span style='color:black;text-decoration:none'>€ 609.00
                          / £ 529.00 / ₹ 38,999</span></a></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>TESTS</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=benchmarking""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Performance</span></a></td>
                          <td class=xl66 data-spec=tbench style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>AnTuTu:
                          258484 (v7), 341212 (v8)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66>GeekBench: 6103 (v4.4), 2027 (v5.1)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66>GFXBench: 25fps (ES 3.1 onscreen)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p2.php""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Display</span></a></td>
                          <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/samsung_galaxy_note10_lite-review-2063p3.php""
                          style='box-sizing: border-box'><span style='color:black;text-decoration:none'>Contrast
                          ratio: Infinite (nominal)</span></a></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p5.php""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Camera</span></a></td>
                          <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'>Photo&nbsp;/&nbsp;Video</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p4.php""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Audio
                          quality</span></a></td>
                          <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/samsung_galaxy_note10_lite-review-2063p3.php#aq""
                          style='box-sizing: border-box'><span style='color:black;text-decoration:none'>Noise
                          -93.3dB / Crosstalk -91.4dB</span></a></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p6.php""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Battery
                          life</span></a></td>
                          <td class=xl66 data-spec=batlife style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>
                          <div style='box-sizing: border-box'><a
                          href=""https://www.gsmarena.com/samsung_galaxy_note10_lite-10003.php""
                          onclick=""showBatteryPopup(event, 10003); "" style='box-sizing: border-box'><span
                          style='color:black;text-decoration:none'>Endurance rating 92h</span></a></div>
                          </td>
                         </tr>
                        <!--EndFragment-->
                        </table>", new Guid("b05a487b-d688-49b0-b182-304c057dbc45"), new DateTime(2020, 2, 28, 0, 50, 35, 779, DateTimeKind.Local).AddTicks(2710) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Description", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 28, 0, 50, 35, 779, DateTimeKind.Local).AddTicks(2793), @"
                        <table border=0 cellpadding=0 cellspacing=0 width=673 style='border-collapse:
                         collapse;width:506pt;box-sizing: border-box;border-image: initial;font-variant-ligatures: normal;
                         font-variant-caps: normal;font-variant-numeric: inherit;font-variant-east-asian: inherit;
                         font-stretch: inherit;line-height:inherit;orphans: 2;text-align:start;
                         widows: 2;-webkit-text-stroke-width: 0px;text-decoration-style: initial;
                         text-decoration-color: initial;max-height: 28px'>
                        <!--StartFragment-->
                         <col width=102 style='mso-width-source:userset;mso-width-alt:3730;width:77pt'>
                         <col width=90 style='mso-width-source:userset;mso-width-alt:3291;width:68pt'>
                         <col width=481 style='mso-width-source:userset;mso-width-alt:17590;width:361pt'>
                         <tr height=20 style='height:15.0pt;box-sizing: border-box'>
                          <td height=20 class=xl65 width=102 style='height:15.0pt;width:77pt'>NETWORK</td>
                          <td class=xl65 width=90 style='width:68pt;box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial;
                          transition: all 0.15s ease-out 0s'><a
                          href=""https://www.gsmarena.com/network-bands.php3"" style='box-sizing: border-box'><span
                          style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                          mso-font-charset:0'>Technology</span></a></td>
                          <td class=xl66 width=481 style='width:361pt;box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial;transition: all 0.15s ease-out 0s'><a
                          href=""https://www.gsmarena.com/samsung_galaxy_a50-9554.php""
                          data-spec=nettech style='box-sizing: border-box'><span style='color:black;
                          text-decoration:none'>GSM / HSPA / LTE</span></a></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>LAUNCH</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=phone-life-cycle""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Announced</span></a></td>
                          <td class=xl66 data-spec=year style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>2019,
                          February</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/glossary.php3?term=phone-life-cycle""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Status</span></a></td>
                          <td class=xl66 data-spec=status style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-color:
                          initial;border-image: initial'>Available. Released 2019, March</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>BODY</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/samsung_galaxy_a50-9554.php""
                          onclick=""helpW('h_dimens.htm');"" style='box-sizing: border-box'><span
                          style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                          mso-font-charset:0'>Dimensions</span></a></td>
                          <td class=xl66 data-spec=dimensions style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>158.5
                          x 74.7 x 7.7 mm (6.24 x 2.94 x 0.30 in)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/samsung_galaxy_a50-9554.php""
                          onclick=""helpW('h_weight.htm');"" style='box-sizing: border-box'><span
                          style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                          mso-font-charset:0'>Weight</span></a></td>
                          <td class=xl66 data-spec=weight style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>166
                          g (5.86 oz)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=build""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Build</span></a></td>
                          <td class=xl66 data-spec=build style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Glass
                          front (Gorilla Glass 3), plastic back, plastic frame</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=sim""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>SIM</span></a></td>
                          <td class=xl66 data-spec=sim style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-color:
                          initial;border-image: initial'>Single SIM (Nano-SIM) or Dual SIM (Nano-SIM,
                          dual stand-by)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>DISPLAY</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=display-type""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Type</span></a></td>
                          <td class=xl66 data-spec=displaytype style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial'>Super AMOLED capacitive touchscreen, 16M colors</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/samsung_galaxy_a50-9554.php""
                          onclick=""helpW('h_dsize.htm');"" style='box-sizing: border-box'><span
                          style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                          mso-font-charset:0'>Size</span></a></td>
                          <td class=xl66 data-spec=displaysize style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial'>6.4 inches, 100.5 cm<font class=""font6""><sup
                          style='box-sizing: border-box;font-style:inherit;font-variant:inherit;
                          font-weight:inherit;font-stretch: inherit'>2</sup></font><font class=""font5"">&nbsp;(~84.9%
                          screen-to-body ratio)</font></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/glossary.php3?term=resolution""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Resolution</span></a></td>
                          <td class=xl66 data-spec=displayresolution style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial'>1080 x 2340 pixels, 19.5:9 ratio (~403 ppi density)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/glossary.php3?term=screen-protection""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Protection</span></a></td>
                          <td class=xl66 data-spec=displayprotection style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-color:initial;border-image: initial'>Corning Gorilla Glass 3</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>PLATFORM</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=os"" style='box-sizing: border-box'><span
                          style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                          mso-font-charset:0'>OS</span></a></td>
                          <td class=xl66 data-spec=os style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Android
                          9.0 (Pie); One UI</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=chipset""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Chipset</span></a></td>
                          <td class=xl66 data-spec=chipset style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Exynos
                          9610 (10nm)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=cpu""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>CPU</span></a></td>
                          <td class=xl66 data-spec=cpu style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Octa-core
                          (4x2.3 GHz Cortex-A73 &amp; 4x1.7 GHz Cortex-A53)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=gpu""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>GPU</span></a></td>
                          <td class=xl66 data-spec=gpu style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-color:
                          initial;border-image: initial'>Mali-G72 MP3</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>MEMORY</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=memory-card-slot""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Card
                          slot</span></a></td>
                          <td class=xl66 data-spec=memoryslot style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>microSDXC
                          (dedicated slot)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/glossary.php3?term=dynamic-memory""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Internal</span></a></td>
                          <td class=xl66 data-spec=internalmemory style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial'>64GB 4GB RAM, 64GB 6GB RAM, 128GB 4GB RAM, 128GB 6GB
                          RAM</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66 data-spec=memoryother style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-color:initial;border-image: initial'>UFS 2.1</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>MAIN CAMERA</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=camera"" style='box-sizing: border-box'><span
                          style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                          mso-font-charset:0'>Triple</span></a></td>
                          <td class=xl66 data-spec=cam1modules style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial'>25 MP, f/1.7, 26mm (wide), PDAF</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66>8 MP, f/2.2, 13mm (ultrawide), 1/4.0&quot;, 1.12µm</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66>5 MP, f/2.2, (depth)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=camera""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Features</span></a></td>
                          <td class=xl66 data-spec=cam1features style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial'>LED flash, panorama, HDR</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=camera""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Video</span></a></td>
                          <td class=xl66 data-spec=cam1video style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-color:
                          initial;border-image: initial'>1080p@30fps</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>SELFIE CAMERA</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=secondary-camera""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Single</span></a></td>
                          <td class=xl66 data-spec=cam2modules style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial'>25 MP, f/2.0, 25mm (wide), 1/2.8&quot;, 0.9µm</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/glossary.php3?term=secondary-camera""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Features</span></a></td>
                          <td class=xl66 data-spec=cam2features style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial'>HDR</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/glossary.php3?term=secondary-camera""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Video</span></a></td>
                          <td class=xl66 data-spec=cam2video style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-color:
                          initial;border-image: initial'>1080p@30fps</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>SOUND</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=loudspeaker""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Loudspeaker</span></a></td>
                          <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'>Yes</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/glossary.php3?term=audio-jack""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>3.5mm
                          jack</span></a></td>
                          <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-color:initial;
                          border-image: initial'>Yes</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>COMMS</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=wi-fi"" style='box-sizing: border-box'><span
                          style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                          mso-font-charset:0'>WLAN</span></a></td>
                          <td class=xl66 data-spec=wlan style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Wi-Fi
                          802.11 a/b/g/n/ac, dual-band, Wi-Fi Direct, hotspot</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=bluetooth""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Bluetooth</span></a></td>
                          <td class=xl66 data-spec=bluetooth style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>5.0,
                          A2DP, LE</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=gps""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>GPS</span></a></td>
                          <td class=xl66 data-spec=gps style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Yes,
                          with A-GPS, GLONASS, GALILEO, BDS</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=nfc""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>NFC</span></a></td>
                          <td class=xl66 data-spec=nfc style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Yes
                          (market dependent)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=fm-radio""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Radio</span></a></td>
                          <td class=xl66 data-spec=radio style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>FM
                          radio</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=usb""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>USB</span></a></td>
                          <td class=xl66 data-spec=usb style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-color:
                          initial;border-image: initial'>2.0, Type-C 1.0 reversible connector, USB
                          On-The-Go</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>FEATURES</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=sensors"" style='box-sizing: border-box'><span
                          style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                          mso-font-charset:0'>Sensors</span></a></td>
                          <td class=xl66 data-spec=sensors style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Fingerprint
                          (under display, optical), accelerometer, gyro, proximity, compass</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66 data-spec=featuresother style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-color:initial;border-image: initial'>ANT+</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66>Bixby natural language commands and dictation</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>BATTERY</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'></td>
                          <td class=xl66 data-spec=batdescription1 style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial'>Non-removable Li-Po 4000 mAh battery</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/glossary.php3?term=battery-charging""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Charging</span></a></td>
                          <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-color:initial;
                          border-image: initial'>Fast battery charging 15W</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>MISC</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=build"" style='box-sizing: border-box'><span
                          style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                          mso-font-charset:0'>Colors</span></a></td>
                          <td class=xl66 data-spec=colors style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Black,
                          White, Blue, Coral</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=models""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Models</span></a></td>
                          <td class=xl66 data-spec=models style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>SM-A505F,
                          SM-A505FN, SM-A505GN, SM-A505G, SM-A505FM, SM-A505YN, SM-A505W, SM-A505X,
                          SM-A505U, SM-A505GT, SM-A505U1, SM-A505G, SM-A505N</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=sar""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>SAR</span></a></td>
                          <td class=xl66 data-spec=sar-us style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>1.31
                          W/kg (head) &nbsp; &nbsp; 0.58 W/kg (body) &nbsp; &nbsp;</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=sar""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>SAR
                          EU</span></a></td>
                          <td class=xl66 data-spec=sar-eu style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>0.27
                          W/kg (head) &nbsp; &nbsp; 1.39 W/kg (body) &nbsp; &nbsp;</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=price""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Price</span></a></td>
                          <td class=xl66 data-spec=price style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-color:
                          initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/samsung_galaxy_a50-price-9554.php""
                          style='box-sizing: border-box'><span style='color:black;text-decoration:none'>$ 199.99
                          / € 278.00 / £ 209.90 / ₹ 12,999</span></a></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>TESTS</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=benchmarking""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Performance</span></a></td>
                          <td class=xl66 data-spec=tbench style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>AnTuTu:
                          144574 (v7)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66>GeekBench: 5396 (v4.4)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66>GFXBench: 8fps (ES 3.1 onscreen)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p2.php""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Display</span></a></td>
                          <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/samsung_galaxy_a50-review-1921p3.php#dt""
                          style='box-sizing: border-box'><span style='color:black;text-decoration:none'>Contrast
                          ratio: Infinite (nominal)</span></a></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p5.php""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Camera</span></a></td>
                          <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'>Photo&nbsp;/&nbsp;Video</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p3.php""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Loudspeaker</span></a></td>
                          <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/samsung_galaxy_a50-review-1921p3.php#lt""
                          style='box-sizing: border-box'><span style='color:black;text-decoration:none'>Voice
                          68dB / Noise 71dB / Ring 82dB</span></a></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p4.php""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Audio
                          quality</span></a></td>
                          <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/samsung_galaxy_a50-review-1921p3.php#aq""
                          style='box-sizing: border-box'><span style='color:black;text-decoration:none'>Noise
                          -93.4dB / Crosstalk -92.3dB</span></a></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p6.php""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Battery
                          life</span></a></td>
                          <td class=xl66 data-spec=batlife style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>
                          <div style='box-sizing: border-box'><a
                          href=""https://www.gsmarena.com/samsung_galaxy_a50-9554.php""
                          onclick=""showBatteryPopup(event, 9554); "" style='box-sizing: border-box'><span
                          style='color:black;text-decoration:none'>Endurance rating 98h</span></a></div>
                          </td>
                         </tr>
                        <!--EndFragment-->
                        </table>", new Guid("a4ed3ac9-3db4-4602-b1d6-9cdd5d7e2d1d"), new DateTime(2020, 2, 28, 0, 50, 35, 779, DateTimeKind.Local).AddTicks(2796) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Description", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 28, 0, 50, 35, 779, DateTimeKind.Local).AddTicks(2871), @"
                        <table border=0 cellpadding=0 cellspacing=0 width=768 style='border-collapse:
                         collapse;width:576pt;box-sizing: border-box;border-image: initial;font-variant-ligatures: normal;
                         font-variant-caps: normal;font-variant-numeric: inherit;font-variant-east-asian: inherit;
                         font-stretch: inherit;line-height:inherit;orphans: 2;text-align:start;
                         widows: 2;-webkit-text-stroke-width: 0px;text-decoration-style: initial;
                         text-decoration-color: initial;max-height: 28px'>
                        <!--StartFragment-->
                         <col width=103 style='mso-width-source:userset;mso-width-alt:3766;width:77pt'>
                         <col width=86 style='mso-width-source:userset;mso-width-alt:3145;width:65pt'>
                         <col width=579 style='mso-width-source:userset;mso-width-alt:21174;width:434pt'>
                         <tr height=20 style='height:15.0pt;box-sizing: border-box'>
                          <td height=20 class=xl65 width=103 style='height:15.0pt;width:77pt'>NETWORK</td>
                          <td class=xl65 width=86 style='width:65pt;box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial;
                          transition: all 0.15s ease-out 0s'><a
                          href=""https://www.gsmarena.com/network-bands.php3"" style='box-sizing: border-box'><span
                          style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                          mso-font-charset:0'>Technology</span></a></td>
                          <td class=xl66 width=579 style='width:434pt;box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial;transition: all 0.15s ease-out 0s'><a
                          href=""https://www.gsmarena.com/xiaomi_mi_note_10_pro-9945.php""
                          data-spec=nettech style='box-sizing: border-box'><span style='color:black;
                          text-decoration:none'>GSM / HSPA / LTE</span></a></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>LAUNCH</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=phone-life-cycle""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Announced</span></a></td>
                          <td class=xl66 data-spec=year style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>2019,
                          November</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/glossary.php3?term=phone-life-cycle""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Status</span></a></td>
                          <td class=xl66 data-spec=status style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-color:
                          initial;border-image: initial'>Available. Released 2019, December</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>BODY</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/xiaomi_mi_note_10_pro-9945.php""
                          onclick=""helpW('h_dimens.htm');"" style='box-sizing: border-box'><span
                          style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                          mso-font-charset:0'>Dimensions</span></a></td>
                          <td class=xl66 data-spec=dimensions style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>157.8
                          x 74.2 x 9.7 mm (6.21 x 2.92 x 0.38 in)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/xiaomi_mi_note_10_pro-9945.php""
                          onclick=""helpW('h_weight.htm');"" style='box-sizing: border-box'><span
                          style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                          mso-font-charset:0'>Weight</span></a></td>
                          <td class=xl66 data-spec=weight style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>208
                          g (7.34 oz)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=build""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Build</span></a></td>
                          <td class=xl66 data-spec=build style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Glass
                          front (Gorilla Glass 5), glass back (Gorilla Glass 5), aluminum frame</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=sim""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>SIM</span></a></td>
                          <td class=xl66 data-spec=sim style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-color:
                          initial;border-image: initial'>Dual SIM (Nano-SIM, dual stand-by)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>DISPLAY</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=display-type""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Type</span></a></td>
                          <td class=xl66 data-spec=displaytype style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial'>AMOLED capacitive touchscreen, 16M colors</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/xiaomi_mi_note_10_pro-9945.php""
                          onclick=""helpW('h_dsize.htm');"" style='box-sizing: border-box'><span
                          style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                          mso-font-charset:0'>Size</span></a></td>
                          <td class=xl66 data-spec=displaysize style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial'>6.47 inches, 102.8 cm<font class=""font6""><sup
                          style='box-sizing: border-box;font-style:inherit;font-variant:inherit;
                          font-weight:inherit;font-stretch: inherit'>2</sup></font><font class=""font5"">&nbsp;(~87.8%
                          screen-to-body ratio)</font></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/glossary.php3?term=resolution""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Resolution</span></a></td>
                          <td class=xl66 data-spec=displayresolution style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial'>1080 x 2340 pixels, 19.5:9 ratio (~398 ppi density)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/glossary.php3?term=screen-protection""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Protection</span></a></td>
                          <td class=xl66 data-spec=displayprotection style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial'>Corning Gorilla Glass 5</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66 data-spec=displayother style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-color:initial;border-image: initial'>600 nits max brightness</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66>DCI-P3</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66>HDR10</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66>Always-on display</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>PLATFORM</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=os"" style='box-sizing: border-box'><span
                          style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                          mso-font-charset:0'>OS</span></a></td>
                          <td class=xl66 data-spec=os style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Android
                          9.0 (Pie); MIUI 11</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=chipset""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Chipset</span></a></td>
                          <td class=xl66 data-spec=chipset style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Qualcomm
                          SDM730 Snapdragon 730G (8 nm)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=cpu""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>CPU</span></a></td>
                          <td class=xl66 data-spec=cpu style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Octa-core
                          (2x2.2 GHz Kryo 470 Gold &amp; 6x1.8 GHz Kryo 470 Silver)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=gpu""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>GPU</span></a></td>
                          <td class=xl66 data-spec=gpu style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-color:
                          initial;border-image: initial'>Adreno 618</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>MEMORY</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=memory-card-slot""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Card
                          slot</span></a></td>
                          <td class=xl66 data-spec=memoryslot style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>No</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/glossary.php3?term=dynamic-memory""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Internal</span></a></td>
                          <td class=xl66 data-spec=internalmemory style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial'>256GB 8GB RAM</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66 data-spec=memoryother style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-color:initial;border-image: initial'>UFS 2.0</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>MAIN CAMERA</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=camera"" style='box-sizing: border-box'><span
                          style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                          mso-font-charset:0'>Five</span></a></td>
                          <td class=xl66 data-spec=cam1modules style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial'>108 MP (8P lens), f/1.7, 25mm (wide), 1/1.33&quot;,
                          0.8µm, PDAF, Laser AF, OIS</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66>12 MP, f/2.0, 50mm (telephoto), 1/2.55&quot;, 1.4µm, Dual
                          Pixel PDAF, Laser AF, 2x optical zoom</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66>5 MP (upscaled to 8MP), f/2.0, (telephoto), 1.0µm, PDAF, Laser
                          AF, OIS, 5x optical zoom</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66>20 MP, f/2.2, 13mm (ultrawide), 1/2.8&quot;, 1.0µm, Laser AF</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66>2 MP, f/2.4, (macro), 1/5.0&quot;, 1.75µm</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=camera""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Features</span></a></td>
                          <td class=xl66 data-spec=cam1features style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial'>Quad-LED dual-tone flash, HDR</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=camera""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Video</span></a></td>
                          <td class=xl66 data-spec=cam1video style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-color:
                          initial;border-image: initial'>2160p@30fps, 1080p@30/60/120/240fps,
                          720p@960fps</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>SELFIE CAMERA</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=secondary-camera""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Single</span></a></td>
                          <td class=xl66 data-spec=cam2modules style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial'>32 MP, f/2.0, 26mm (wide), 1/2.8&quot;, 0.8µm</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/glossary.php3?term=secondary-camera""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Features</span></a></td>
                          <td class=xl66 data-spec=cam2features style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial'>HDR</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/glossary.php3?term=secondary-camera""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Video</span></a></td>
                          <td class=xl66 data-spec=cam2video style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-color:
                          initial;border-image: initial'>1080p@30fps</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>SOUND</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=loudspeaker""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Loudspeaker</span></a></td>
                          <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'>Yes</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/glossary.php3?term=audio-jack""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>3.5mm
                          jack</span></a></td>
                          <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'>Yes</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66 data-spec=optionalother style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-color:initial;border-image: initial'>24-bit/192kHz audio</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>COMMS</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=wi-fi"" style='box-sizing: border-box'><span
                          style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                          mso-font-charset:0'>WLAN</span></a></td>
                          <td class=xl66 data-spec=wlan style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Wi-Fi
                          802.11 a/b/g/n/ac, dual-band, Wi-Fi Direct, hotspot</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=bluetooth""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Bluetooth</span></a></td>
                          <td class=xl66 data-spec=bluetooth style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>5.0,
                          A2DP, LE, aptX HD</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=gps""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>GPS</span></a></td>
                          <td class=xl66 data-spec=gps style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Yes,
                          with A-GPS, GLONASS, GALILEO, BDS</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=nfc""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>NFC</span></a></td>
                          <td class=xl66 data-spec=nfc style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Yes</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=irda""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Infrared
                          port</span></a></td>
                          <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'>Yes</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=fm-radio""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Radio</span></a></td>
                          <td class=xl66 data-spec=radio style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>FM
                          radio</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=usb""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>USB</span></a></td>
                          <td class=xl66 data-spec=usb style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-color:
                          initial;border-image: initial'>2.0, Type-C 1.0 reversible connector</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>FEATURES</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-color:initial;
                          border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=sensors"" style='box-sizing: border-box'><span
                          style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                          mso-font-charset:0'>Sensors</span></a></td>
                          <td class=xl66 data-spec=sensors style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-color:
                          initial;border-image: initial'>Fingerprint (under display, optical),
                          accelerometer, gyro, proximity, compass</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>BATTERY</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'></td>
                          <td class=xl66 data-spec=batdescription1 style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial'>Non-removable Li-Po 5260 mAh battery</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/glossary.php3?term=battery-charging""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Charging</span></a></td>
                          <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-color:initial;
                          border-image: initial'>Fast battery charging 30W (58% in 30 min., 100% in 65
                          min.)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66>USB Power Delivery</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>MISC</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=build"" style='box-sizing: border-box'><span
                          style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                          mso-font-charset:0'>Colors</span></a></td>
                          <td class=xl66 data-spec=colors style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Aurora
                          Green, Glacier White, Midnight Black</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=models""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Models</span></a></td>
                          <td class=xl66 data-spec=models style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>M1910F4S</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=sar""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>SAR</span></a></td>
                          <td class=xl66 data-spec=sar-us style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>1.19
                          W/kg (head) &nbsp; &nbsp; 1.18 W/kg (body) &nbsp; &nbsp;</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=sar""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>SAR
                          EU</span></a></td>
                          <td class=xl66 data-spec=sar-eu style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>1.11
                          W/kg (head) &nbsp; &nbsp; 1.39 W/kg (body) &nbsp; &nbsp;</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=price""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Price</span></a></td>
                          <td class=xl66 data-spec=price style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-color:
                          initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/xiaomi_mi_note_10_pro-price-9945.php""
                          style='box-sizing: border-box'><span style='color:black;text-decoration:none'>$ 552.00
                          / € 499.00 / £ 420.81</span></a></td>
                         </tr>
                        <!--EndFragment-->
                        </table>", new Guid("bac58b24-4b0d-47e5-b70a-c6c008126f6b"), new DateTime(2020, 2, 28, 0, 50, 35, 779, DateTimeKind.Local).AddTicks(2875) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Description", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 28, 0, 50, 35, 779, DateTimeKind.Local).AddTicks(2950), @"
                        <table border=0 cellpadding=0 cellspacing=0 width=684 style='border-collapse:
                         collapse;width:513pt;box-sizing: border-box;border-image: initial;font-variant-ligatures: normal;
                         font-variant-caps: normal;font-variant-numeric: inherit;font-variant-east-asian: inherit;
                         font-stretch: inherit;line-height:inherit;orphans: 2;text-align:start;
                         widows: 2;-webkit-text-stroke-width: 0px;text-decoration-style: initial;
                         text-decoration-color: initial;max-height: 28px'>
                        <!--StartFragment-->
                         <col width=103 style='mso-width-source:userset;mso-width-alt:3766;width:77pt'>
                         <col width=87 style='mso-width-source:userset;mso-width-alt:3181;width:65pt'>
                         <col width=494 style='mso-width-source:userset;mso-width-alt:18066;width:371pt'>
                         <tr height=20 style='height:15.0pt;box-sizing: border-box'>
                          <td height=20 class=xl65 width=103 style='height:15.0pt;width:77pt'>NETWORK</td>
                          <td class=xl65 width=87 style='width:65pt;box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial;
                          transition: all 0.15s ease-out 0s'><a
                          href=""https://www.gsmarena.com/network-bands.php3"" style='box-sizing: border-box'><span
                          style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                          mso-font-charset:0'>Technology</span></a></td>
                          <td class=xl66 width=494 style='width:371pt;box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial;transition: all 0.15s ease-out 0s'><a
                          href=""https://www.gsmarena.com/xiaomi_mi_9_lite-9862.php"" data-spec=nettech
                          style='box-sizing: border-box'><span style='color:black;text-decoration:none'>GSM
                          / HSPA / LTE</span></a></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>LAUNCH</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=phone-life-cycle""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Announced</span></a></td>
                          <td class=xl66 data-spec=year style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>2019,
                          September</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/glossary.php3?term=phone-life-cycle""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Status</span></a></td>
                          <td class=xl66 data-spec=status style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-color:
                          initial;border-image: initial'>Available. Released 2019, September</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>BODY</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/xiaomi_mi_9_lite-9862.php""
                          onclick=""helpW('h_dimens.htm');"" style='box-sizing: border-box'><span
                          style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                          mso-font-charset:0'>Dimensions</span></a></td>
                          <td class=xl66 data-spec=dimensions style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>156.8
                          x 74.5 x 8.7 mm (6.17 x 2.93 x 0.34 in)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/xiaomi_mi_9_lite-9862.php""
                          onclick=""helpW('h_weight.htm');"" style='box-sizing: border-box'><span
                          style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                          mso-font-charset:0'>Weight</span></a></td>
                          <td class=xl66 data-spec=weight style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>179
                          g (6.31 oz)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=build""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Build</span></a></td>
                          <td class=xl66 data-spec=build style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Glass
                          front (Gorilla Glass 5), glass back (Gorilla Glass 5), aluminum frame</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=sim""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>SIM</span></a></td>
                          <td class=xl66 data-spec=sim style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-color:
                          initial;border-image: initial'>Hybrid Dual SIM (Nano-SIM, dual stand-by)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>DISPLAY</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=display-type""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Type</span></a></td>
                          <td class=xl66 data-spec=displaytype style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial'>Super AMOLED capacitive touchscreen, 16M colors</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/xiaomi_mi_9_lite-9862.php""
                          onclick=""helpW('h_dsize.htm');"" style='box-sizing: border-box'><span
                          style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                          mso-font-charset:0'>Size</span></a></td>
                          <td class=xl66 data-spec=displaysize style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial'>6.39 inches, 100.2 cm<font class=""font6""><sup
                          style='box-sizing: border-box;font-style:inherit;font-variant:inherit;
                          font-weight:inherit;font-stretch: inherit'>2</sup></font><font class=""font5"">&nbsp;(~85.8%
                          screen-to-body ratio)</font></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/glossary.php3?term=resolution""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Resolution</span></a></td>
                          <td class=xl66 data-spec=displayresolution style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial'>1080 x 2340 pixels, 19.5:9 ratio (~403 ppi density)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/glossary.php3?term=screen-protection""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Protection</span></a></td>
                          <td class=xl66 data-spec=displayprotection style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial'>Corning Gorilla Glass 5</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66 data-spec=displayother style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-color:initial;border-image: initial'>600 nits max brightness</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66>HDR</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>PLATFORM</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=os"" style='box-sizing: border-box'><span
                          style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                          mso-font-charset:0'>OS</span></a></td>
                          <td class=xl66 data-spec=os style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Android
                          9.0 (Pie); MIUI 10</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=chipset""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Chipset</span></a></td>
                          <td class=xl66 data-spec=chipset style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Qualcomm
                          SDM710 Snapdragon 710 (10 nm)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=cpu""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>CPU</span></a></td>
                          <td class=xl66 data-spec=cpu style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Octa-core
                          (2x2.2 GHz Kryo 360 Gold &amp; 6x1.7 GHz Kryo 360 Silver)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=gpu""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>GPU</span></a></td>
                          <td class=xl66 data-spec=gpu style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-color:
                          initial;border-image: initial'>Adreno 616</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>MEMORY</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=memory-card-slot""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Card
                          slot</span></a></td>
                          <td class=xl66 data-spec=memoryslot style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>microSDXC
                          (uses shared SIM slot)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/glossary.php3?term=dynamic-memory""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Internal</span></a></td>
                          <td class=xl66 data-spec=internalmemory style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial'>64GB 6GB RAM, 128GB 6GB RAM</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66 data-spec=memoryother style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-color:initial;border-image: initial'>UFS 2.1</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>MAIN CAMERA</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=camera"" style='box-sizing: border-box'><span
                          style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                          mso-font-charset:0'>Triple</span></a></td>
                          <td class=xl66 data-spec=cam1modules style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial'>48 MP, f/1.8, (wide), 1/2.0&quot;, 0.8µm, PDAF</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66>8 MP, (ultrawide), 1/4.0&quot;, 1.12µm</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66>2 MP, (depth)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=camera""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Features</span></a></td>
                          <td class=xl66 data-spec=cam1features style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial'>LED flash, HDR, panorama</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=camera""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Video</span></a></td>
                          <td class=xl66 data-spec=cam1video style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-color:
                          initial;border-image: initial'>2160p@30fps, 1080p@30/60/120fps, 720p@960fps</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>SELFIE CAMERA</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=secondary-camera""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Single</span></a></td>
                          <td class=xl66 data-spec=cam2modules style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial'>32 MP, f/2.0, 26mm (wide), 1/2.8&quot;, 0.8µm</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/glossary.php3?term=secondary-camera""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Features</span></a></td>
                          <td class=xl66 data-spec=cam2features style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial'>HDR</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/glossary.php3?term=secondary-camera""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Video</span></a></td>
                          <td class=xl66 data-spec=cam2video style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-color:
                          initial;border-image: initial'>1080p@30fps</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>SOUND</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=loudspeaker""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Loudspeaker</span></a></td>
                          <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'>Yes</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/glossary.php3?term=audio-jack""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>3.5mm
                          jack</span></a></td>
                          <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-color:initial;
                          border-image: initial'>Yes</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>COMMS</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=wi-fi"" style='box-sizing: border-box'><span
                          style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                          mso-font-charset:0'>WLAN</span></a></td>
                          <td class=xl66 data-spec=wlan style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Wi-Fi
                          802.11 a/b/g/n/ac, dual-band, Wi-Fi Direct, hotspot</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=bluetooth""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Bluetooth</span></a></td>
                          <td class=xl66 data-spec=bluetooth style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>5.0,
                          A2DP, LE, aptX HD</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=gps""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>GPS</span></a></td>
                          <td class=xl66 data-spec=gps style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Yes,
                          with A-GPS, GLONASS, GALILEO, BDS</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=nfc""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>NFC</span></a></td>
                          <td class=xl66 data-spec=nfc style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Yes</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=irda""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Infrared
                          port</span></a></td>
                          <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'>Yes</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=fm-radio""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Radio</span></a></td>
                          <td class=xl66 data-spec=radio style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>FM
                          radio</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=usb""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>USB</span></a></td>
                          <td class=xl66 data-spec=usb style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-color:
                          initial;border-image: initial'>2.0, Type-C 1.0 reversible connector</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>FEATURES</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-color:initial;
                          border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=sensors"" style='box-sizing: border-box'><span
                          style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                          mso-font-charset:0'>Sensors</span></a></td>
                          <td class=xl66 data-spec=sensors style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-color:
                          initial;border-image: initial'>Fingerprint (under display, optical),
                          accelerometer, gyro, proximity, compass</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>BATTERY</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'></td>
                          <td class=xl66 data-spec=batdescription1 style='box-sizing: border-box;
                          border-top-style:initial;border-right-style:initial;border-left-style:initial;
                          border-top-color:initial;border-right-color:initial;border-left-color:initial;
                          border-image: initial'>Non-removable Li-Po 4030 mAh battery</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/glossary.php3?term=battery-charging""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Charging</span></a></td>
                          <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-color:initial;
                          border-image: initial'>Fast battery charging 18W</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>MISC</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=build"" style='box-sizing: border-box'><span
                          style='color:black;font-weight:700;text-decoration:none;font-family:Calibri, sans-serif;
                          mso-font-charset:0'>Colors</span></a></td>
                          <td class=xl66 data-spec=colors style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>Pearl
                          White, Aurora Blue, Onyx Grey</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=models""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Models</span></a></td>
                          <td class=xl66 data-spec=models style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>M1904F3BG</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=sar""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>SAR</span></a></td>
                          <td class=xl66 data-spec=sar-us style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>1.19
                          W/kg (head) &nbsp; &nbsp; 1.15 W/kg (body) &nbsp; &nbsp;</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=sar""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>SAR
                          EU</span></a></td>
                          <td class=xl66 data-spec=sar-eu style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>1.42
                          W/kg (head) &nbsp; &nbsp; 1.40 W/kg (body) &nbsp; &nbsp;</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a href=""https://www.gsmarena.com/glossary.php3?term=price""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Price</span></a></td>
                          <td class=xl66 data-spec=price style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-color:
                          initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/xiaomi_mi_9_lite-price-9862.php""
                          style='box-sizing: border-box'><span style='color:black;text-decoration:none'>$ 207.20
                          / € 241.49 / £ 205.31</span></a></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'>TESTS</td>
                          <td class=xl65 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/glossary.php3?term=benchmarking""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Performance</span></a></td>
                          <td class=xl66 data-spec=tbench style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>AnTuTu:
                          175478 (v7), 215277 (v8)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66>GeekBench: 5989 (v4.4), 1518 (v5.1)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65></td>
                          <td class=xl66>GFXBench: 12fps (ES 3.1 onscreen)</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p2.php""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Display</span></a></td>
                          <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/xiaomi_mi_9_lite-9862.php"" style='box-sizing: border-box'><span
                          style='color:black;text-decoration:none'>Contrast ratio: Infinite (nominal)</span></a></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p5.php""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Camera</span></a></td>
                          <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'>Photo&nbsp;/&nbsp;Video</td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p3.php""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Loudspeaker</span></a></td>
                          <td class=xl66 style='box-sizing: border-box;border-top-style:initial;
                          border-right-style:initial;border-left-style:initial;border-top-color:initial;
                          border-right-color:initial;border-left-color:initial;border-image: initial'><a
                          href=""https://www.gsmarena.com/xiaomi_mi_9_lite-9862.php"" style='box-sizing: border-box'><span
                          style='color:black;text-decoration:none'>Voice 67dB / Noise 72dB / Ring 83dB</span></a></td>
                         </tr>
                         <tr height=20 style='height:15.0pt'>
                          <td height=20 class=xl65 style='height:15.0pt'></td>
                          <td class=xl65><a
                          href=""https://www.gsmarena.com/gsmarena_lab_tests-review-751p6.php""
                          style='box-sizing: border-box'><span style='color:black;font-weight:700;
                          text-decoration:none;font-family:Calibri, sans-serif;mso-font-charset:0'>Battery
                          life</span></a></td>
                          <td class=xl66 data-spec=batlife style='box-sizing: border-box;border-top-style:
                          initial;border-right-style:initial;border-left-style:initial;border-top-color:
                          initial;border-right-color:initial;border-left-color:initial;border-image: initial'>
                          <div style='box-sizing: border-box'><a
                          href=""https://www.gsmarena.com/xiaomi_mi_9_lite-9862.php""
                          onclick=""showBatteryPopup(event, 9862); "" style='box-sizing: border-box'><span
                          style='color:black;text-decoration:none'>Endurance rating 106h</span></a></div>
                          </td>
                         </tr>
                        <!--EndFragment-->
                        </table>", new Guid("05db724c-ac47-456f-ba66-f0ec6e9c7a27"), new DateTime(2020, 2, 28, 0, 50, 35, 779, DateTimeKind.Local).AddTicks(2954) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Active", "CreatedAt", "Description", "Discount", "Identifier", "Name", "Price", "Tags", "UpdatedAt" },
                values: new object[,]
                {
                    { 23, true, new DateTime(2020, 2, 28, 0, 50, 35, 779, DateTimeKind.Local).AddTicks(3973), "", 0, new Guid("8508ee00-efa5-4f49-9080-a77ef273f052"), "Xiaomi Mi A2 Black", 350m, "Masks;", new DateTime(2020, 2, 28, 0, 50, 35, 779, DateTimeKind.Local).AddTicks(3976) },
                    { 22, true, new DateTime(2020, 2, 28, 0, 50, 35, 779, DateTimeKind.Local).AddTicks(3895), "", 0, new Guid("bf70def8-1e8d-4fe4-b019-1c0cd424dbca"), "Samsung S10 Lite Pattern", 350m, "Masks;", new DateTime(2020, 2, 28, 0, 50, 35, 779, DateTimeKind.Local).AddTicks(3899) },
                    { 21, true, new DateTime(2020, 2, 28, 0, 50, 35, 779, DateTimeKind.Local).AddTicks(3817), "", 0, new Guid("ddfe9ebf-5c1e-44d8-8ea9-69e0a16c5d25"), "Samsung A50 Light", 350m, "Masks;", new DateTime(2020, 2, 28, 0, 50, 35, 779, DateTimeKind.Local).AddTicks(3820) },
                    { 20, true, new DateTime(2020, 2, 28, 0, 50, 35, 779, DateTimeKind.Local).AddTicks(3738), "", 0, new Guid("2f84543f-f625-45d0-9d91-f8e6028ef815"), "Apple iPhone XS Pink", 350m, "Masks;", new DateTime(2020, 2, 28, 0, 50, 35, 779, DateTimeKind.Local).AddTicks(3741) },
                    { 19, true, new DateTime(2020, 2, 28, 0, 50, 35, 779, DateTimeKind.Local).AddTicks(3585), "", 0, new Guid("768e4763-7cc1-421e-bb35-08ca75d23197"), "Apple iPhone 11 Pro Army", 350m, "Masks;", new DateTime(2020, 2, 28, 0, 50, 35, 779, DateTimeKind.Local).AddTicks(3589) },
                    { 18, true, new DateTime(2020, 2, 28, 0, 50, 35, 779, DateTimeKind.Local).AddTicks(3505), "", 0, new Guid("53d02f04-233f-454e-ba1a-6f01dbe90424"), "Nokia 5 Army", 350m, "Masks;", new DateTime(2020, 2, 28, 0, 50, 35, 779, DateTimeKind.Local).AddTicks(3508) },
                    { 17, true, new DateTime(2020, 2, 28, 0, 50, 35, 779, DateTimeKind.Local).AddTicks(3421), "", 0, new Guid("8f6ce988-1773-4ff1-842f-8909b45f755c"), "Nokia 2 Black", 350m, "Masks;", new DateTime(2020, 2, 28, 0, 50, 35, 779, DateTimeKind.Local).AddTicks(3424) },
                    { 16, true, new DateTime(2020, 2, 28, 0, 50, 35, 779, DateTimeKind.Local).AddTicks(3338), "", 0, new Guid("633e9866-02a0-4530-939c-970b5108c6f7"), "LG K4 Pink", 350m, "Masks;", new DateTime(2020, 2, 28, 0, 50, 35, 779, DateTimeKind.Local).AddTicks(3342) },
                    { 15, true, new DateTime(2020, 2, 28, 0, 50, 35, 779, DateTimeKind.Local).AddTicks(3260), "", 0, new Guid("693621d1-2d39-468d-bb6c-876b47b04661"), "LG G3 Blue", 350m, "Masks;", new DateTime(2020, 2, 28, 0, 50, 35, 779, DateTimeKind.Local).AddTicks(3264) },
                    { 14, true, new DateTime(2020, 2, 28, 0, 50, 35, 779, DateTimeKind.Local).AddTicks(3180), "", 0, new Guid("c57efc69-0088-47db-9ab6-6e7774ac5000"), "Huawei P30 Lite Black", 350m, "Masks;", new DateTime(2020, 2, 28, 0, 50, 35, 779, DateTimeKind.Local).AddTicks(3184) },
                    { 24, true, new DateTime(2020, 2, 28, 0, 50, 35, 779, DateTimeKind.Local).AddTicks(4050), "", 0, new Guid("1b5a4fc0-785c-4b8e-b7ba-1ae67878b9b9"), "Xiaomi Redmi Note 7 Blue", 350m, "Masks;", new DateTime(2020, 2, 28, 0, 50, 35, 779, DateTimeKind.Local).AddTicks(4054) },
                    { 13, true, new DateTime(2020, 2, 28, 0, 50, 35, 779, DateTimeKind.Local).AddTicks(3099), "", 0, new Guid("6f925a6c-943f-4d44-90c6-14e87ce29a13"), "Huawei Honor 10 Lite Pink", 350m, "Masks;", new DateTime(2020, 2, 28, 0, 50, 35, 779, DateTimeKind.Local).AddTicks(3102) }
                });

            migrationBuilder.InsertData(
                table: "ProductPhotos",
                columns: new[] { "ProductId", "PhotoPath", "MainPhoto" },
                values: new object[,]
                {
                    { 13, "/photos/masks/Huawei/honor-10-lite.png", true },
                    { 14, "/photos/masks/Huawei/huawei,p30 lite.png", true },
                    { 23, "/photos/masks/Xiaomi/mi-a2.png", true },
                    { 15, "/photos/masks/LG/lg-g3.png", true },
                    { 16, "/photos/masks/LG/lg-k4.png", true },
                    { 22, "/photos/masks/Samsung/s10lite.jpg", true },
                    { 17, "/photos/masks/Nokia/nokia2.png", true },
                    { 18, "/photos/masks/Nokia/nokia-5-army.png", true },
                    { 24, "/photos/masks/Xiaomi/redmi-note-7.png", true },
                    { 19, "/photos/masks/Apple/apple_iphone 11 pro.jpg", true },
                    { 21, "/photos/masks/Samsung/a50.png", true },
                    { 20, "/photos/masks/Apple/iphone xs.jpeg", true }
                });

            migrationBuilder.InsertData(
                table: "Product_ProductType",
                columns: new[] { "ProductId", "ProductTypeId" },
                values: new object[,]
                {
                    { 23, 17 },
                    { 22, 16 },
                    { 21, 16 },
                    { 18, 14 },
                    { 19, 15 },
                    { 17, 14 },
                    { 16, 13 },
                    { 15, 13 },
                    { 14, 12 },
                    { 13, 12 },
                    { 20, 15 },
                    { 24, 17 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductPhotos",
                keyColumns: new[] { "ProductId", "PhotoPath" },
                keyValues: new object[] { 13, "/photos/masks/Huawei/honor-10-lite.png" });

            migrationBuilder.DeleteData(
                table: "ProductPhotos",
                keyColumns: new[] { "ProductId", "PhotoPath" },
                keyValues: new object[] { 14, "/photos/masks/Huawei/huawei,p30 lite.png" });

            migrationBuilder.DeleteData(
                table: "ProductPhotos",
                keyColumns: new[] { "ProductId", "PhotoPath" },
                keyValues: new object[] { 15, "/photos/masks/LG/lg-g3.png" });

            migrationBuilder.DeleteData(
                table: "ProductPhotos",
                keyColumns: new[] { "ProductId", "PhotoPath" },
                keyValues: new object[] { 16, "/photos/masks/LG/lg-k4.png" });

            migrationBuilder.DeleteData(
                table: "ProductPhotos",
                keyColumns: new[] { "ProductId", "PhotoPath" },
                keyValues: new object[] { 17, "/photos/masks/Nokia/nokia2.png" });

            migrationBuilder.DeleteData(
                table: "ProductPhotos",
                keyColumns: new[] { "ProductId", "PhotoPath" },
                keyValues: new object[] { 18, "/photos/masks/Nokia/nokia-5-army.png" });

            migrationBuilder.DeleteData(
                table: "ProductPhotos",
                keyColumns: new[] { "ProductId", "PhotoPath" },
                keyValues: new object[] { 19, "/photos/masks/Apple/apple_iphone 11 pro.jpg" });

            migrationBuilder.DeleteData(
                table: "ProductPhotos",
                keyColumns: new[] { "ProductId", "PhotoPath" },
                keyValues: new object[] { 20, "/photos/masks/Apple/iphone xs.jpeg" });

            migrationBuilder.DeleteData(
                table: "ProductPhotos",
                keyColumns: new[] { "ProductId", "PhotoPath" },
                keyValues: new object[] { 21, "/photos/masks/Samsung/a50.png" });

            migrationBuilder.DeleteData(
                table: "ProductPhotos",
                keyColumns: new[] { "ProductId", "PhotoPath" },
                keyValues: new object[] { 22, "/photos/masks/Samsung/s10lite.jpg" });

            migrationBuilder.DeleteData(
                table: "ProductPhotos",
                keyColumns: new[] { "ProductId", "PhotoPath" },
                keyValues: new object[] { 23, "/photos/masks/Xiaomi/mi-a2.png" });

            migrationBuilder.DeleteData(
                table: "ProductPhotos",
                keyColumns: new[] { "ProductId", "PhotoPath" },
                keyValues: new object[] { 24, "/photos/masks/Xiaomi/redmi-note-7.png" });

            migrationBuilder.DeleteData(
                table: "Product_ProductType",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 10, 10 });

            migrationBuilder.DeleteData(
                table: "Product_ProductType",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 13, 12 });

            migrationBuilder.DeleteData(
                table: "Product_ProductType",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 14, 12 });

            migrationBuilder.DeleteData(
                table: "Product_ProductType",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 15, 13 });

            migrationBuilder.DeleteData(
                table: "Product_ProductType",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 16, 13 });

            migrationBuilder.DeleteData(
                table: "Product_ProductType",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 17, 14 });

            migrationBuilder.DeleteData(
                table: "Product_ProductType",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 18, 14 });

            migrationBuilder.DeleteData(
                table: "Product_ProductType",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 19, 15 });

            migrationBuilder.DeleteData(
                table: "Product_ProductType",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 20, 15 });

            migrationBuilder.DeleteData(
                table: "Product_ProductType",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 21, 16 });

            migrationBuilder.DeleteData(
                table: "Product_ProductType",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 22, 16 });

            migrationBuilder.DeleteData(
                table: "Product_ProductType",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 23, 17 });

            migrationBuilder.DeleteData(
                table: "Product_ProductType",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 24, 17 });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

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

            migrationBuilder.InsertData(
                table: "Product_ProductType",
                columns: new[] { "ProductId", "ProductTypeId" },
                values: new object[] { 10, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 15, 40, 40, 400, DateTimeKind.Local).AddTicks(1402), @"
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
                        </table>", new Guid("8e853b83-55ab-4562-bd90-4af0a8d3f027"), new DateTime(2020, 2, 27, 15, 40, 40, 400, DateTimeKind.Local).AddTicks(1409) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 15, 40, 40, 401, DateTimeKind.Local).AddTicks(6645), @"
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
                        </table>", new Guid("cb56ab55-3085-4721-8cd4-0eecc3b8fd06"), new DateTime(2020, 2, 27, 15, 40, 40, 401, DateTimeKind.Local).AddTicks(6651) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 15, 40, 40, 401, DateTimeKind.Local).AddTicks(7166), "OPIS_TELEFONA", new Guid("27f6396c-8041-484a-9d73-50bc26bfa428"), new DateTime(2020, 2, 27, 15, 40, 40, 401, DateTimeKind.Local).AddTicks(7172) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 15, 40, 40, 401, DateTimeKind.Local).AddTicks(7326), "OPIS_TELEFONA", new Guid("53cdf494-d911-4a62-bb18-7342a6c28f07"), new DateTime(2020, 2, 27, 15, 40, 40, 401, DateTimeKind.Local).AddTicks(7333) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 15, 40, 40, 401, DateTimeKind.Local).AddTicks(7482), "OPIS_TELEFONA", new Guid("48273312-daac-4601-85ee-0acd86116c14"), new DateTime(2020, 2, 27, 15, 40, 40, 401, DateTimeKind.Local).AddTicks(7488) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Description", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 15, 40, 40, 401, DateTimeKind.Local).AddTicks(7654), "OPIS_TELEFONA", new Guid("c98c4f2f-10a7-4bac-bfcc-f01db828d279"), new DateTime(2020, 2, 27, 15, 40, 40, 401, DateTimeKind.Local).AddTicks(7660) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 15, 40, 40, 401, DateTimeKind.Local).AddTicks(7995), "OPIS_TELEFONA", new Guid("96ab4857-d0ce-4d96-8bc0-6f0486330c79"), new DateTime(2020, 2, 27, 15, 40, 40, 401, DateTimeKind.Local).AddTicks(8001) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Description", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 15, 40, 40, 401, DateTimeKind.Local).AddTicks(8148), "OPIS_TELEFONA", new Guid("01d18ea0-27c9-47c6-9efd-2216373cdfb5"), new DateTime(2020, 2, 27, 15, 40, 40, 401, DateTimeKind.Local).AddTicks(8154) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Description", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 15, 40, 40, 401, DateTimeKind.Local).AddTicks(8324), "OPIS_TELEFONA", new Guid("d986239a-00bb-41b4-98ea-800bb8d67f9f"), new DateTime(2020, 2, 27, 15, 40, 40, 401, DateTimeKind.Local).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Description", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 15, 40, 40, 401, DateTimeKind.Local).AddTicks(8490), "OPIS_TELEFONA", new Guid("c41319c8-5ed6-4d10-b78b-3eadda55f22b"), new DateTime(2020, 2, 27, 15, 40, 40, 401, DateTimeKind.Local).AddTicks(8496) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Description", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 15, 40, 40, 401, DateTimeKind.Local).AddTicks(8645), "OPIS_TELEFONA", new Guid("17b80d04-1f35-420b-b6d7-876af4d56fef"), new DateTime(2020, 2, 27, 15, 40, 40, 401, DateTimeKind.Local).AddTicks(8652) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Description", "Identifier", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 27, 15, 40, 40, 401, DateTimeKind.Local).AddTicks(8798), "OPIS_TELEFONA", new Guid("db2dd368-c7a3-439a-96ac-046c65ec3b3b"), new DateTime(2020, 2, 27, 15, 40, 40, 401, DateTimeKind.Local).AddTicks(8804) });
        }
    }
}
