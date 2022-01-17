using System;
using System.Globalization;
using ExExceptions.Entities;
using ExExceptions.Entities.Exceptions;
namespace ExExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data:", Console.ForegroundColor = ConsoleColor.Green);
                Console.Write("Number: ");
                Console.ForegroundColor = ConsoleColor.Red;
                int numberTemp = int.Parse(Console.ReadLine());
                Console.Write("Holder: ", Console.ForegroundColor = ConsoleColor.Green);
                Console.ForegroundColor = ConsoleColor.Red;
                string nameTemp = Console.ReadLine();
                Console.Write("Inicial Balance: ", Console.ForegroundColor = ConsoleColor.Green);
                Console.ForegroundColor = ConsoleColor.Red;
                double balanceTemp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ", Console.ForegroundColor = ConsoleColor.Green);
                Console.ForegroundColor = ConsoleColor.Red;
                double withdrawLimitTemp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Account conta = new Account(numberTemp, nameTemp, balanceTemp, withdrawLimitTemp);
                Console.Write("Enter amount for withdraw: ", Console.ForegroundColor = ConsoleColor.Green);
                Console.ForegroundColor = ConsoleColor.Red;
                double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Withdraw(withdraw);
                Console.Write($"\nNew balance: {conta.Balance.ToString("F2", CultureInfo.InvariantCulture)}", Console.ForegroundColor = ConsoleColor.DarkYellow);
                Console.ResetColor();

            }
            catch (DomainException e)
            {
                Console.WriteLine("Erro! - " + e.Message, Console.ForegroundColor = ConsoleColor.Yellow, Console.BackgroundColor = ConsoleColor.DarkBlue);
                Console.ResetColor();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Campo digitado em branco" + e.Message, Console.ForegroundColor = ConsoleColor.Yellow, Console.BackgroundColor = ConsoleColor.DarkBlue);
                Console.ResetColor();

            }
            catch (Exception)
            {
                Console.WriteLine("Erro desconhecido - contactar Suporte técnico!", Console.ForegroundColor = ConsoleColor.Yellow, Console.BackgroundColor = ConsoleColor.DarkBlue);
                Console.ResetColor();

            }
        }
    }
}
