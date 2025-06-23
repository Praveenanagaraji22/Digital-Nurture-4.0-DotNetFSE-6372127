# Exercise 4: Employee Management System

## Aim
To implement an employee management system in C# using arrays. The system allows adding, searching, traversing, and deleting employee records efficiently.

---

## 1. Understanding Array Representation

Arrays are stored in **contiguous memory** blocks. Each element is accessed via its index, allowing constant time retrieval.

### Advantages:
- Fast access using index (O(1))
- Simple structure
- Fixed size and predictable performance

---

## 2. Setup

### Class: `Employee`
Attributes:
- `employeeId` (int)
- `name` (string)
- `position` (string)
- `salary` (double)

### Class: `EmployeeManagement`
- Array of Employee objects
- Supports `Add`, `Search`, `Traverse`, and `Delete` operations

---

## 3. Implementation

### Add Employee
- Adds employee to next available index
- Time Complexity: O(1)

### Search Employee
- Linear search by `employeeId`
- Time Complexity: O(n)

### Traverse Employees
- Loops through all employees
- Time Complexity: O(n)

### Delete Employee
- Find by ID, shift all remaining elements
- Time Complexity: O(n)

---

## 4. Time Complexity Summary

| Operation | Time Complexity |
|-----------|-----------------|
| Add       | O(1)            |
| Search    | O(n)            |
| Traverse  | O(n)            |
| Delete    | O(n)            |

---

## 5. Limitations of Arrays

- **Fixed size**: Cannot dynamically grow or shrink.
- **Costly insertions/deletions**: Requires shifting elements.
- **Not ideal for large dynamic datasets** → use `List<T>` or `LinkedList<T>` instead.

---

## How to run:
1. Open terminal in the project directory.
  


2. Run main code:
   ```bash
   dotnet run

## OUTPUT:

![image](https://github.com/user-attachments/assets/79d9a093-d0de-4262-8108-269c8acff72f)
![image](https://github.com/user-attachments/assets/015d1435-d6e0-4624-b4aa-867561ae939e)


