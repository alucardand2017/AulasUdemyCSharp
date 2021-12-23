using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CotacaoDolar
{
    class InformacoesDaCompra
    {
        public static double Info()
        {
            Console.WriteLine("Digite a cotação do dolar hoje: ");
            float cotDolar = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a quantidade de dolares que irá comprar: ");
            float qntDolar = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            return CalculoCompra.ComprarDolar(qntDolar, cotDolar);

        }
    }
}
