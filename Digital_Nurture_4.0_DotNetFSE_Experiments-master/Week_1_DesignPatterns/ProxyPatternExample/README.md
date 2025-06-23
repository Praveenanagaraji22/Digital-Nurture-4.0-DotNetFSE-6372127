# Proxy Pattern Example

## Aim
To implement the Proxy Design Pattern in Java by developing an image viewer application that loads images from a remote server. The Proxy Pattern is used to add **lazy initialization** and **caching** to optimize performance and resource usage.

## Objective
- To understand and apply the Proxy Design Pattern.
- To provide a surrogate object (proxy) to control access to a real object.
- To implement lazy loading of large or expensive-to-create objects.
- To reduce system resource usage with caching mechanisms.

## Definition of Proxy Pattern
The Proxy Pattern is a **structural design pattern** that provides a placeholder or surrogate for another object to control access to it. It is commonly used to:
- Delay the creation and initialization of resource-heavy objects (lazy initialization),
- Provide access control or protection,
- Implement caching,
- Support remote access.

---

## Project Structure

- `Image` (Interface): Declares the `display()` method.
- `RealImage` (Real Subject Class): Loads and displays the image from a remote server.
- `ProxyImage` (Proxy Class): Implements lazy loading and caching by deferring the loading of `RealImage` until needed.
- `Main` (Client Class): Demonstrates the use of `ProxyImage` to load and display images.

---

## How to Run

1. **Open your terminal and navigate to the project folder.**


2. **Run main class**
   ```bash
   dotnet run

## OUTPUT:
![image](https://github.com/user-attachments/assets/520e911c-9ed7-4e6d-a7e8-a2d245d837e9)
![image](https://github.com/user-attachments/assets/aa357d7e-31de-484e-b815-13502515e2fc)




 
