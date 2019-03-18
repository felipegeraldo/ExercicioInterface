using System;
using System.Collections.Generic;
using System.Text;
using Interface.Entities;

namespace Interface.Services
{
    class ContractService
    {
        IOnelinePaymentService _onelinePaymentService;

        public ContractService(IOnelinePaymentService onelinePaymentService)
        {
            _onelinePaymentService = onelinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            List<Installment> installments = new List<Installment>();

            for (int i = 1; i <= months; i++)
            {
                double amount = contract.TotalValue / months;

                amount = _onelinePaymentService.Interest(amount, i);
                amount = _onelinePaymentService.PaymentFee(amount);

                Installment installment = new Installment(contract.Date.AddMonths(i), amount);
                installments.Add(installment);
            }

            contract.SetInstallments(installments);
        }
    }
}
