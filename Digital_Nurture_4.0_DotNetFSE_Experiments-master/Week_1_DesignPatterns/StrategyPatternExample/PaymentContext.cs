using System;

public class PaymentContext
{
    private IPaymentStrategy? paymentStrategy;

    public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
    {
        this.paymentStrategy = paymentStrategy;
    }

    public void ProcessPayment(double amount)
    {
        if (paymentStrategy == null)
        {
            Console.WriteLine("No payment strategy selected.");
        }
        else
        {
            paymentStrategy.Pay(amount);
        }
    }
}
