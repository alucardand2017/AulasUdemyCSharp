using System;
using System.IO;
using System.Collections.Generic;
using ExIComparable.Entities;
namespace ExIComparable
{
    class Program
    {
        /// <summary>
        /// A interface IComparable é obrigatória nesse caso, já que o compilador não entende como realizar essa comparação (o que comparar?) 
        /// o IComparable retorna um número (1,0,-1) para cada resultado , ex:
        /// Console.WriteLine("Maria".CompareTo("Alex"));   ----> 1
        /// Console.WriteLine("Alex".CompareTo("Maria"));   ----> -1
        /// Console.WriteLine("Maria".CompareTo("Maria"));  ----> 0
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string path = @"c:\Temp\Comparable.csv";

            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while(!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach( Employee c in list)
                    {
                        Console.WriteLine(c);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
