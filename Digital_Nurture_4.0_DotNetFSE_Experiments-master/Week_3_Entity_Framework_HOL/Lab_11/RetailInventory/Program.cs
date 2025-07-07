using RetailInventory.Models;
using Microsoft.EntityFrameworkCore;

using var context = new AppDbContext();
context.Database.EnsureCreated();

var electronics = new Category { Name = "Electronics" };
var groceries = new Category { Name = "Groceries" };
await context.Categories.AddRangeAsync(electronics, groceries);
await context.SaveChangesAsync(); 

var tagNew = new Tag { Name = "New Arrival" };
var tagSale = new Tag { Name = "On Sale" };
await context.Tags.AddRangeAsync(tagNew, tagSale);
await context.SaveChangesAsync();

var product = new Product
{
    Name = "Smartphone",
    Price = 25000,
    CategoryId = electronics.Id, 
    Tags = new List<Tag> { tagNew, tagSale },
    ProductDetail = new ProductDetail
    {
        WarrantyInfo = "1 year warranty"
    }
};

await context.Products.AddAsync(product);
await context.SaveChangesAsync();

Console.WriteLine("Product with ProductDetail and Tags saved successfully!");
