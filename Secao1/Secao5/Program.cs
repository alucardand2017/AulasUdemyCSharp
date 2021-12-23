using System;
using System.Globalization;

namespace ContaBancaria

{
    class Program
    {
        static void Main(string[] args)
        {
            //Dados da Conta
            ContaBancaria conta1 = new ContaBancaria( 4545, "Anderson", 500.00);
            Console.Write("Entre com o numero da conta: ");
            conta1.Conta = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com o titular da conta: ");
            conta1.Titular = (Console.ReadLine());
            //Operacoes
            Console.Write("Harevá deposito inicial (s/n)? ");
            char escolha = char.Parse(Console.ReadLine());
            if (escolha == 's')
            {
                Console.Write("Entre com o valor de deposito inicial: ");
                conta1.Depositar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            }
            else
                conta1.Depositar(0);
            Console.WriteLine("Dados da conta: {0} \n", conta1);    
            Console.Write("Entre com o valor para deposito: ");
            conta1.Depositar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualiados:");
            Console.WriteLine("Dados da conta: {0} \n", conta1);
            Console.Write("Entre com o valor para saque: ");
            conta1.Sacar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualiados: ");
            Console.WriteLine("Dados da conta: {0} \n", conta1);
        }
    }
}
