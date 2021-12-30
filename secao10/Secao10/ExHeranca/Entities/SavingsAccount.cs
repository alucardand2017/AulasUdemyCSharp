using System;
using System.Collections.Generic;
using System.Text;


namespace ExHeranca.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount(int number, string holder, double balance, double interestate)
            : base(number, holder, balance)
        {
            InterestRate = interestate;
        }

        public void UpdateBalance()
        {
            Balance *= (1 + InterestRate);
        }
        public override void WithDraw(double amount) //sobreescrita na superclasse
        {
            base.WithDraw(amount); //executa o que está no construtor da superclasse.
            Balance -= amount + 3.0;
        }
    }
}
