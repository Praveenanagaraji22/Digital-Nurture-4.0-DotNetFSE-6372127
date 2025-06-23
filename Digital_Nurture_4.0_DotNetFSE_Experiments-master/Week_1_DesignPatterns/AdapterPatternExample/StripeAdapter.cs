public class StripeAdapter : IPaymentProcessor
{
    private StripeGateway _stripe;

    public StripeAdapter(StripeGateway stripe)
    {
        _stripe = stripe;
    }

    public void ProcessPayment(double amount)
    {
        _stripe.ExecutePayment(amount);
    }
}
