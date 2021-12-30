using System;
using System.Collections.Generic;
using ExerccioEmployee.Entities;
using System.Globalization;
namespace ExerccioEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> allEmployees = new List<Employee>();
           
            Console.Write("Enter the number of employees: ");
            int numberEmployee = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberEmployee; i++)
            {
                Console.WriteLine($"Employees #{i + 1} data:");
                Console.Write("Outsorced (y/n)? ");
                char outSource = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string nameTemp = Console.ReadLine();
                Console.Write("Hour: ");
                int hourTemp = int.Parse(Console.ReadLine());          
                Console.Write("Value per hour: ");
                double valuePerHourTemp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(outSource=='y')
                {
                    Console.Write("Additional charge: ");
                    double additionalChargeTemp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    
                    //allEmployees.Add(new OutsourceEmloyee(nameTemp, hourTemp, valuePerHourTemp, additionalChargeTemp));
                    OutsourceEmloyee outTemp = new OutsourceEmloyee(nameTemp, hourTemp, valuePerHourTemp, additionalChargeTemp);
                    allEmployees.Add(outTemp);
                }
                else
                {
                    Employee outTemp = new Employee(nameTemp, hourTemp, valuePerHourTemp);
                    allEmployees.Add(outTemp);
                }

            }

            Console.WriteLine("PAYMENTS:");
            foreach(Employee e in allEmployees)
            {
                Console.WriteLine(e.Name + " - $ " + e.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
