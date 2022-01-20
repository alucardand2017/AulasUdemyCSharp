using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExInterfaceDiamante.Entities
{
    class Printer : Device, IPrinter
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Printer processing " + document);
        }
        public void Print(string document)
        {
            Console.WriteLine("Print print" + document);
        }
    }
}
