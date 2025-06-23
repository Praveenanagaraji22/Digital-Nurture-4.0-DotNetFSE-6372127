using System;

class Program
{
    static void Main()
    {
        Book[] books = {
            new Book(1, "Algorithms", "CLRS"),
            new Book(2, "Clean Code", "Robert C. Martin"),
            new Book(3, "Data Structures", "Seymour Lipschutz"),
            new Book(4, "Design Patterns", "Erich Gamma"),
            new Book(5, "Introduction to Algorithms", "Thomas H. Cormen")
        };

        // Sort the books array by Title for binary search
        Array.Sort(books, (b1, b2) => b1.Title.CompareTo(b2.Title));

        Library library = new Library(books);

        Console.WriteLine("Linear Search for 'Clean Code':");
        var book1 = library.LinearSearchByTitle("Clean Code");
        Console.WriteLine(book1 != null ? book1.ToString() : "Not found");

        Console.WriteLine("\nBinary Search for 'Design Patterns':");
        var book2 = library.BinarySearchByTitle("Design Patterns");
        Console.WriteLine(book2 != null ? book2.ToString() : "Not found");
    }
}
