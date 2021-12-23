using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFuncionario
{
    class Funcionarios
    {
        private int _id;
        private string _nome;
        private double _salario;
        public Funcionarios()
            {
            }
        public Funcionarios(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }
        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public double Salario { get => _salario; internal set => _salario = value; }
        
        public void AumentoSalario(double tx)
        {
            Salario = (Salario*(100 + tx) / 100);
        }
        
        public override string ToString()
        {
            return
                Id + ", " +
                Nome + ", " +
                Salario + ".";
        }
    }
}
