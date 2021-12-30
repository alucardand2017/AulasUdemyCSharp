using System;
using ExEnumeradores.Entities.Enums;
using ExEnumeradores.Entities;
using System.Globalization;

namespace ExEnumeradores
{
    class Program
    {
        static void Main(string[] args)
        {

            Department dept = new Department();
            string nameTemp;
            WorkerLevel levelTemp = new WorkerLevel();
            double baseSalaryTemp;

            Console.Write("Enter department's name: ");
            dept.NameDepartment = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            nameTemp = Console.ReadLine();
            Console.Write("Level (Junior/Pleno/Senior): ");
            levelTemp = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            baseSalaryTemp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Name: ");

            Worker funcionario1 = new Worker(nameTemp, levelTemp, baseSalaryTemp, dept);

            Console.Write("How many contracts to this worker? ");
            int numberContracts = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberContracts; i++)
            {
                Console.WriteLine("Enter #{0} contract data:", i);
                Console.Write("Date (dd/MM/YYYY): ");
                DateTime dateTemp = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHourTemp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int durationTemp = int.Parse(Console.ReadLine());
                HourContract contracts = new HourContract(dateTemp, valuePerHourTemp, durationTemp); ;
                funcionario1.AddContract(contracts);
            }
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string mesAno = Console.ReadLine();
            int mes = int.Parse(mesAno.Substring(0,2));
            int ano = int.Parse(mesAno.Substring(3));
            Console.WriteLine("Name: {0}", funcionario1.Name);
            Console.WriteLine("Department: {0}", funcionario1.Department.NameDepartment);
            Console.WriteLine("Income for {0}:  {1}", mesAno, funcionario1.Income(ano, mes).ToString("F2", CultureInfo.InvariantCulture ));
        }
    }
}
