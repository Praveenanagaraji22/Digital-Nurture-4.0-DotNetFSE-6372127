using System;

class Program
{
    static void Main(string[] args)
    {
        PaymentContext context = new PaymentContext();

        context.SetPaymentStrategy(new CreditCardPayment("1234-5678-9876-5432", "Jeeva Priya", "789"));
        context.ProcessPayment(1500.00);

        context.SetPaymentStrategy(new PayPalPayment("jeeva@example.com", "securePass123"));
        context.ProcessPayment(999.99);
    }
}
