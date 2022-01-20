using System;


namespace ExInterfaceDiamante.Entities
{
    class ComboDevice : Device, IScanner, IPrinter
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Combo device processing " + document);
        }
        public void Print(string document)
        {
            Console.WriteLine("combo device print " + document);
        }
        public string Scan()
        {
            return "combo device Scan Result";
        }
    }
}
