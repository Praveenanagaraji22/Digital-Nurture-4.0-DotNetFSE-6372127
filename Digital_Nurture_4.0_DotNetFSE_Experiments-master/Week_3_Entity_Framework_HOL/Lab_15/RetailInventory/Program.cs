using RetailInventory.Models;
using Microsoft.EntityFrameworkCore;

using var context = new AppDbContext();
await context.Database.EnsureCreatedAsync();


if (!context.Categories.Any())
{
    var category = new Category { Name = "Gadgets" };
    var product = new Product { Name = "Bluetooth Speaker", Price = 1500, Category = category };

    context.Add(product);
    await context.SaveChangesAsync();
    Console.WriteLine("Sample product added.");
}
else
{
    Console.WriteLine("Products in DB:");
    foreach (var product in context.Products.Include(p => p.Category))
    {
        Console.WriteLine($"- {product.Name} | ₹{product.Price} | Category: {product.Category.Name}");
    }
}
