using System;
using System.Globalization;

namespace CotacaoDolar
{
    public class Program
    {
        static void Main(string[] args)
        {
            double resultado = InformacoesDaCompra.Info();
            Console.WriteLine("O valor pago em reais será = {0}", resultado.ToString("N2"));
        }
    }
}
