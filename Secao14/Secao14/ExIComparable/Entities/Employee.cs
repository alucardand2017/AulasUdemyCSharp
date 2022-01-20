using System;
using System.Globalization;
using System.IO;

namespace ExIComparable.Entities
{
    class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee)
        {
            string[] vect = csvEmployee.Split(",");
            Name = vect[0];
            Salary = double.Parse(vect[1], CultureInfo.InvariantCulture);
        }
        public override string ToString()
        {
            return Name + "," + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }


        //INTERFACE ICOMPARABLE COM SEU METODO OBRIGATORIO
        public int CompareTo(object obj)
        {
            if (!(obj is Employee))
                throw new ArgumentException("não é um objeto Employee");
            Employee outra = obj as Employee;
            return Name.CompareTo(outra.Name);
        }
    }

    
}
