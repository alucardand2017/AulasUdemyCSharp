using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
namespace ExerccioEmployee.Entities
{
    class OutsourceEmloyee : Employee
    {
        public double AdditionalCharge { get; set; }
        public OutsourceEmloyee()
        {
        }
        public OutsourceEmloyee(string name, int hours, double valuePayment, double additionalCharge)
            : base (name, hours, valuePayment)
        {
            AdditionalCharge = additionalCharge;
        }
        public override double Payment()
        {
            return base.Payment() + (AdditionalCharge * 1.10);
        }
    }
}
