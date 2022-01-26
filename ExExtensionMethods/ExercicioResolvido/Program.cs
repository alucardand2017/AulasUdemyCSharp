using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using ExercicioResolvido.Entities;
namespace ExercicioResolvido
{
    class Program
    {
        static void Print<T>(IEnumerable<T> collection)
        {
            foreach( T pd in collection)
            {
                Console.WriteLine(pd);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            string path = @"c:\Temp\Arquivo1.csv";
            List<Product> products = new List<Product>();
            using (StreamReader sr = File.OpenText(path))
            {
                while(!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(",");
                    products.Add(new Product(line[0], double.Parse(line[1],CultureInfo.InvariantCulture)));
                }
            }
            var r1 = products.Select(p=> p.Price);
            double medium = r1.DefaultIfEmpty(0.0).Average(); // coloca o default como caso não tenha nenhum produto.
            Console.WriteLine("Average: " + medium.ToString("F2")); 
            Console.WriteLine();
            var r2 = products.Where(p => p.Price < medium).OrderByDescending(p => p.Name).Select(p=> p.Name);
            Print(r2);
        }
    }
}
