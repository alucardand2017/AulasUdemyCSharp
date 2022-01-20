using System;
using ExGenericsERestricoes.Entities;
using ExGenericsERestricoes.Services;
using System.Globalization;
using System.Collections.Generic;
namespace ExGenericsERestricoes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Product> products = new List<Product>();
                Console.Write("Enter N:");
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    string[] vect = Console.ReadLine().Split(',');
                    products.Add(new Product(vect[0], double.Parse(vect[1], CultureInfo.InvariantCulture)));
                }
                CalculationService calculation = new CalculationService();
                Product max = calculation.Max(products);
                Console.Write("Max: ");
                Console.WriteLine(max);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Erro computado:" + e.Message); ;
            }
        }
    }
}
