public class PayPalAdapter : IPaymentProcessor
{
    private PayPalGateway _payPal;

    public PayPalAdapter(PayPalGateway payPal)
    {
        _payPal = payPal;
    }

    public void ProcessPayment(double amount)
    {
        _payPal.MakePayment(amount);
    }
}
