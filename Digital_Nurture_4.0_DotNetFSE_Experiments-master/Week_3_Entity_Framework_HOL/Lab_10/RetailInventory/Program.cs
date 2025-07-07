using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RetailInventory.Models;

namespace RetailInventory
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var context = new AppDbContext();

            Console.WriteLine("Eager Loading:");
            var products = await context.Products
                .Include(p => p.Category) 
                .ToListAsync();

            foreach (var p in products)
            {
                Console.WriteLine($"- {p.Name} | ₹{p.Price} | Category: {p.Category?.Name}");
            }

            Console.WriteLine("\nExplicit Loading:");
            var singleProduct = await context.Products.FirstOrDefaultAsync();
            if (singleProduct != null)
            {
                await context.Entry(singleProduct)
                    .Reference(p => p.Category)
                    .LoadAsync(); 

                Console.WriteLine($"- {singleProduct.Name} | Category: {singleProduct.Category?.Name}");
            }
        }
    }
}
