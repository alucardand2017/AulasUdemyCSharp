using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ContaBancaria
{
    class ContaBancaria
    {
        private string _titular;
        private int _conta;
        private double _saldo;
        private double txSaque = 5.00;
        public string Titular { get => _titular; set => _titular = value; }
        public int Conta { get => _conta; set => _conta = value; }
        public double Saldo { get => _saldo; }
        public ContaBancaria()
        {

        }
        public ContaBancaria(int conta, string titular)
        {
            _conta = conta;
            _titular = titular;
        }
        public ContaBancaria(int conta, string titular, double depositoInicial) : this(conta, titular)
        {
            Depositar(depositoInicial);
        }
        public void Depositar(double valor)
        {
            if (valor <= 0)
                Console.WriteLine("Valor não permitido!");
            else
                _saldo += valor;
        }
        public void Sacar(double valor)
        {
            if (valor <= 0 || (valor + txSaque) > _saldo)
                Console.WriteLine("Valor não permitido");
            else
                _saldo -= (valor + txSaque);
        }
        public override string ToString()
        {
            return 
                "Conta: " 
                +Conta 
                +", Titula: " 
                + Titular 
                + " Saldo: " 
                +Saldo.ToString("N2", CultureInfo.InvariantCulture);
        }
    }
}
