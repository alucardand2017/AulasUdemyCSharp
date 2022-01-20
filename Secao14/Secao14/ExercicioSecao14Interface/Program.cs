using System;
using ExercicioSecao14Interface.Exception;
using System.Globalization;
using ExercicioSecao14Interface.Entities;
using ExercicioSecao14Interface.Services;

namespace ExercicioSecao14Interface
{
    /// <summary>
    /// The program is an APP that apply a contract with installments. The application uses
    /// the a extern service (paypallservice) like as interface to to builder methodies and class.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter contract data");
                Console.Write("Number: ");
                ConsoleColor aux = Console.ForegroundColor;
                
                Console.ForegroundColor = ConsoleColor.Yellow;
                int number = int.Parse(Console.ReadLine());
                if (number <= 0)
                    throw new DomainException("Invalid contract number!");
                Console.ForegroundColor = aux;

                Console.Write("Date (dd/MM/yyyy): ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                if(start < DateTime.Now)
                    throw new DomainException("The start date can't be less than current date!");
                Console.ForegroundColor = aux;

                Console.Write("Contract value: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                double valueContract = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(valueContract < 0)
                    throw new DomainException("The contract value can't be a negative value!");
                Console.ForegroundColor = aux;
                //Instancia o contrato
                Contract contract = new Contract(number, start, valueContract);

                Console.Write("Enter number of installments: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                int installments = int.Parse(Console.ReadLine());
                if (installments <= 0)
                    throw new ServiceException("The installments number can´t be less than 1!");
                Console.ForegroundColor = aux;
                //Instancia o PayService iniciando o ITaxService com o Paypall
                Payservice pay = new Payservice(installments, new PayPallTaxService());
                pay.ProcessInstallments(contract);
                
                Console.WriteLine("Installments:");
                Console.ForegroundColor = ConsoleColor.Yellow;
                foreach (Installment i in contract.Installments)
                    Console.WriteLine(i);
                Console.ForegroundColor = aux;
            }
            catch (DomainException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
            }
            catch (ServiceException e)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(e.Message);
            }
            catch (SystemException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
            }
        }
    }
}
