using System;
using ExHeranca.Entities;

namespace ExHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(81810, "Maria Catarina", 500.00);
            BusinessAccount business = new BusinessAccount(18180, "JBS friboy e frigirl", 500.00, 1000.00);
            SavingsAccount savingsAccount = new SavingsAccount(18180, "Anderson", 500.00, 0.10);
            
            Console.WriteLine("Account data: number: ");
            Console.WriteLine(account.Number + " Holder: " + account.Holder + " Balance: " + account.Balance);
            Console.WriteLine("Business data: number: ");
            Console.WriteLine(business.Number +" Holder: "+business.Holder + " Balance: "+business.Balance + " Load Limit: " + business.LoadLimit);
            Console.WriteLine("Account data: number: ");
            Console.WriteLine(savingsAccount.Number + " Holder: " + savingsAccount.Holder + " Balance: " + savingsAccount.Balance + " Taxes: " + savingsAccount.InterestRate);

            account.Deposit(500.00); //deposito
            account.WithDraw(350.00); //saque
            
            savingsAccount.Deposit(500.00); //deposito
            savingsAccount.WithDraw(350.00); //saque
            savingsAccount.UpdateBalance(); //atualização com juros

            business.Deposit(500.00);
            business.WithDraw(350.00);
            business.Loan(4500.00); //emprestimo

            Console.WriteLine("Account data: number: ");
            Console.WriteLine(account.Number + " Holder: " + account.Holder + " Balance: " + account.Balance);
            Console.WriteLine("Business data: number: ");
            Console.WriteLine(business.Number + " Holder: " + business.Holder + " Balance: " + business.Balance + " Load Limit: " + business.LoadLimit);
            Console.WriteLine("Account data: number: ");
            Console.WriteLine(savingsAccount.Number + " Holder: " + savingsAccount.Holder + " Balance: " + savingsAccount.Balance + " Taxes: " + savingsAccount.InterestRate);

        }
    }
}
