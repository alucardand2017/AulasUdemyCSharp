using System;
using System.Globalization;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a quantidade de dados que deseja descobrir a média");
            int n = int.Parse(Console.ReadLine());
            double[] vetor = new double[n];

            for(int i = 0; i < n; i ++ )
            {
                Console.WriteLine("Entre com o valor {0}", i);
                vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            double soma = 0;
            for (int i = 0; i < n; i++)
            {
                soma += vetor[i];
            }
            double media = soma / n;
            Console.WriteLine("Média: {0}", media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
