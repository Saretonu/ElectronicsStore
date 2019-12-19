using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace ElectronicsStore.DatabaseContext
{
    public class ElectronicsStoreDatabaseInitializer : DropCreateDatabaseIfModelChanges<ElectronicsStoreDbContext>
    {
        protected override void Seed(ElectronicsStoreDbContext context)
        {
            context.Items.AddOrUpdate(
                X => X.Name,
                new Models.Item
                {
                    Name = "Full HD LED LCD-teler",
                    Category = Models.Category.TVs,
                    Manufacturer = "Philips",
                    Price = 269.99
                },
                new Models.Item
                {
                    Name = "Ultra HD QLED-teler",
                    Category = Models.Category.TVs,
                    Manufacturer = "Samsung",
                    Price = 819.99
                },
                new Models.Item
                {
                    Name = "Galaxy S10+ Dual SIM(128 GB)",
                    Category = Models.Category.Phones,
                    Manufacturer = "Samsung",
                    Price = 799.99
                },
                new Models.Item
                {
                    Name = "iPhone 7 (32 GB)",
                    Category = Models.Category.Phones,
                    Manufacturer = "Apple",
                    Price = 439.99
                },
                new Models.Item
                {
                    Name = "Iphone 8 Plus (64 GB)",
                    Category = Models.Category.TVs,
                    Manufacturer = "Apple",
                    Price = 649.99
                },
                new Models.Item
                {
                    Name = "Külmik (186 cm)",
                    Category = Models.Category.HomeAppliances,
                    Manufacturer = "Candy",
                    Price = 399
                },
                new Models.Item
                {
                    Name = "Sülearvuti MacBook Air 2017 (128 GB) SWE",
                    Category = Models.Category.Computers,
                    Manufacturer = "Apple",
                    Price = 899.99
                },
                new Models.Item
                {
                    Name = "Sülearvuti IdeaPad L340-17IRH Gaming",
                    Category = Models.Category.Computers,
                    Manufacturer = "Lenovo",
                    Price = 849.99
                }
                );
        }
    }
}