# MVC Pattern Example

## Aim
To implement the Model-View-Controller (MVC) architectural pattern in Java by developing a simple student management application that separates data, user interface, and control logic for better modularity and maintainability.

## Objective
- To understand and apply the MVC design pattern.
- To separate the application into Model, View, and Controller components.
- To demonstrate how changes in the model are reflected in the view through the controller.
- To improve code organization, scalability, and testability.

## Definition of MVC Pattern
The MVC Pattern is a **software architectural pattern** that divides an application into three interconnected components:
- **Model**: Manages the data and business logic.
- **View**: Presents data to the user.
- **Controller**: Handles input and updates the model and view.

This separation allows independent development and maintenance of each component.

---

## Project Structure
- `Student` (Model): Contains student data attributes and getter/setter methods.
- `StudentView` (View): Responsible for displaying student information.
- `StudentController` (Controller): Acts as the intermediary between Model and View, updating and retrieving data.
- `Main` (Test Class): Demonstrates creating, updating, and displaying student data using MVC.

---

## How to Run

1. Open terminal in the project directory.


2. Run main class:
   ```bash
   dotnet run

## OUTPUT:
![image](https://github.com/user-attachments/assets/0a59c327-787e-490a-99ac-d0665c02c518)
![image](https://github.com/user-attachments/assets/5223a121-762d-4521-9b19-bf9f496f8765)



