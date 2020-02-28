using Domain.Products;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Repository.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ProductPhoto> ProductPhotos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product_ProductType>().HasKey("ProductId", "ProductTypeId");

            modelBuilder.Entity<ProductPhoto>().HasKey("ProductId", "PhotoPath");


            modelBuilder.Entity<ProductType>().HasData(
                    // Main categories
                    new ProductType() { Id = 1, Identifier = Guid.NewGuid(), Name = "Phones", Description = "Phones", Active = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                    new ProductType() { Id = 2, Identifier = Guid.NewGuid(), Name = "Masks", Description = "Masks", Active = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                    new ProductType() { Id = 3, Identifier = Guid.NewGuid(), Name = "Chargers", Description = "Chargers", Active = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                    new ProductType() { Id = 4, Identifier = Guid.NewGuid(), Name = "Earphones", Description = "Earphones", Active = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                    new ProductType() { Id = 5, Identifier = Guid.NewGuid(), Name = "Batteries", Description = "Batteries", Active = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },

                    // Phones
                    new ProductType() { Id = 6, ParentProductTypeId = 1, Identifier = Guid.NewGuid(), Name = "Huawei", Description = "Huawei", Active = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                    new ProductType() { Id = 7, ParentProductTypeId = 1, Identifier = Guid.NewGuid(), Name = "LG", Description = "LG", Active = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                    new ProductType() { Id = 8, ParentProductTypeId = 1, Identifier = Guid.NewGuid(), Name = "Nokia", Description = "Nokia", Active = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                    new ProductType() { Id = 9, ParentProductTypeId = 1, Identifier = Guid.NewGuid(), Name = "Apple", Description = "Apple", Active = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                    new ProductType() { Id = 10, ParentProductTypeId = 1, Identifier = Guid.NewGuid(), Name = "Samsung", Description = "Samsung", Active = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                    new ProductType() { Id = 11, ParentProductTypeId = 1, Identifier = Guid.NewGuid(), Name = "Xiaomi", Description = "Xiaomi", Active = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },

                    // Masks
                    new ProductType() { Id = 12, ParentProductTypeId = 2, Identifier = Guid.NewGuid(), Name = "Huawei", Description = "Huawei", Active = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                    new ProductType() { Id = 13, ParentProductTypeId = 2, Identifier = Guid.NewGuid(), Name = "LG", Description = "LG", Active = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                    new ProductType() { Id = 14, ParentProductTypeId = 2, Identifier = Guid.NewGuid(), Name = "Nokia", Description = "Nokia", Active = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                    new ProductType() { Id = 15, ParentProductTypeId = 2, Identifier = Guid.NewGuid(), Name = "Apple", Description = "Apple", Active = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                    new ProductType() { Id = 16, ParentProductTypeId = 2, Identifier = Guid.NewGuid(), Name = "Samsung", Description = "Samsung", Active = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                    new ProductType() { Id = 17, ParentProductTypeId = 2, Identifier = Guid.NewGuid(), Name = "Xiaomi", Description = "Xiaomi", Active = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },

                    // Earphones
                    new ProductType() { Id = 18, ParentProductTypeId = 4, Identifier = Guid.NewGuid(), Name = "Huawei", Description = "Huawei", Active = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                    new ProductType() { Id = 19, ParentProductTypeId = 4, Identifier = Guid.NewGuid(), Name = "LG", Description = "LG", Active = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                    new ProductType() { Id = 20, ParentProductTypeId = 4, Identifier = Guid.NewGuid(), Name = "Nokia", Description = "Nokia", Active = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                    new ProductType() { Id = 21, ParentProductTypeId = 4, Identifier = Guid.NewGuid(), Name = "Apple", Description = "Apple", Active = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                    new ProductType() { Id = 22, ParentProductTypeId = 4, Identifier = Guid.NewGuid(), Name = "Samsung", Description = "Samsung", Active = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                    new ProductType() { Id = 23, ParentProductTypeId = 4, Identifier = Guid.NewGuid(), Name = "Xiaomi", Description = "Xiaomi", Active = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now }

            );


            #region Huawei Phones
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    Identifier = Guid.NewGuid(),
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "Huawei P30 Lite Dual SIM 128GB 4GB RAM",
                    Description = @"
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
                            </table>",
                    Discount = 0,
                    Price = 500,
                    Tags = "Phones;Huawei;P30;Lite;"
                }
            );

            modelBuilder.Entity<Product_ProductType>().HasData(
                new Product_ProductType() { ProductId = 1, ProductTypeId = 6 }
            );
            modelBuilder.Entity<ProductPhoto>().HasData(
                new ProductPhoto() { ProductId = 1, PhotoPath = "/photos/phones/Huawei/Huawei_P30_Lite_Blue_Front.jpg", MainPhoto = true }
            );



            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 2,
                    Identifier = Guid.NewGuid(),
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "Huawei P20 Dual SIM 64GB 4GB RAM",
                    Description = @"
                        
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
                                </table>",
                    Discount = 0,
                    Price = 309,
                    Tags = "Phones;Huawei;P20;Dual-Sim;"
                }
            );

            modelBuilder.Entity<Product_ProductType>().HasData(
                new Product_ProductType() { ProductId = 2, ProductTypeId = 6 }
            );
            modelBuilder.Entity<ProductPhoto>().HasData(
                new ProductPhoto() { ProductId = 2, PhotoPath = "/photos/phones/Huawei/Huawei_P20_Twilight_Front.jpg", MainPhoto = true }
            );
            #endregion

            #region LG Phones
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 3,
                    Identifier = Guid.NewGuid(),
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "LG V50 ThinQ 5G 128GB 6GB RAM",
                    Description = @"
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
                                </table>",
                    Discount = 0,
                    Price = 825,
                    Tags = "Phones;LG;V50;ThinQ;"
                }
            );

            modelBuilder.Entity<Product_ProductType>().HasData(
                new Product_ProductType() { ProductId = 3, ProductTypeId = 7 }
            );
            modelBuilder.Entity<ProductPhoto>().HasData(
                new ProductPhoto() { ProductId = 3, PhotoPath = "/photos/phones/LG/LG_V50_ThinQ_5G_Black_Front.jpg", MainPhoto = true }
            );


            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 4,
                    Identifier = Guid.NewGuid(),
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "LG V40 ThinQ Dual SIM 128GB 6GB RAM",
                    Description = @"
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
                            </table>",
                    Discount = 0,
                    Price = 425,
                    Tags = "Phones;LG;V40;ThinQ;"
                }
            );

            modelBuilder.Entity<Product_ProductType>().HasData(
                new Product_ProductType() { ProductId = 4, ProductTypeId = 7 }
            );
            modelBuilder.Entity<ProductPhoto>().HasData(
                new ProductPhoto() { ProductId = 4, PhotoPath = "/photos/phones/LG/LG_V40_Thinq_Platinum_Grey_Front.jpg", MainPhoto = true }
            );

            #endregion

            #region Nokia Phones
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 5,
                    Identifier = Guid.NewGuid(),
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "Nokia 7.2 Dual SIM 128GB 6GB RAM",
                    Description = @"
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
                            </table>",
                    Discount = 0,
                    Price = 319,
                    Tags = "Phones;Nokia;7.2;Dual-Sim;"
                }
            );

            modelBuilder.Entity<Product_ProductType>().HasData(
                new Product_ProductType() { ProductId = 5, ProductTypeId = 8 }
            );
            modelBuilder.Entity<ProductPhoto>().HasData(
                new ProductPhoto() { ProductId = 5, PhotoPath = "/photos/phones/Nokia/Nokia_7-2_Green_Front.jpg", MainPhoto = true }
            );
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 6,
                    Identifier = Guid.NewGuid(),
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "Nokia 6.2 Dual SIM 128GB 4GB RAM",
                    Description = @"
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
                            </table>",
                    Discount = 0,
                    Price = 255,
                    Tags = "Phones;Nokia;6.2;Dual-Sim;"
                }
            );

            modelBuilder.Entity<Product_ProductType>().HasData(
                new Product_ProductType() { ProductId = 6, ProductTypeId = 8 }
            );
            modelBuilder.Entity<ProductPhoto>().HasData(
                new ProductPhoto() { ProductId = 6, PhotoPath = "/photos/phones/Nokia/Nokia_6-2_Black_Front.jpg", MainPhoto = true }
            );
            #endregion

            #region Apple Phones
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 7,
                    Identifier = Guid.NewGuid(),
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "Apple iPhone 11 Dual eSIM 64GB 4GB",
                    Description = @"
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
                            </table>",
                    Discount = 0,
                    Price = 735,
                    Tags = "Phones;Apple;iPhone;11;XI;Dual-Sim;"
                }
            );

            modelBuilder.Entity<Product_ProductType>().HasData(
                new Product_ProductType() { ProductId = 7, ProductTypeId = 9 }
            );
            modelBuilder.Entity<ProductPhoto>().HasData(
                new ProductPhoto() { ProductId = 7, PhotoPath = "/photos/phones/Apple/Apple_iPhone_11_Yellow_Front.jpg", MainPhoto = true }
            );


            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 8,
                    Identifier = Guid.NewGuid(),
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "Apple iPhone X 64GB",
                    Description = @"
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
                        </table>",
                    Discount = 0,
                    Price = 425,
                    Tags = "Phones;Apple;iPhone;10;X;"
                }
            );

            modelBuilder.Entity<Product_ProductType>().HasData(
                new Product_ProductType() { ProductId = 8, ProductTypeId = 9 }
            );
            modelBuilder.Entity<ProductPhoto>().HasData(
                new ProductPhoto() { ProductId = 8, PhotoPath = "/photos/phones/Apple/Apple_iPhone_X_Space_Grey_Front.jpg", MainPhoto = true }
            );

            #endregion

            #region Samsung Phones
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 9,
                    Identifier = Guid.NewGuid(),
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "Samsung Galaxy Note 10 Lite Dual SIM 128GB 6GB RAM",
                    Description = @"
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
                        </table>",
                    Discount = 0,
                    Price = 980,
                    Tags = "Phones;Samsung;Galaxy;Note10;Dual-Sim;"
                }
            );

            modelBuilder.Entity<Product_ProductType>().HasData(
                new Product_ProductType() { ProductId = 9, ProductTypeId = 10 }
            );
            modelBuilder.Entity<ProductPhoto>().HasData(
                new ProductPhoto() { ProductId = 9, PhotoPath = "/photos/phones/Samsung/Samsung_Galaxy_Note_10_Lite_Aura_Black_Front.jpg", MainPhoto = true }
            );


            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 10,
                    Identifier = Guid.NewGuid(),
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "Samsung Galaxy A50 Dual SIM 128GB 4GB RAM",
                    Description = @"
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
                        </table>",
                    Discount = 0,
                    Price = 300,
                    Tags = "Phones;Samsung;Galaxy;A50;Dual-Sim;"
                }
            );

            modelBuilder.Entity<Product_ProductType>().HasData(
                new Product_ProductType() { ProductId = 10, ProductTypeId = 10 }
            );
            modelBuilder.Entity<ProductPhoto>().HasData(
                new ProductPhoto() { ProductId = 10, PhotoPath = "/photos/phones/Samsung/Samsung_Galaxy_A50_Black_Front.jpg", MainPhoto = true }
            );

            #endregion

            #region Xiaomi Phones
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 11,
                    Identifier = Guid.NewGuid(),
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "Xiaomi Mi Note 10 Pro Dual SIM 256GB 8GB RAM",
                    Description = @"
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
                        </table>",
                    Discount = 0,
                    Price = 510,
                    Tags = "Phones;Xiaomi;Mi;Note10;Pro;Dual-Sim;"
                }
            );

            modelBuilder.Entity<Product_ProductType>().HasData(
                new Product_ProductType() { ProductId = 11, ProductTypeId = 11 }
            );
            modelBuilder.Entity<ProductPhoto>().HasData(
                new ProductPhoto() { ProductId = 11, PhotoPath = "/photos/phones/Xiaomi/Xiaomi_Mi_Note-Pro_10_Green_Front.jpg", MainPhoto = true }
            );


            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 12,
                    Identifier = Guid.NewGuid(),
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "Xiaomi Mi 9 Lite Dual SIM 128GB 6GB RAM",
                    Description = @"
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
                        </table>",
                    Discount = 0,
                    Price = 350,
                    Tags = "Phones;Xiaomi;Mi;9;Lite;Dual-Sim;"
                }
            );

            modelBuilder.Entity<Product_ProductType>().HasData(
                new Product_ProductType() { ProductId = 12, ProductTypeId = 11 }
            );
            modelBuilder.Entity<ProductPhoto>().HasData(
                new ProductPhoto() { ProductId = 12, PhotoPath = "/photos/phones/Xiaomi/Xiaomi_Mi_9_Lite_White_Front.jpg", MainPhoto = true }
            );

            #endregion




            #region Huawei Masks

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 13,
                    Identifier = Guid.NewGuid(),
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "Huawei Honor 10 Lite Pink",
                    Description = @"",
                    Discount = 10,
                    Price = 18,
                    Tags = "Masks;"
                }
            );

            modelBuilder.Entity<Product_ProductType>().HasData(
                new Product_ProductType() { ProductId = 13, ProductTypeId = 12 }
            );
            modelBuilder.Entity<ProductPhoto>().HasData(
                new ProductPhoto() { ProductId = 13, PhotoPath = "/photos/masks/Huawei/honor-10-lite.png", MainPhoto = true }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 14,
                    Identifier = Guid.NewGuid(),
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "Huawei P30 Lite Black",
                    Description = @"",
                    Discount = 5,
                    Price = 16,
                    Tags = "Masks;"
                }
            );

            modelBuilder.Entity<Product_ProductType>().HasData(
                new Product_ProductType() { ProductId = 14, ProductTypeId = 12 }
            );
            modelBuilder.Entity<ProductPhoto>().HasData(
                new ProductPhoto() { ProductId = 14, PhotoPath = "/photos/masks/Huawei/huawei,p30 lite.png", MainPhoto = true }
            );
            #endregion

            #region LG Masks

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 15,
                    Identifier = Guid.NewGuid(),
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "LG G3 Blue",
                    Description = @"",
                    Discount = 0,
                    Price = 12,
                    Tags = "Masks;"
                }
            );

            modelBuilder.Entity<Product_ProductType>().HasData(
                new Product_ProductType() { ProductId = 15, ProductTypeId = 13 }
            );
            modelBuilder.Entity<ProductPhoto>().HasData(
                new ProductPhoto() { ProductId = 15, PhotoPath = "/photos/masks/LG/lg-g3.png", MainPhoto = true }
            );
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 16,
                    Identifier = Guid.NewGuid(),
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "LG K4 Pink",
                    Description = @"",
                    Discount = 0,
                    Price = 14,
                    Tags = "Masks;"
                }
            );

            modelBuilder.Entity<Product_ProductType>().HasData(
                new Product_ProductType() { ProductId = 16, ProductTypeId = 13 }
            );
            modelBuilder.Entity<ProductPhoto>().HasData(
                new ProductPhoto() { ProductId = 16, PhotoPath = "/photos/masks/LG/lg-k4.png", MainPhoto = true }
            );

            #endregion

            #region Nokia Masks

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 17,
                    Identifier = Guid.NewGuid(),
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "Nokia 2 Black",
                    Description = @"",
                    Discount = 0,
                    Price = 12,
                    Tags = "Masks;"
                }
            );

            modelBuilder.Entity<Product_ProductType>().HasData(
                new Product_ProductType() { ProductId = 17, ProductTypeId = 14 }
            );
            modelBuilder.Entity<ProductPhoto>().HasData(
                new ProductPhoto() { ProductId = 17, PhotoPath = "/photos/masks/Nokia/nokia2.png", MainPhoto = true }
            );
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 18,
                    Identifier = Guid.NewGuid(),
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "Nokia 5 Army",
                    Description = @"",
                    Discount = 10,
                    Price = 10,
                    Tags = "Masks;"
                }
            );

            modelBuilder.Entity<Product_ProductType>().HasData(
                new Product_ProductType() { ProductId = 18, ProductTypeId = 14 }
            );
            modelBuilder.Entity<ProductPhoto>().HasData(
                new ProductPhoto() { ProductId = 18, PhotoPath = "/photos/masks/Nokia/nokia-5-army.png", MainPhoto = true }
            );

            #endregion

            #region Apple Masks

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 19,
                    Identifier = Guid.NewGuid(),
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "Apple iPhone 11 Pro Army",
                    Description = @"",
                    Discount = 5,
                    Price = 35,
                    Tags = "Masks;"
                }
            );

            modelBuilder.Entity<Product_ProductType>().HasData(
                new Product_ProductType() { ProductId = 19, ProductTypeId = 15 }
            );
            modelBuilder.Entity<ProductPhoto>().HasData(
                new ProductPhoto() { ProductId = 19, PhotoPath = "/photos/masks/Apple/apple_iphone 11 pro.jpg", MainPhoto = true }
            );
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 20,
                    Identifier = Guid.NewGuid(),
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "Apple iPhone XS Pink",
                    Description = @"",
                    Discount = 0,
                    Price = 30,
                    Tags = "Masks;"
                }
            );

            modelBuilder.Entity<Product_ProductType>().HasData(
                new Product_ProductType() { ProductId = 20, ProductTypeId = 15 }
            );
            modelBuilder.Entity<ProductPhoto>().HasData(
                new ProductPhoto() { ProductId = 20, PhotoPath = "/photos/masks/Apple/iphone xs.jpeg", MainPhoto = true }
            );

            #endregion

            #region Samsung Masks

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 21,
                    Identifier = Guid.NewGuid(),
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "Samsung A50 Light",
                    Description = @"",
                    Discount = 0,
                    Price = 14,
                    Tags = "Masks;"
                }
            );

            modelBuilder.Entity<Product_ProductType>().HasData(
                new Product_ProductType() { ProductId = 21, ProductTypeId = 16 }
            );
            modelBuilder.Entity<ProductPhoto>().HasData(
                new ProductPhoto() { ProductId = 21, PhotoPath = "/photos/masks/Samsung/a50.png", MainPhoto = true }
            );
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 22,
                    Identifier = Guid.NewGuid(),
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "Samsung S10 Lite Pattern",
                    Description = @"",
                    Discount = 0,
                    Price = 22,
                    Tags = "Masks;"
                }
            );

            modelBuilder.Entity<Product_ProductType>().HasData(
                new Product_ProductType() { ProductId = 22, ProductTypeId = 16 }
            );
            modelBuilder.Entity<ProductPhoto>().HasData(
                new ProductPhoto() { ProductId = 22, PhotoPath = "/photos/masks/Samsung/s10lite.jpg", MainPhoto = true }
            );

            #endregion

            #region Xiaomi Masks

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 23,
                    Identifier = Guid.NewGuid(),
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "Xiaomi Mi A2 Black",
                    Description = @"",
                    Discount = 0,
                    Price = 5,
                    Tags = "Masks;"
                }
            );

            modelBuilder.Entity<Product_ProductType>().HasData(
                new Product_ProductType() { ProductId = 23, ProductTypeId = 17 }
            );
            modelBuilder.Entity<ProductPhoto>().HasData(
                new ProductPhoto() { ProductId = 23, PhotoPath = "/photos/masks/Xiaomi/mi-a2.png", MainPhoto = true }
            );
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 24,
                    Identifier = Guid.NewGuid(),
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "Xiaomi Redmi Note 7 Blue",
                    Description = @"",
                    Discount = 0,
                    Price = 5,
                    Tags = "Masks;"
                }
            );

            modelBuilder.Entity<Product_ProductType>().HasData(
                new Product_ProductType() { ProductId = 24, ProductTypeId = 17 }
            );
            modelBuilder.Entity<ProductPhoto>().HasData(
                new ProductPhoto() { ProductId = 24, PhotoPath = "/photos/masks/Xiaomi/redmi-note-7.png", MainPhoto = true }
            );

            #endregion




            #region Huawei Earphones

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 25,
                    Identifier = Guid.NewGuid(),
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "Huawei AM116 White",
                    Description = @"",
                    Discount = 3,
                    Price = 24,
                    Tags = "Earphones;"
                }
            );

            modelBuilder.Entity<Product_ProductType>().HasData(
                new Product_ProductType() { ProductId = 25, ProductTypeId = 18 }
            );
            modelBuilder.Entity<ProductPhoto>().HasData(
                new ProductPhoto() { ProductId = 25, PhotoPath = "/photos/earphones/Huawei/huawei-am116-bele.jpg", MainPhoto = true }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 26,
                    Identifier = Guid.NewGuid(),
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "Huawei CM70c Bluetooth",
                    Description = @"",
                    Discount = 3,
                    Price = 34,
                    Tags = "Earphones;"
                }
            );

            modelBuilder.Entity<Product_ProductType>().HasData(
                new Product_ProductType() { ProductId = 26, ProductTypeId = 18 }
            );
            modelBuilder.Entity<ProductPhoto>().HasData(
                new ProductPhoto() { ProductId = 26, PhotoPath = "/photos/earphones/Huawei/huawei-cm70-c-bluetooth.jpg", MainPhoto = true }
            );
            #endregion

            #region LG Earphones

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 27,
                    Identifier = Guid.NewGuid(),
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "LG HBS 835 Tone Ultra Bluetooth",
                    Description = @"",
                    Discount = 3,
                    Price = 28,
                    Tags = "Earphones;"
                }
            );

            modelBuilder.Entity<Product_ProductType>().HasData(
                new Product_ProductType() { ProductId = 27, ProductTypeId = 19 }
            );
            modelBuilder.Entity<ProductPhoto>().HasData(
                new ProductPhoto() { ProductId = 27, PhotoPath = "/photos/earphones/LG/lg-hbs-835-tone-ultra-bluetooth.jpg", MainPhoto = true }
            );

            #endregion

            #region Nokia Earphones

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 29,
                    Identifier = Guid.NewGuid(),
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "Nokia DAB",
                    Description = @"",
                    Discount = 0,
                    Price = 11,
                    Tags = "Earphones;"
                }
            );

            modelBuilder.Entity<Product_ProductType>().HasData(
                new Product_ProductType() { ProductId = 29, ProductTypeId = 20 }
            );
            modelBuilder.Entity<ProductPhoto>().HasData(
                new ProductPhoto() { ProductId = 29, PhotoPath = "/photos/earphones/Nokia/Nokia DAB.jpg", MainPhoto = true }
            );
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 30,
                    Identifier = Guid.NewGuid(),
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "Nokia Pro Wireless",
                    Description = @"",
                    Discount = 0,
                    Price = 32,
                    Tags = "Earphones;"
                }
            );

            modelBuilder.Entity<Product_ProductType>().HasData(
                new Product_ProductType() { ProductId = 30, ProductTypeId = 20 }
            );
            modelBuilder.Entity<ProductPhoto>().HasData(
                new ProductPhoto() { ProductId = 30, PhotoPath = "/photos/earphones/Nokia/nokia_pro_wireless.jpg", MainPhoto = true }
            );

            #endregion

            #region Apple Earphones

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 31,
                    Identifier = Guid.NewGuid(),
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "Apple AirPods 2019",
                    Description = @"",
                    Discount = 5,
                    Price = 199,
                    Tags = "Earphones;"
                }
            );

            modelBuilder.Entity<Product_ProductType>().HasData(
                new Product_ProductType() { ProductId = 31, ProductTypeId = 21 }
            );
            modelBuilder.Entity<ProductPhoto>().HasData(
                new ProductPhoto() { ProductId = 31, PhotoPath = "/photos/earphones/Apple/apple airpods2019.jpeg", MainPhoto = true }
            );
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 32,
                    Identifier = Guid.NewGuid(),
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "Apple iPhone 5, iPhone 6 Wired",
                    Description = @"",
                    Discount = 0,
                    Price = 20,
                    Tags = "Earphones;"
                }
            );

            modelBuilder.Entity<Product_ProductType>().HasData(
                new Product_ProductType() { ProductId = 32, ProductTypeId = 21 }
            );
            modelBuilder.Entity<ProductPhoto>().HasData(
                new ProductPhoto() { ProductId = 32, PhotoPath = "/photos/earphones/Apple/iphone-5-6.png", MainPhoto = true }
            );

            #endregion

            #region Samsung Earphones

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 33,
                    Identifier = Guid.NewGuid(),
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "Samsung EO HS1301be Wireless White",
                    Description = @"",
                    Discount = 1,
                    Price = 23,
                    Tags = "Earphones;"
                }
            );

            modelBuilder.Entity<Product_ProductType>().HasData(
                new Product_ProductType() { ProductId = 33, ProductTypeId = 22 }
            );
            modelBuilder.Entity<ProductPhoto>().HasData(
                new ProductPhoto() { ProductId = 33, PhotoPath = "/photos/earphones/Samsung/samsung eo-hs1301-be.jpg", MainPhoto = true }
            );
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 34,
                    Identifier = Guid.NewGuid(),
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "Samsung mg900 ewe Bluetooth Mono",
                    Description = @"",
                    Discount = 4,
                    Price = 22,
                    Tags = "Earphones;"
                }
            );

            modelBuilder.Entity<Product_ProductType>().HasData(
                new Product_ProductType() { ProductId = 34, ProductTypeId = 22 }
            );
            modelBuilder.Entity<ProductPhoto>().HasData(
                new ProductPhoto() { ProductId = 34, PhotoPath = "/photos/earphones/Samsung/samsung-mg900-eo-mg900-ewe-bluetooth-mono.jpg", MainPhoto = true }
            );

            #endregion

            #region Xiaomi Earphones

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 35,
                    Identifier = Guid.NewGuid(),
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "Xiaomi Mi Dual Driver",
                    Description = @"",
                    Discount = 5,
                    Price = 11,
                    Tags = "Earphones;"
                }
            );

            modelBuilder.Entity<Product_ProductType>().HasData(
                new Product_ProductType() { ProductId = 35, ProductTypeId = 23 }
            );
            modelBuilder.Entity<ProductPhoto>().HasData(
                new ProductPhoto() { ProductId = 35, PhotoPath = "/photos/earphones/Xiaomi/xiaomi-mi-dual-driver.jpg", MainPhoto = true }
            );
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 36,
                    Identifier = Guid.NewGuid(),
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "Xiaomi Mi Earphones Basic",
                    Description = @"",
                    Discount = 0,
                    Price = 7,
                    Tags = "Earphones;"
                }
            );

            modelBuilder.Entity<Product_ProductType>().HasData(
                new Product_ProductType() { ProductId = 36, ProductTypeId = 23 }
            );
            modelBuilder.Entity<ProductPhoto>().HasData(
                new ProductPhoto() { ProductId = 36, PhotoPath = "/photos/earphones/Xiaomi/xiaomi-mi-earphones-basic.jpg", MainPhoto = true }
            );

            #endregion




            #region Chargers


            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 37,
                    Identifier = Guid.NewGuid(),
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "Charger 1",
                    Description = @"",
                    Discount = 5,
                    Price = 11,
                    Tags = "Chargers;"
                }
            );

            modelBuilder.Entity<Product_ProductType>().HasData(
                new Product_ProductType() { ProductId = 37, ProductTypeId = 3 }
            );
            modelBuilder.Entity<ProductPhoto>().HasData(
                new ProductPhoto() { ProductId = 37, PhotoPath = "/photos/chargers/c1.jpg", MainPhoto = true }
            );


            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 38,
                    Identifier = Guid.NewGuid(),
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "Charger 2",
                    Description = @"",
                    Discount = 5,
                    Price = 11,
                    Tags = "Chargers;"
                }
            );

            modelBuilder.Entity<Product_ProductType>().HasData(
                new Product_ProductType() { ProductId = 38, ProductTypeId = 3 }
            );
            modelBuilder.Entity<ProductPhoto>().HasData(
                new ProductPhoto() { ProductId = 38, PhotoPath = "/photos/chargers/c2.jpg", MainPhoto = true }
            );


            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 39,
                    Identifier = Guid.NewGuid(),
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "Charger 3",
                    Description = @"",
                    Discount = 5,
                    Price = 11,
                    Tags = "Chargers;"
                }
            );

            modelBuilder.Entity<Product_ProductType>().HasData(
                new Product_ProductType() { ProductId = 39, ProductTypeId = 3 }
            );
            modelBuilder.Entity<ProductPhoto>().HasData(
                new ProductPhoto() { ProductId = 39, PhotoPath = "/photos/chargers/c3.jpg", MainPhoto = true }
            );


            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 40,
                    Identifier = Guid.NewGuid(),
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "Charger 4",
                    Description = @"",
                    Discount = 5,
                    Price = 11,
                    Tags = "Chargers;"
                }
            );

            modelBuilder.Entity<Product_ProductType>().HasData(
                new Product_ProductType() { ProductId = 40, ProductTypeId = 3 }
            );
            modelBuilder.Entity<ProductPhoto>().HasData(
                new ProductPhoto() { ProductId = 40, PhotoPath = "/photos/chargers/c4.jpg", MainPhoto = true }
            );


            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 41,
                    Identifier = Guid.NewGuid(),
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "Charger 5",
                    Description = @"",
                    Discount = 5,
                    Price = 11,
                    Tags = "Chargers;"
                }
            );

            modelBuilder.Entity<Product_ProductType>().HasData(
                new Product_ProductType() { ProductId = 41, ProductTypeId = 3 }
            );
            modelBuilder.Entity<ProductPhoto>().HasData(
                new ProductPhoto() { ProductId = 41, PhotoPath = "/photos/chargers/c5.jpg", MainPhoto = true }
            );


            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 42,
                    Identifier = Guid.NewGuid(),
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "Power Bank",
                    Description = @"PowerBank with capacity of 10000mAh.",
                    Discount = 5,
                    Price = 25,
                    Tags = "Chargers;PowerBanks;"
                }
            );

            modelBuilder.Entity<Product_ProductType>().HasData(
                new Product_ProductType() { ProductId = 42, ProductTypeId = 3 }
            );
            modelBuilder.Entity<ProductPhoto>().HasData(
                new ProductPhoto() { ProductId = 42, PhotoPath = "/photos/chargers/c6powerbank.jpg", MainPhoto = true }
            );


            #endregion



            #region Batteries
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 43,
                    Identifier = Guid.NewGuid(),
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "Samsuing Galaxy S4 Battery",
                    Description = @"A Galaxy S4 Battery",
                    Discount = 1,
                    Price = 11,
                    Tags = "Batteries;"
                }
            );

            modelBuilder.Entity<Product_ProductType>().HasData(
                new Product_ProductType() { ProductId = 43, ProductTypeId = 5 }
            );
            modelBuilder.Entity<ProductPhoto>().HasData(
                new ProductPhoto() { ProductId = 43, PhotoPath = "/photos/batteries/Baterija-za-Samsung-Galaxy-S4.jpg", MainPhoto = true }
            );


            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 44,
                    Identifier = Guid.NewGuid(),
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "Samsuing Galaxy W Battery",
                    Description = @"A Galaxy W Battery",
                    Discount = 1,
                    Price = 10,
                    Tags = "Batteries;"
                }
            );

            modelBuilder.Entity<Product_ProductType>().HasData(
                new Product_ProductType() { ProductId = 44, ProductTypeId = 5 }
            );
            modelBuilder.Entity<ProductPhoto>().HasData(
                new ProductPhoto() { ProductId = 44, PhotoPath = "/photos/batteries/Baterija-za-Samsung-Galaxy-W.jpg", MainPhoto = true }
            );


            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 45,
                    Identifier = Guid.NewGuid(),
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "Samsuing Galaxy S3 Battery",
                    Description = @"A Galaxy S3 Battery",
                    Discount = 0,
                    Price = 8,
                    Tags = "Batteries;"
                }
            );

            modelBuilder.Entity<Product_ProductType>().HasData(
                new Product_ProductType() { ProductId = 45, ProductTypeId = 5 }
            );
            modelBuilder.Entity<ProductPhoto>().HasData(
                new ProductPhoto() { ProductId = 45, PhotoPath = "/photos/batteries/Samsung-Galaxy-S3-baterija.jpg", MainPhoto = true }
            );


            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 46,
                    Identifier = Guid.NewGuid(),
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "Huawei P10 Battery",
                    Description = @"A Huawei P10 Battery",
                    Discount = 1,
                    Price = 17,
                    Tags = "Batteries;"
                }
            );

            modelBuilder.Entity<Product_ProductType>().HasData(
                new Product_ProductType() { ProductId = 46, ProductTypeId = 5 }
            );
            modelBuilder.Entity<ProductPhoto>().HasData(
                new ProductPhoto() { ProductId = 46, PhotoPath = "/photos/batteries/thumb_ORG_G510.jpg", MainPhoto = true }
            );


            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 47,
                    Identifier = Guid.NewGuid(),
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "Replacement Battery",
                    Description = @"A Replacement Battery",
                    Discount = 1,
                    Price = 11,
                    Tags = "Batteries;"
                }
            );

            modelBuilder.Entity<Product_ProductType>().HasData(
                new Product_ProductType() { ProductId = 47, ProductTypeId = 5 }
            );
            modelBuilder.Entity<ProductPhoto>().HasData(
                new ProductPhoto() { ProductId = 47, PhotoPath = "/photos/batteries/thumb_se_org1.jpg", MainPhoto = true }
            );


            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 48,
                    Identifier = Guid.NewGuid(),
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "Apple iPhone 4S Battery",
                    Description = @"An Apple iPhone 4S Battery",
                    Discount = 1,
                    Price = 24,
                    Tags = "Batteries;"
                }
            );

            modelBuilder.Entity<Product_ProductType>().HasData(
                new Product_ProductType() { ProductId = 48, ProductTypeId = 5 }
            );
            modelBuilder.Entity<ProductPhoto>().HasData(
                new ProductPhoto() { ProductId = 48, PhotoPath = "/photos/batteries/thumb_slika-iPhone-4s.jpg", MainPhoto = true }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 49,
                    Identifier = Guid.NewGuid(),
                    Active = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Name = "U8500 Replacement Battery",
                    Description = @"A U8500 Replacement Battery",
                    Discount = 0,
                    Price = 19,
                    Tags = "Batteries;"
                }
            );

            modelBuilder.Entity<Product_ProductType>().HasData(
                new Product_ProductType() { ProductId = 49, ProductTypeId = 5 }
            );
            modelBuilder.Entity<ProductPhoto>().HasData(
                new ProductPhoto() { ProductId = 49, PhotoPath = "/photos/batteries/thumb_u8500.jpg", MainPhoto = true }
            );
            #endregion
        }
    }
}
