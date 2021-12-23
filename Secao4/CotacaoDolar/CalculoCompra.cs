using System;
using System.Collections.Generic;
using System.Text;

namespace CotacaoDolar
{
    class CalculoCompra
    {
        private double txIOF = 0.06;
        public double TxIOF { get => txIOF; set => txIOF = value; }


        public static double ComprarDolar(double dolar, double qnt)
        {
            double total = dolar * qnt * 1.06f;
            return total;
        }
    }
    
}
