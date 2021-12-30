using System;
using System.Collections.Generic;
using System.Text;

namespace ExerccioEmployee.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }
        public Employee()
        {
        }
        public Employee(string name, int hours, double valuePayment)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePayment;
        }
        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }
    }
}
