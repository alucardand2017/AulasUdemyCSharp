using System;
using System.Collections.Generic;

namespace ExGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many values? ");
            int nValue = int.Parse(Console.ReadLine());
            
            PrintService<string> print = new PrintService<string>();
            for(int i = 0; i < nValue; i++)
            {
                print.AddValue(Console.ReadLine());
            }

            print.Print();
            Console.Write("First: ");
            Console.WriteLine(print.First());
        }
    }
}
