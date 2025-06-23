using System;

class Program
{
    static void BubbleSort(Order[] orders)
    {
        int n = orders.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (orders[j].TotalPrice > orders[j + 1].TotalPrice)
                {
                    var temp = orders[j];
                    orders[j] = orders[j + 1];
                    orders[j + 1] = temp;
                }
            }
        }
    }

    static void QuickSort(Order[] orders, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(orders, low, high);
            QuickSort(orders, low, pi - 1);
            QuickSort(orders, pi + 1, high);
        }
    }

    static int Partition(Order[] orders, int low, int high)
    {
        double pivot = orders[high].TotalPrice;
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (orders[j].TotalPrice <= pivot)
            {
                i++;
                var temp = orders[i];
                orders[i] = orders[j];
                orders[j] = temp;
            }
        }

        var temp2 = orders[i + 1];
        orders[i + 1] = orders[high];
        orders[high] = temp2;

        return i + 1;
    }

    static void DisplayOrders(string title, Order[] orders)
    {
        Console.WriteLine($"\n{title}");
        foreach (var order in orders)
        {
            Console.WriteLine(order);
        }
    }

    static void Main()
    {
        Order[] orders = {
            new Order(101, "Alice", 2500),
            new Order(102, "Bob", 1500),
            new Order(103, "Charlie", 3200),
            new Order(104, "Diana", 2200),
            new Order(105, "Evan", 1800)
        };

        Order[] bubbleSorted = (Order[])orders.Clone();
        Order[] quickSorted = (Order[])orders.Clone();

        BubbleSort(bubbleSorted);
        QuickSort(quickSorted, 0, quickSorted.Length - 1);

        DisplayOrders("Sorted by Bubble Sort (Total Price):", bubbleSorted);
        DisplayOrders("Sorted by Quick Sort (Total Price):", quickSorted);
    }
}
