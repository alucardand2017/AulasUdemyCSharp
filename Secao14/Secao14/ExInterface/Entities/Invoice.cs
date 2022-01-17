using System;
using System.Globalization;
using ExInterface.Entities;
using ExInterface.Services;

namespace ExInterface.Entities
{
    class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }
        public double TotalPayment 
        {
            get {return BasicPayment + Tax;} 
        }
        public Invoice()
        {
        }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }
        
        public override string ToString()
        {
            return 
                "\nBasic payment: "
                + BasicPayment.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTax: "
                + Tax.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTotal payment: "
                + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    
    }
}
