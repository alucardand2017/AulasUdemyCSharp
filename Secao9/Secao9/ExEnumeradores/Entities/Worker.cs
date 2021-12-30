using System.Collections.Generic;
using ExEnumeradores.Entities.Enums;

namespace ExEnumeradores.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Leve { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker(string name, WorkerLevel leve, double baseSalary, Department department)
        {
            Name = name;
            Leve = leve;
            BaseSalary = baseSalary;
            Department = department;
        }
        public void AddContract( HourContract contract )
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }
        public double Income( int year, int month)
        {
            double soma = BaseSalary;
            foreach(HourContract contract in Contracts)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    soma += contract.TotalValue();
                }
            }
            return soma;
        }
    }
}
