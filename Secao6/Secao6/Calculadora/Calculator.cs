using System;
using System.Collections.Generic;
using System.Text;

namespace ModificadoresParametros
{
    class Calculator
    {
        //public static double Sum(double[] numeros) //maneira mais verbosa, mas a mais intuitiva
        public static double Sum(params double[] numeros)
        {
            double soma = 0;
            for(int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];  
            }
            return soma;
        }
    }
}
