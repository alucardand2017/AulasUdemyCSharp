using System;
using System.Collections.Generic;
using System.Text;
using ExExceptions.Entities.Exceptions;

namespace ExExceptions.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }
        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit( double amount)
        {
            if(amount<0)
            {
                throw new DomainException("Valor inválido para depósito");
            }
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            if(Balance<amount)
            {
                throw new DomainException("Saldo insuficiente para executar a operação!");
            }
            if(amount> WithdrawLimit)
            {
                throw new DomainException("Valor para saque maior que o Limite de operação!");
            }
            Balance -= amount;
        }
    }
}
