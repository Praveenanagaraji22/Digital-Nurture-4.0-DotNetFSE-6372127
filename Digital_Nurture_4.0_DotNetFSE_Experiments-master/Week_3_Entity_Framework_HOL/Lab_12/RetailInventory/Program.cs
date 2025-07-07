using Microsoft.EntityFrameworkCore;
using RetailInventory;
using RetailInventory.Models;

using var context = new AppDbContext();
context.Database.EnsureCreated();

var productDTOs = await context.Products
    .Include(p => p.Category)
    .Select(p => new ProductDTO
    {
        Name = p.Name,
        CategoryName = p.Category.Name
    })
    .ToListAsync();

foreach (var dto in productDTOs)
{
    Console.WriteLine($" {dto.Name} | Category: {dto.CategoryName}");
}
