# Week 3 – EF Core 8.0 Labs (Summary)

This project covers 15 labs demonstrating EF Core concepts using a RetailInventory system with SQLite.

---

## Lab Descriptions

- **Lab 01:** Setup EF Core project and learn about ORM, EF Core vs EF6.
- **Lab 02:** Define `Category` and `Product` models and configure `AppDbContext`.
- **Lab 03:** Configure SQLite database and test DB creation.
- **Lab 04:** Implement one-to-many relationship between Category and Products.
- **Lab 05:** Use data annotations for validation like `[Required]`, `[MaxLength]`.
- **Lab 06:** Perform basic LINQ queries like `Where`, `Select`, and `OrderBy`.
- **Lab 07:** Handle SQLite-specific limitations (e.g. ordering by unsupported types).
- **Lab 08:** Add a new column `StockQuantity` to Product using migration.
- **Lab 09:** Seed initial data into the database using `HasData()`.
- **Lab 10:** Explore eager and explicit loading using `Include()` and `Entry().Collection()`.
- **Lab 11:** Create and relate new entities `ProductDetail` and `Tag`.
- **Lab 12:** Demonstrate entity deletion and cascading behavior.
- **Lab 13:** Use `AsNoTracking()` and compiled queries for performance.
- **Lab 14:** Execute raw SQL queries using `FromSqlRaw()` in EF Core.
- **Lab 15:** Implement optimistic concurrency with `RowVersion` property.

---

## Usage

```bash

dotnet ef database update
dotnet run
```
