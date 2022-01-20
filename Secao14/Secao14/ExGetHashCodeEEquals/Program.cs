using System;
using ExGetHashCodeEEquals.Entities;

namespace ExGetHashCodeEEquals
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Client a = new Client("Maria", "maria@gmail.com");
                Client b = new Client("Maria", "maria@gmail.com");
                Console.WriteLine(a.Equals(b)); //compara conteúdo
                Console.WriteLine(a == b);      //compara ponteiros
                Console.WriteLine(a.GetHashCode());
                Console.WriteLine(b.GetHashCode());
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            
        }
    }
}
