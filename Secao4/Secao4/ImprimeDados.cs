using System;

namespace Secao4
{
    public static class ImprimeDados
    {
        public static void Imprimir(Funcionario funcionario)
        {
            Console.WriteLine("{0} ganha {1}", funcionario.Nome, funcionario.Salario);
        }
    }
}
