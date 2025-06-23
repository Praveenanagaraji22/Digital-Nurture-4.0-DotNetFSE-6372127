# Strategy Pattern Example

## Aim
To implement the Strategy Design Pattern in Java by creating a payment system where different payment methods (e.g., Credit Card, PayPal) can be selected dynamically at runtime. This pattern promotes flexibility by allowing the algorithm (payment method) to be selected at runtime without modifying the client code.

## Objective
- To understand and apply the Strategy Design Pattern.
- To encapsulate multiple algorithms (payment methods) within a family of interchangeable classes.
- To allow selection of the algorithm at runtime based on context.
- To reduce coupling between the client and algorithm implementations.

## Definition of Strategy Pattern
The Strategy Pattern is a **behavioral design pattern** that enables selecting an algorithm’s behavior at runtime. It defines a family of algorithms, encapsulates each one, and makes them interchangeable. This pattern lets the algorithm vary independently from the clients that use it.

---

## Project Structure

- `PaymentStrategy` (Interface): Defines the `pay()` method for all payment strategies.
- `CreditCardPayment` (Concrete Strategy): Implements payment using a credit card.
- `PayPalPayment` (Concrete Strategy): Implements payment using PayPal.
- `PaymentContext` (Context Class): Uses a `PaymentStrategy` to process a payment.
- `Main` (Client Class): Demonstrates selecting and using different payment strategies at runtime.

---

## How to Run

1. **Open your terminal and navigate to the project folder.**


2. **Run the main class:**
   ```bash
   dotnet run

## OUTPUT:
![image](https://github.com/user-attachments/assets/0f351ed8-05c0-427d-9f28-9a2fad2a9488)
![image](https://github.com/user-attachments/assets/d0d08033-4833-4f98-94ff-81a090e59d5c)



