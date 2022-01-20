using System;
using System.Collections.Generic;
using ExercicioPropostoDictionary.Exceptions;
using ExercicioPropostoDictionary.Services;
namespace ExercicioPropostoDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Dictionary<string, int> keyValues = new Dictionary<string, int>();
                string path = @"c:\Temp\votacao.csv";
                Console.WriteLine("Enter file full path: " + path);
                ServiceTest.Contabilizacao(keyValues, path);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error! " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unknow Error! " + e.Message);

            }



        }
    }
}
