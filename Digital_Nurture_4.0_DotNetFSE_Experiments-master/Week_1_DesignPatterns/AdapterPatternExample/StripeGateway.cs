public class StripeGateway
{
    public void ExecutePayment(double amount)
    {
        Console.WriteLine($"Paid ₹{amount} using Stripe.");
    }
}
