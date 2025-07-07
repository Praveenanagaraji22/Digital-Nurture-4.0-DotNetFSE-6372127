using Microsoft.EntityFrameworkCore;
using RetailInventory.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

await RunAsync();

async Task RunAsync()
{
   
    Func<AppDbContext, decimal, IAsyncEnumerable<Product>> expensiveQuery =
        EF.CompileAsyncQuery((AppDbContext ctx, decimal minPrice) =>
            ctx.Products.Where(p => p.Price > minPrice));

    using var context = new AppDbContext();
    await context.Database.EnsureCreatedAsync();

    Console.WriteLine("Products with AsNoTracking:");
    var noTrackingProducts = await context.Products
        .AsNoTracking()
        .ToListAsync();

    foreach (var product in noTrackingProducts)
    {
        Console.WriteLine($"- {product.Name} | ₹{product.Price}");
    }

    Console.WriteLine("\nExpensive Products (> ₹20000) using Compiled Query:");

  
    await foreach (var product in expensiveQuery(context, 20000))
{
    Console.WriteLine($"- {product.Name} | ₹{product.Price}");
}



    
}
