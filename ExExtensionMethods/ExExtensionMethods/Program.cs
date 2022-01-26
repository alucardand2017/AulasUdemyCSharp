using System;
using ExExtensionMethods.Extension;


namespace ExExtensionMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2022, 01, 01, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}
