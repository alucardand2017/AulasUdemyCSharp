using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<double> z = null; //declaração antiga de um Nullable.
            double? x = null;           //novo formato.
            double? y = 10;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            //Console.WriteLine(x.Value); dará erro porque não tem valor atribuido a variável x.
            Console.WriteLine(y.Value);

            double a = x ?? 5.0;        //operador que joga o valor de x em a, mas caso x seja null ele joga 5.0
            double b = y ?? 5.0;        // idem

            Console.WriteLine(x.Value);
            Console.WriteLine(y.Value);
        }
    }
}
