# Decorator Pattern Example

## Aim
To implement the Decorator Design Pattern in Java by building a notification system that supports sending notifications via multiple channels like Email, SMS, and Slack dynamically, without modifying existing code.

## Objective
- To understand and apply the Decorator Pattern.
- To define a common notifier interface.
- To implement a basic email notifier as the concrete component.
- To design decorator classes that add additional channels like SMS and Slack.
- To demonstrate how the Decorator Pattern enables flexible and scalable functionality extension.

## Definition of Decorator Pattern
The Decorator Pattern is a structural design pattern that allows behavior to be added to individual objects, dynamically, without affecting the behavior of other objects from the same class. It wraps an object to provide new behavior while keeping the original object intact.

---

## Project Structure
- `Notifier` (Interface): Declares the `send()` method.
- Concrete Component:
  - `EmailNotifier`: Implements `Notifier` and sends basic email notifications.
- Abstract Decorator:
  - `NotifierDecorator`: Implements `Notifier` and holds a reference to another `Notifier`.
- Concrete Decorators:
  - `SMSNotifierDecorator`: Extends `NotifierDecorator` and adds SMS notification.
  - `SlackNotifierDecorator`: Extends `NotifierDecorator` and adds Slack notification.
- `Main` (Test Class): Demonstrates chaining decorators to send notifications through multiple channels.

---

## How to Run

1. Open terminal in the project directory.
   ```bash
   cd <PatternfileName>


2. Run main code:
   ```bash
   dotnet run

## OUTPUT:
![image](https://github.com/user-attachments/assets/f2623e11-fac6-44da-a15c-a821a80dbaae)

![image](https://github.com/user-attachments/assets/4f34cc42-c4a5-48ae-b6fa-c60ef758cabd)




