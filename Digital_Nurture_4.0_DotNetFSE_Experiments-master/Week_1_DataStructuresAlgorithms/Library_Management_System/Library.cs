using System;

public class Library
{
    private Book[] books;

    public Library(Book[] bookArray)
    {
        books = bookArray;
    }

    public Book? LinearSearchByTitle(string title)
    {
        foreach (var book in books)
        {
            if (book.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                return book;
            }
        }
        return null;
    }

    public Book? BinarySearchByTitle(string title)
    {
        int left = 0, right = books.Length - 1;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            int compare = string.Compare(title, books[mid].Title, StringComparison.OrdinalIgnoreCase);

            if (compare == 0)
                return books[mid];
            else if (compare < 0)
                right = mid - 1;
            else
                left = mid + 1;
        }
        return null;
    }
}
