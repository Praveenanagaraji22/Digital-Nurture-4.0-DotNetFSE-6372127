#  Exercise 7: Financial Forecasting using Recursion

##  Aim
To develop a financial forecasting tool in C# that predicts future value using a recursive growth model based on past data.

---

##  Understanding Recursive Algorithms

###  What is Recursion?
Recursion is a method where a function calls itself to solve a smaller instance of the same problem. It's useful for breaking down problems into simpler subproblems.

###  Why Use It in Financial Forecasting?
- Models time-based problems naturally
- Each year’s value depends on the previous year’s result
- Clean and readable for growth-based computations

---

## Project Structure

- **Program.cs** – Contains:
  - `PredictFutureValue()` method (recursive)
  - Hardcoded sample input values (PV, rate, years)
  - Display of all inputs and predicted future value

---

## Formula Used

```text
FutureValue = PresentValue × (1 + rate) ^ years

```
## HOW TO RUN:

1. Open terminal in the project directory.
  


2. Run main code:
   ```bash
   dotnet run

## OUTPUT:


![image](https://github.com/user-attachments/assets/5bae51dc-2039-4356-8146-fec6022c478c)
![image](https://github.com/user-attachments/assets/2dff3978-123c-461c-b4a3-668240603c32)

