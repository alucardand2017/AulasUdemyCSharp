using System;

namespace Secao4
{
    public static class Media
    {
        public static void MediaSalario( Funcionario m1, Funcionario m2)
        {
            float media = (m1.Salario + m2.Salario) / 2;
            Console.WriteLine("média salarial = {0}", media);
        }
    }
}
