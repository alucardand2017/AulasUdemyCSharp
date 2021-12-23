using System;

namespace ModificadoresParametros
{
    class Program
    {
        /// <summary>
        /// Esse programa resolve o problema de realizar uma soma de uma quantidade de números que desconhecemos, usando vetores.
        /// Ainda podemos usar um modificador params para falar para o C# de forma resumida que tu colocou um vetor de numero indefinido
        /// de parametros para argumento da classe Calculator
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //double resultado = Calculator.Sum(new double[] {10 , 20, 30, 40, 50, 60, 70 , 80 }); //maneira mais verbosa, porém mais intuitiva
            double resultado = Calculator.Sum(10, 1, 1, 1);
            Console.WriteLine(resultado);
        }
    }
}
