namespace Interface.Services
{
    interface IOnelinePaymentService
    {
        double PaymentFee(double amount);

        double Interest(double amouny, int months);
    }
}
