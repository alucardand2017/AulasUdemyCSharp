using System;
using System.IO;
using ExercicioSecao13.Entities;
using ExercicioSecao13.Exceptions;
namespace ExercicioSecao13
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\Temp\ItensVendidos.csv";
            string targetpath = @"c:\Temp\out\summary.csv";
            try
            {
                ControleDados.GerarRelatorio(path, targetpath);
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro nos arquivos ou pastas: " + e.Message);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Erro de dominio:" + e.Message);
            }
            catch(ArgumentException e)
            {
                Console.WriteLine("Erro de argumento:" + e.Message);
            }
        }

    }
}
