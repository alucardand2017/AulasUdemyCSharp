using System;
using System.Collections.Generic;
using ExercicioGrupoDotNet.Entities;

namespace ExercicioGrupoDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            var funcionarios = new List<Funcionario>();
            funcionarios.Add(new FuncionarioAdm(123456, "Claudia", 1000.00, 10.00, 75.00));
            funcionarios.Add(new FuncionarioFabrica(654321, "Claudio", 1000.00, 10.00, 60.00, 30.00));
            foreach (var p in funcionarios)
            {
                Console.WriteLine(p);
            }
        }
    }
}
