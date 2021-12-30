using System;
using System.Collections.Generic;
using System.Text;

namespace ExHeranca.Entities
{
    class BusinessAccount : Account
    {
        public double LoadLimit { get; set; }

        public BusinessAccount(int number, string holder, double balance, double loadLimit)
            : base(number,holder,balance)
        {
            LoadLimit = loadLimit;
        }

        public void Loan(double amount)
        {
            if(LoadLimit>amount)
            {
                LoadLimit -= amount;
                Balance += amount;
            }
            else
                Console.WriteLine(("Valor acima do Limite de Empréstimo!"));
        }
    }
}
