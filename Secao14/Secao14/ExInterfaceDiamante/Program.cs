using System;
using ExInterfaceDiamante.Entities;

namespace ExInterfaceDiamante
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer() { SerialNumber = "0001" };
            p.ProcessDoc("My letter");
            p.Print("My letter");

            Scanner s = new Scanner() { SerialNumber = "0001" };
            s.ProcessDoc("My Email");
            Console.WriteLine(s.Scan());

            ComboDevice c = new ComboDevice() { SerialNumber = "00232" };
            c.ProcessDoc("My dissertation scan");
            c.Print("My dissertation print");
            Console.WriteLine(c.Scan());
        }
    }
}