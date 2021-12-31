using System;
using System.Collections.Generic;
using ExercicioFinalFixacao.Entities;
using System.Globalization;

namespace ExercicioFinalFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Payer> payer = new List<Payer>();

            Console.Write("Enter the number of payers: ");
            int numberPayers = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberPayers; i++)
            {
                Console.WriteLine($"Tax payer #{i + 1} data:");
                Console.Write("Individual or company (i/c)? ");
                char typePayer = char.Parse(Console.ReadLine().ToLower());
                Console.Write("Name: ");
                string nameTemp = Console.ReadLine();
                Console.Write("Anual Income: ");
                
                double anualIncomeTemp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Value per hour: ");
                if (typePayer == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpendituresTemp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    payer.Add(new Person(nameTemp, anualIncomeTemp, healthExpendituresTemp));
                }
                else
                {
                    Console.Write("Number of Employees: ");
                    int numberOfEmployeesTemp = int.Parse(Console.ReadLine());
                    payer.Add(new Juridic(nameTemp, anualIncomeTemp, numberOfEmployeesTemp));
                }
            }
            Console.WriteLine("TAXES PAID:");
            foreach (Payer e in payer)
            {
                Console.WriteLine(e.Name + " - $ " + e.Taxes().ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.WriteLine("ALL TAXES:");
            double sum = 0;
            foreach (Payer e in payer)
            {
                sum += e.Taxes();
            }
            Console.WriteLine(sum.ToString("F2", CultureInfo.InvariantCulture)); 
        }
    }
}
