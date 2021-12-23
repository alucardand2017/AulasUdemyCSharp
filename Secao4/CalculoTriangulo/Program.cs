using System;
using System.Globalization;
namespace CalculoTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x = new Triangulo();
            Console.WriteLine("Entre com as medidas do triangulo x:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Triangulo y = new Triangulo();
            Console.WriteLine("Entre com as medidas do triangulo y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Area de X = {0}", x.CalcularArea().ToString("N2"));
            Console.WriteLine("Area de X = {0}", y.CalcularArea().ToString("N2"));
            Console.Write("Maior Área: ");
            if (x.CalcularArea() > y.CalcularArea())
                Console.Write("X");
            else
                Console.Write("Y");
        }
    }
}
