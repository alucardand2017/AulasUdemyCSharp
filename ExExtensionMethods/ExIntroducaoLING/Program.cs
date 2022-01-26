using System;
using System.Linq;

namespace ExIntroducaoLING
{
    class Program
    {
        static void Main(string[] args)
        {
            //specify the data sourve
            int[] numbers = new int[] { 2, 3, 4, 5 };
            //define the query expression
            var result = numbers.Where(x => x % 2 == 0).Select(x => x * 10).Select(x => x * 10);
            //execute que query
            foreach (int x in result)
                Console.WriteLine(x);
        }
    }
}
