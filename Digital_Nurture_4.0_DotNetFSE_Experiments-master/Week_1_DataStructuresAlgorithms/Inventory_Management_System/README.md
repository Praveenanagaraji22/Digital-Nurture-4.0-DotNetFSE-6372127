# Inventory Management System - C#

## Aim
To implement an Inventory Management System in C# that efficiently handles adding, updating, deleting, and displaying warehouse products using appropriate data structures.

---

## Problem Understanding

###  Why Data Structures & Algorithms?
Efficient inventory systems require:
- Fast retrieval, insertion, and deletion.
- Scalable handling of thousands of product entries.
Using the right data structure ensures these operations remain performant.

###  Chosen Data Structure
- `Dictionary<int, Product>` is used to store products by `productId`.
- It provides **O(1)** average time complexity for key operations like add, update, and delete.

---

## Project Structure

- **Product.cs** – Defines the `Product` class with attributes and display method.
- **Program.cs** – Contains the `InventorySystem` class with logic for:
  - Adding products
  - Updating product details
  - Deleting products
  - Displaying current inventory
- (Optional) You can create a folder named `InventoryManagementSystem` to hold these files.

---

##  Implementation Overview

###  `Product.cs`
Defines a `Product` class with the following properties:
- `ProductId` (int)
- `ProductName` (string)
- `Quantity` (int)
- `Price` (double)

Includes a constructor and `ToString()` method for easy display.

###  `Program.cs`
Implements an `InventorySystem` class that supports:
- `AddProduct(Product product)`
- `UpdateProduct(int productId, string newName, int newQty, double newPrice)`
- `DeleteProduct(int productId)`
- `DisplayAll()`

`Main()` demonstrates usage with sample data.

---

##  How to Run:
1. Open terminal in the project directory.
  


2. Run main code:
   ```bash
   dotnet run

## Output:

![image](https://github.com/user-attachments/assets/b0cf5364-6ef2-4644-8837-753f27e304a3)
![image](https://github.com/user-attachments/assets/5d5f14e4-ec29-4bb0-ba42-a0b5c29b22b6)

