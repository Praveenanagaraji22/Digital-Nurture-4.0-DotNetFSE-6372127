class Program
{
    static Product? LinearSearch(Product[] products, string name)
    {
        foreach (var product in products)
        {
            if (product.ProductName.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                return product;
            }
        }
        return null;
    }

    static Product? BinarySearch(Product[] products, string name)
    {
        int left = 0;
        int right = products.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;
            int comparison = string.Compare(products[mid].ProductName, name, StringComparison.OrdinalIgnoreCase);

            if (comparison == 0)
                return products[mid];
            else if (comparison < 0)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return null;
    }

    static void Main()
    {
        Product[] unsortedProducts = {
            new Product(1, "Laptop", "Electronics"),
            new Product(2, "Shirt", "Fashion"),
            new Product(3, "Book", "Education"),
            new Product(4, "Phone", "Electronics"),
            new Product(5, "Shoes", "Fashion")
        };

        Product[] sortedProducts = (Product[])unsortedProducts.Clone();
        Array.Sort(sortedProducts, (p1, p2) => p1.ProductName.CompareTo(p2.ProductName));

        Console.WriteLine("\n Linear Search for 'Phone':");
        var result1 = LinearSearch(unsortedProducts, "Phone");
        if (result1 != null)
            Console.WriteLine(result1);
        else
            Console.WriteLine("Not Found");

        Console.WriteLine("\n Binary Search for 'Phone':");
        var result2 = BinarySearch(sortedProducts, "Phone");
        if (result2 != null)
            Console.WriteLine(result2);
        else
            Console.WriteLine("Not Found");
    }
}