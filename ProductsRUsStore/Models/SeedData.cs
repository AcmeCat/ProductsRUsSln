using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace ProductsRUsStore.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
            .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Robot Vacuum Cleaner",
                        Description = "White Colour 2000W",
                        Category = "Home & Kitchen",
                        Price = 249,
                        Image = "product1.png"
                    },
                    new Product
                    {
                        Name = "Smart Watch",
                        Description = "Fashionable Android Smart Watch",
                        Category = "Electronics",
                        Price = 149,
                        Image = "product2.png"
                    },
                    new Product
                    {
                        Name = "Toy Dinosaurus",
                        Description = "Gift toy for kids",
                        Category = "Toys",
                        Price = 29,
                        Image = "product3.png"
                    },
                    new Product
                    {
                        Name = "Chair",
                        Description = "White colour chair",
                        Category = "Home Decor",
                        Price = 119,
                        Image = "product4.png"
                    },
                    new Product
                    {
                        Name = "Kettle",
                        Description = "1.25L metallic",
                        Category = "Kitchen",
                        Price = 49,
                        Image = "product5.png"
                    },
                    new Product
                    {
                        Name = "Kids Bedside Table",
                        Description = "2 draw bedside table",
                        Category = "Furniture",
                        Price = 299,
                        Image = "product6.png"
                    },
                    new Product
                    {
                        Name = "Tea Set",
                        Description = "Ceramic handmade tea set",
                        Category = "Kitchen",
                        Price = 199,
                        Image = "product7.png"
                    },
                    new Product
                    {
                        Name = "Watch",
                        Description = "Wrist watch",
                        Category = "Accessories",
                        Price = 129,
                        Image = "product8.png"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
