using System;
using System.Globalization;

namespace Secao4
{
    public static class ColetaDatos
    {
        public static void InsercaoDados( Funcionario funcionario)
        {
            Console.WriteLine("Dados do funcionário: ");
            Console.WriteLine("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.WriteLine("Salário: ");
            funcionario.Salario = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }
    }
}
