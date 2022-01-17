
using System;
using System.Globalization;
using ExInterface.Entities;
using ExInterface.Services;

namespace ExInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string carModel = Console.ReadLine();
            Console.Write("Pickup (dd/MM/YYYY HH:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/YYYY HH:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture); Console.Write("Ender price per hour: ");

            CarRental carRental = new CarRental(start, finish, new Vehicle(carModel));

            double pricePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Ender price per day: ");
            double pricePerDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Rentalservice rentalservice = new Rentalservice(pricePerHour, pricePerDay, new BrazilTaxService());
            rentalservice.ProcessInvoice(carRental);
            Console.WriteLine("INVOICE: ");
            Console.WriteLine(carRental.Invoice);
            Console.ReadLine();

        }
    }
}
