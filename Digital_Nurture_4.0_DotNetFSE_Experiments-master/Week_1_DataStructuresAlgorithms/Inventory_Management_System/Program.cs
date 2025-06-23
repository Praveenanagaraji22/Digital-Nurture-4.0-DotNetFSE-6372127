using System;
using System.Collections.Generic;

class InventorySystem
{
    private Dictionary<int, Product> inventory = new Dictionary<int, Product>();

    public void AddProduct(Product product)
    {
        if (inventory.ContainsKey(product.ProductId))
        {
            Console.WriteLine("Product with this ID already exists.");
            return;
        }
        inventory[product.ProductId] = product;
        Console.WriteLine("Product added.");
    }

    public void UpdateProduct(int productId, string newName, int newQty, double newPrice)
    {
        if (inventory.ContainsKey(productId))
        {
            inventory[productId].ProductName = newName;
            inventory[productId].Quantity = newQty;
            inventory[productId].Price = newPrice;
            Console.WriteLine("Product updated.");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }
    }

    public void DeleteProduct(int productId)
    {
        if (inventory.Remove(productId))
        {
            Console.WriteLine("Product deleted.");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }
    }

    public void DisplayAll()
    {
        Console.WriteLine("\nCurrent Inventory:");
        foreach (var product in inventory.Values)
        {
            Console.WriteLine(product);
        }
    }
}

class Program
{
    static void Main()
    {
        InventorySystem system = new InventorySystem();

        system.AddProduct(new Product(101, "Laptop", 10, 75000));
        system.AddProduct(new Product(102, "Mouse", 50, 500));

        system.UpdateProduct(101, "Gaming Laptop", 5, 85000);

        system.DeleteProduct(102);

        system.DisplayAll();
    }
}
