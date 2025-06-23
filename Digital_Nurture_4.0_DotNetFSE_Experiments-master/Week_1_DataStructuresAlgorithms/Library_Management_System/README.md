# Exercise 6: Library Management System

## Aim
To implement a library management system in C# that allows users to search for books by title using both **linear search** and **binary search**.

---

## 1. Understanding Search Algorithms

### Linear Search
- Traverses each element one by one.
- Does **not** require sorted data.
- Best suited for small or unsorted datasets.

### Binary Search
- Repeatedly divides a **sorted** array in half to locate the item.
- Requires data to be **sorted** by title.
- Much faster for large datasets.

---

## 2. Project Structure

- **Program.cs** – Entry point to demonstrate both search methods.
- **Book.cs** – Class defining a book with `bookId`, `title`, and `author`.
- **Library.cs** – Contains methods to perform linear and binary search.
- **README.md** – Project documentation.

---

## 3. Setup

### Book Class
```csharp
public class Book
{
    public int BookId;
    public string Title;
    public string Author;
}
```

## How to run:
1. Open terminal in the project directory.
  


2. Run main code:
   ```bash
   dotnet run

## OUTPUT:

![image](https://github.com/user-attachments/assets/f5030ff3-e0cd-4765-8f88-606c0a4e8752)
![image](https://github.com/user-attachments/assets/5cd46184-c351-44e2-bf98-b3f192902d8e)

