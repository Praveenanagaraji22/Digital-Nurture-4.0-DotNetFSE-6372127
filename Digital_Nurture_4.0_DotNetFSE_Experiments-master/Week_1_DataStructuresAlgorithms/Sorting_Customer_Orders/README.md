# Exercise 3: Sorting Customer Orders

## Aim
To sort customer orders by their total price using Bubble Sort and Quick Sort in C#. This helps prioritize high-value orders in an e-commerce platform.

---

## 1. Understanding Sorting Algorithms

### Bubble Sort
Bubble Sort is a simple comparison-based algorithm that:
- Compares adjacent elements.
- Swaps them if they are in the wrong order.
- Repeats this process until no swaps are needed.

**Time Complexity:**

| Case       | Complexity |
|------------|------------|
| Best Case  | O(n)       |
| Average    | O(n²)      |
| Worst Case | O(n²)      |

### Quick Sort
Quick Sort is a divide-and-conquer algorithm that:
- Selects a pivot element.
- Partitions the array into two halves.
- Recursively sorts the partitions.

**Time Complexity:**

| Case       | Complexity  |
|------------|-------------|
| Best Case  | O(n log n)  |
| Average    | O(n log n)  |
| Worst Case | O(n²)       |

**Why Quick Sort is Preferred:**
- Much faster on large datasets.
- Uses less memory than Merge Sort.
- More efficient than Bubble Sort in most real-world scenarios.

---

## 2. Setup

### Class Definition – `Order.cs`

```csharp
public class Order
{
    public int OrderId { get; set; }
    public string CustomerName { get; set; }
    public double TotalPrice { get; set; }

    public Order(int orderId, string customerName, double totalPrice)
    {
        OrderId = orderId;
        CustomerName = customerName;
        TotalPrice = totalPrice;
    }

    public override string ToString()
    {
        return $"OrderId: {OrderId}, Name: {CustomerName}, Price: ₹{TotalPrice:F2}";
    }
}
```
## How to run:
1. Open terminal in the project directory.
  


2. Run main code:
   ```bash
   dotnet run

## OUTPUT:
![image](https://github.com/user-attachments/assets/e72736c2-65c6-426b-a205-915e77311a77)
![image](https://github.com/user-attachments/assets/ed392814-5f59-4a1e-b9a4-446aeb844540)



