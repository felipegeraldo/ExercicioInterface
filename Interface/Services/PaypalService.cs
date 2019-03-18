using System;
using System.Collections.Generic;
using System.Text;

namespace Interface.Services
{
    class PaypalService : IOnelinePaymentService
    {
        public double PaymentFee(double amount)
        {
            return amount + amount * 0.02;
        }

        public double Interest(double amount, int months)
        {
            return amount + amount * 0.01 * months;
        }
    }
}
