using System;

public class CreditCardPayment : IPaymentStrategy
{
    private string cardNumber;
    private string name;
    private string cvv;

    public CreditCardPayment(string cardNumber, string name, string cvv)
    {
        this.cardNumber = cardNumber;
        this.name = name;
        this.cvv = cvv;
    }

    public void Pay(double amount)
    {
        Console.WriteLine($"Paid ₹{amount} using Credit Card ({cardNumber})");
    }
}
