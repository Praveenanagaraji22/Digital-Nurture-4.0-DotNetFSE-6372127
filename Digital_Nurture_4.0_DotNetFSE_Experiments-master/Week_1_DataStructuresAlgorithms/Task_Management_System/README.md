# Exercise 5: Task Management System

## Aim
To implement a task management system using a **singly linked list** in C#. This system should support adding, searching, traversing, and deleting tasks efficiently.

---

## 1. Understanding Linked Lists

### Singly Linked List
- Each node contains a reference to the next node.
- Supports efficient insertions and deletions compared to arrays.
- Traversal is one-directional.

### Doubly Linked List (Not used here)
- Each node contains references to both the next and previous nodes.
- Allows traversal in both directions.
- Uses more memory due to additional pointer.

---

## 2. Project Structure

- **Program.cs** – Main class to run the system
- **Task.cs** – Task class with taskId, name, and status
- **TaskNode.cs** – Node class for singly linked list
- **TaskManagement.cs** – Contains task operations: add, search, traverse, delete
- **README.md** – Project documentation

---

## 3. Setup

### Task Class (`Task.cs`)
Attributes:
- `taskId` (int)
- `taskName` (string)
- `status` (string)

---

## 4. Implementation

### Add Task
- Adds task to the end of the linked list.
- **Time Complexity**: O(n)

### Search Task
- Searches task by ID using linear traversal.
- **Time Complexity**: O(n)

### Traverse Tasks
- Iterates through all nodes and displays task data.
- **Time Complexity**: O(n)

### Delete Task
- Finds the task by ID and removes it from the list.
- **Time Complexity**: O(n)

---

## How to run:
1. Open terminal in the project directory.
  


2. Run main code:
   ```bash
   dotnet run

## OUTPUT:

![image](https://github.com/user-attachments/assets/bb2b8f9a-cb72-4b22-a64e-1478fe41ed9d)
![image](https://github.com/user-attachments/assets/2f07825e-c02f-4ca3-a08a-62a4fcb29cba)

