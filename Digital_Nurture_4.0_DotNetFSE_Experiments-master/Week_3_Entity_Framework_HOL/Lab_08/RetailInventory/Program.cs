using System;
using System.Threading.Tasks;
using RetailInventory.Models;

namespace RetailInventory
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var context = new AppDbContext();

            var category = new Category { Name = "Mobiles" };
            var phone = new Product
            {
                Name = "iPhone 15",
                Price = 90000,
                StockQuantity = 15,
                Category = category
            };

            await context.Categories.AddAsync(category);
            await context.Products.AddAsync(phone);
            await context.SaveChangesAsync();

            Console.WriteLine("Product with stock quantity added!");
        }
    }
}
