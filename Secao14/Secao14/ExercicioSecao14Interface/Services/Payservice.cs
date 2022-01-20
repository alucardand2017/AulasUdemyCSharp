using System;
using ExercicioSecao14Interface.Entities;

namespace ExercicioSecao14Interface.Services
{
    class Payservice
    {
        public int Instalments { get; set; }
        private ITaxService _TaxService;
        public Payservice(int instalments, ITaxService taxService)
        {
            Instalments = instalments;
            _TaxService = taxService;
        }
        public void ProcessInstallments(Contract contract)
        {
            for (int i = 1; i <= Instalments; i++)
            {
                DateTime monthPayDate = contract.Date.AddMonths(i);
                double monthTaxPay = _TaxService.Tax((contract.TotalValue / Instalments), i);
                contract.Installments.Add(new Installment(monthPayDate, monthTaxPay));
            }
        }
    }
}
