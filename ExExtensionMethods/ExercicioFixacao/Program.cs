using System;
using System.IO;
using System.Linq;
using System.Globalization;
using ExercicioFixacao.Entities;
using System.Collections.Generic;

namespace ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter full file path: ");
            string path = @"C:\Temp\employees.txt";
            List<Employee> employees = new List<Employee>();
            using(StreamReader sr = File.OpenText(path))
                while(!sr.EndOfStream)
                {
                    string[] ep = sr.ReadLine().Split(",");
                    employees.Add(new Employee(ep[0], ep[1], double.Parse(ep[2], CultureInfo.InvariantCulture)));
                }
            foreach ( Employee e in employees)
                Console.WriteLine(e);
            Console.WriteLine();
            Console.Write("Enter salary: ");
            double target = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Email of people whose salary is more than {0}",target.ToString("F2", CultureInfo.InvariantCulture));
            var r1 = employees.Where(p => p.Salary > target).OrderBy(p => p.Name).Select(p => p.Email);
            foreach(var e in r1)
                Console.WriteLine(e.ToString());
            var r2 = employees.Where(p => p.Name[0] == 'M').Select(p => p.Salary).Sum();
            Console.Write("Sum of salary of people whose name starts with \'M\': " + r2.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
