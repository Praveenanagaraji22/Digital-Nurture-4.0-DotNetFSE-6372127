using Microsoft.EntityFrameworkCore;
using RetailInventory.Models;

using var context = new AppDbContext();
await context.Database.EnsureCreatedAsync();

if (!context.Categories.Any())
{
    context.Categories.AddRange(
        new Category { Id = 1, Name = "Electronics" },
        new Category { Id = 2, Name = "Groceries" }
    );
    await context.SaveChangesAsync();
}

if (!context.Products.Any())
{
    context.Products.Add(new Product
    {
        Name = "Laptop",
        Price = 60000,
        StockQuantity = 10,
        CategoryId = 1 
    });
    await context.SaveChangesAsync();
}

Console.WriteLine(" Products added successfully.");
