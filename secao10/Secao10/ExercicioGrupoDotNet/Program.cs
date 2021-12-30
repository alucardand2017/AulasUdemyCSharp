using System;
using System.Collections.Generic;
using ExercicioGrupoDotNet.Entities;

namespace ExercicioGrupoDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            funcionarios.Add(new FuncionarioAdm(123456, "Claudia", 1200.00, 20.00, 75.00));
            funcionarios.Add(new FuncionarioFabrica(654321, "Claudio", 1200.00, 20.00, 60.00, 26.00));

            foreach( Funcionario p in funcionarios)
            {
                Console.WriteLine(p);
            }
        }
    }
}
