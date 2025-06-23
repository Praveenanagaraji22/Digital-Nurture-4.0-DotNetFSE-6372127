# Builder Pattern Example

## Aim
To implement the Builder Design Pattern in Java by creating a meal ordering system where a complex object (Meal) is constructed step-by-step using a builder, allowing flexibility in the construction process and ensuring immutability of the final object.

## Objective
- To understand and apply the Builder Design Pattern.
- To separate the construction of a complex object from its representation.
- To allow the same construction process to create different representations.
- To make object construction more readable and maintainable, especially for objects with many optional parameters.

## Definition of Builder Pattern
The Builder Pattern is a **creational design pattern** that lets you construct complex objects step by step. It allows you to create different types and representations of an object using the same construction process. It helps avoid the telescoping constructor anti-pattern and promotes a more readable object creation process.

---

## Project Structure
- `Meal` (Product Class): Contains properties like burger, drink, dessert, etc.
- `MealBuilder` (Interface): Declares methods to build parts of the product.
- `VegMealBuilder`, `NonVegMealBuilder` (Concrete Builders): Implement the steps defined in `MealBuilder`.
- `MealDirector` (Director Class): Constructs a meal using the builder.
- `Main` (Client Class): Demonstrates usage of the builder pattern.

---

## How to Run

1. **Open your terminal and navigate to the project folder.**


2. **Run the Main class:**
   ```bash
   dotnet run

## OUTPUT:

![image](https://github.com/user-attachments/assets/74ea5b86-0a86-46b8-a65e-46046394917e)


![image](https://github.com/user-attachments/assets/ef8d7271-97d1-4db4-8e36-b1a81c351539)





