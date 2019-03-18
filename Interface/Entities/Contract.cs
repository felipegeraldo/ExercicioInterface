using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Interface.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        private List<Installment> _installments;

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            _installments = null;
        }

        public List<Installment> GetInstallments()
        {
            return _installments;
        }

        public void SetInstallments(List<Installment> installments)
        {
            _installments = installments;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("Installments: ");
            foreach (Installment item in _installments)
            {
                stringBuilder.Append(item.DueDate.ToString("dd/MM/yyyy"));
                stringBuilder.Append(" - ");
                stringBuilder.AppendLine(item.Amount.ToString("F2", CultureInfo.InvariantCulture));
            }

            return stringBuilder.ToString();
        }
    }
}
