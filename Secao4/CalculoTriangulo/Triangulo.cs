using System;
using System.Collections.Generic;
using System.Text;

namespace CalculoTriangulo
{
    public class Triangulo
    {
        private double a;
        private double b;
        private double c;

        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }
        public double C { get => c; set => c = value; }

        public double CalcularArea()
        {
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return area;
        }
    }
}
