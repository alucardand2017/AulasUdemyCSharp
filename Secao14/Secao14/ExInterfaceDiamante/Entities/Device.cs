using System;


namespace ExInterfaceDiamante.Entities
{
    abstract class Device
    {
        public string SerialNumber { get; set; }
        public abstract void ProcessDoc(string document);
    }
}
