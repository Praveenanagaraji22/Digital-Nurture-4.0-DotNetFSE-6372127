
class Program
{
    static void Main(string[] args)
    {
        IPaymentProcessor paypalProcessor = new PayPalAdapter(new PayPalGateway());
        paypalProcessor.ProcessPayment(250.0);
        IPaymentProcessor stripeProcessor = new StripeAdapter(new StripeGateway());
        stripeProcessor.ProcessPayment(500.0);
    }
}
