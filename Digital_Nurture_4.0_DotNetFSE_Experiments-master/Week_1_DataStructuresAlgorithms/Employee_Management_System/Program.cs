using System;

public class Employee
{
    public int EmployeeId { get; set; }
    public string Name { get; set; }
    public string Position { get; set; }
    public double Salary { get; set; }

    public Employee(int id, string name, string position, double salary)
    {
        EmployeeId = id;
        Name = name;
        Position = position;
        Salary = salary;
    }

    public override string ToString()
    {
        return $"ID: {EmployeeId}, Name: {Name}, Position: {Position}, Salary: ₹{Salary:F2}";
    }
}

public class EmployeeManagement
{
    private Employee?[] employees;
    private int count;

    public EmployeeManagement(int capacity)
    {
        employees = new Employee?[capacity];
        count = 0;
    }

    public void AddEmployee(Employee emp)
    {
        if (count < employees.Length)
        {
            employees[count] = emp;
            count++;
        }
        else
        {
            Console.WriteLine("Array is full. Cannot add more employees.");
        }
    }

    public Employee? SearchEmployee(int id)
    {
        for (int i = 0; i < count; i++)
        {
            if (employees[i]?.EmployeeId == id)
            {
                return employees[i];
            }
        }
        return null;
    }

    public void TraverseEmployees()
    {
        for (int i = 0; i < count; i++)
        {
            if (employees[i] != null)
                Console.WriteLine(employees[i]);
        }
    }

    public void DeleteEmployee(int id)
    {
        int index = -1;
        for (int i = 0; i < count; i++)
        {
            if (employees[i]?.EmployeeId == id)
            {
                index = i;
                break;
            }
        }

        if (index != -1)
        {
            for (int j = index; j < count - 1; j++)
            {
                employees[j] = employees[j + 1];
            }
            employees[count - 1] = null;
            count--;
        }
        else
        {
            Console.WriteLine("Employee not found.");
        }
    }
}

class Program
{
    static void Main()
    {
        EmployeeManagement system = new EmployeeManagement(10);

        system.AddEmployee(new Employee(1, "Alice", "Manager", 75000));
        system.AddEmployee(new Employee(2, "Bob", "Developer", 60000));
        system.AddEmployee(new Employee(3, "Charlie", "Analyst", 50000));

        Console.WriteLine("All Employees:");
        system.TraverseEmployees();

        Console.WriteLine("\nSearching for Employee ID 2:");
        var emp = system.SearchEmployee(2);
        if (emp != null)
            Console.WriteLine(emp);
        else
            Console.WriteLine("Not found");

        Console.WriteLine("\nDeleting Employee ID 2...");
        system.DeleteEmployee(2);

        Console.WriteLine("\nAll Employees after Deletion:");
        system.TraverseEmployees();
    }
}
