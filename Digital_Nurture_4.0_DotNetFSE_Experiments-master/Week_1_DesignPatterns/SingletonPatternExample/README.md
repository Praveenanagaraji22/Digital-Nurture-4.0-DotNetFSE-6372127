# Singleton Pattern Example

## Aim
To implement the Singleton Design Pattern in Java by creating a logging utility that ensures only one instance of the logger exists throughout the application lifecycle, providing a global point of access to consistent logging.

## Objective
- To understand and apply the Singleton Design Pattern.
- To ensure that a class has only one instance and provides a global point of access to it.
- To demonstrate how Singleton helps in maintaining a shared state across the application.
- To show how thread-safe Singleton can be implemented in Java.

## Definition of Singleton Pattern
The Singleton Pattern is a **creational design pattern** that restricts the instantiation of a class to one object and provides a global point of access to it. It ensures that a class has only one instance and controls access to it.

---

## Project Structure
- `Logger` (Singleton Class): 
  - Has a private static instance of itself.
  - Private constructor to restrict object creation.
  - Public static method `getInstance()` to access the single instance.
- `Main` (Client Class): 
  - Demonstrates that multiple calls to `getInstance()` return the same instance.

---

## How to Run

1. **Open your terminal and navigate to the project folder.**

2. **Run the Main class:**
   ```bash
   dotnet run

## OUTPUT:

![image](https://github.com/user-attachments/assets/b74647aa-d159-4915-89b0-abd71960ad90)
![image](https://github.com/user-attachments/assets/5145b81b-8fb4-4908-99b1-3c0926995770)








