using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioProposto.Exceptions;
namespace ExercicioProposto.Entities
{
    class Users : IComparable
    {
        public string Name { get; set; }
        public int RegistrationNumber { get; set; }

        public Users(string name, int registrationNumber)
        {
            Name = name;
            RegistrationNumber = registrationNumber;
        }

        public override int GetHashCode()
        {
            return RegistrationNumber.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Users))
                throw new DomainException("Error! The Objetc is not a User! Call the Manager.");
            Users other = obj as Users;
            return RegistrationNumber.Equals(other.RegistrationNumber);
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
