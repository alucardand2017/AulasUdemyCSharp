using System;
using System.Globalization;
namespace VetoresProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de produtos:");
            int n = int.Parse(Console.ReadLine());
            Produto[] vect = new Produto[n];
            double soma = 0;
            for (int i=0; i<n;i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Produto { Nome = name, Price = price };
                soma += vect[i].Price;
            }
            Console.WriteLine("Preço médio: " + soma/n);
        }
    }
}
