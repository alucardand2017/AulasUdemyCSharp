using System;
using ExercicioProposto.Entities;
using ExercicioProposto.Exceptions;
using ExercicioProposto.Services;
using System.Collections.Generic;

namespace ExercicioProposto
{
    class Program
    {
        /// <summary>
        /// Programa que pega usuários de 3 cursos diferentes e contabiliza quantidadade de alunos segundo o numero de matricula pela sintaxe "name-registrationNumber".
        /// O cogido mostra a forma como conjuntos operam, não repetindo dados de um mesmo tipo, assim evitando duplicidades de informação.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            try
            {
                HashSet<Users> courseA = new HashSet<Users>();
                HashSet<Users> courseB = new HashSet<Users>();
                HashSet<Users> courseC = new HashSet<Users>();
                HashSet<Users> allcourses = new HashSet<Users>();
                Console.Write("How many students for course A: ");
                int numberA = int.Parse(Console.ReadLine());
                if(numberA <= 0)
                    throw new DomainException("Erro de argumento! Entrada Inválida!");
                for (int i = 0; i < numberA; i++)
                {
                    
                    string teste = Console.ReadLine();
                    TestIn.Validation(teste);
                    string[] s = teste.Split('-');
                    string name = s[0];
                    int number = int.Parse(s[1]);
                    courseA.Add(new Users(name, number));
                    allcourses.Add(new Users(name, number));
                }
                Console.Write("How many students for course B: ");
                int numberB = int.Parse(Console.ReadLine());
                if (numberB <= 0)
                    throw new DomainException("Erro de argumento! Entrada Inválida!");
                for (int i = 0; i < numberB; i++)
                {
                    string teste = Console.ReadLine();
                    TestIn.Validation(teste);
                    string[] s = teste.Split('-');
                    string name = s[0];
                    int number = int.Parse(s[1]);
                    courseB.Add(new Users(name, number));
                    allcourses.Add(new Users(name, number));
                }
                Console.Write("How many students for course C: ");
                int numberC = int.Parse(Console.ReadLine());
                if (numberC <= 0)
                    throw new DomainException("Erro de argumento! Entrada Inválida!");
                for (int i = 0; i < numberC; i++)
                {
                    string teste = Console.ReadLine();
                    TestIn.Validation(teste);
                    string[] s = teste.Split('-');
                    string name = s[0];
                    int number = int.Parse(s[1]);
                    courseC.Add(new Users(name, number));
                    allcourses.Add(new Users(name, number));
                }
                Console.WriteLine("Total users: " + allcourses.Count);
            }
            catch (DomainException e)
            {
                Console.WriteLine(e.Message); ;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message); ;
            }
        }
    }
}
