using System;

public class PayPalPayment : IPaymentStrategy
{
    private string email;
    private string password;

    public PayPalPayment(string email, string password)
    {
        this.email = email;
        this.password = password;
    }

    public void Pay(double amount)
    {
        Console.WriteLine($"Paid ₹{amount} using PayPal ({email})");
    }
}
