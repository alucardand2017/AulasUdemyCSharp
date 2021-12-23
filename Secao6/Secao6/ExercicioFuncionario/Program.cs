using System;
using System.Collections.Generic;
namespace ExercicioFuncionario
{
    /// <summary>
    /// Programa que monta uma lista de uma classe que instancia funcionarios. Insere-se os dados que serão mostrados por uma função, depois fazemos uma operação de
    /// aumento de salário, buscando pela Id o funcionario a ser aumentado na lista e utilizando um método da classe funcionarios para essa inserção.
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionarios> fichas = new List<Funcionarios>();       
            Funcionarios funcionarioTemp = new Funcionarios();
            Console.WriteLine("How many employees will be registered? ");
            int nFichas = int.Parse(Console.ReadLine());
            for (int i = 0; i < nFichas; i++)
            {
                Console.WriteLine("Emplyoee #{0}", i+1);
                Console.Write("Id: ");
                funcionarioTemp.Id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                funcionarioTemp.Nome = Console.ReadLine();
                Console.Write("Salary: ");
                funcionarioTemp.Salario = double.Parse(Console.ReadLine());
                fichas.Add(new Funcionarios(funcionarioTemp.Id, funcionarioTemp.Nome, funcionarioTemp.Salario));
            }
            MostraLista(fichas);
            Console.Write("Enter the employee id that will have salary increase: ");
            int idAux = int.Parse(Console.ReadLine());
            Console.Write("How mutch the increase's salary will be?");
            double aumentoAux = double.Parse(Console.ReadLine());

            int posicao = fichas.FindIndex(x => x.Id == idAux); // encontra a posição do objeto da lista que satisfaz a expressão lambida
            fichas[posicao].AumentoSalario(aumentoAux);         // aplica o método aumento de salario na posição encontrada.
            MostraLista(fichas);
        }
        static void MostraLista(List<Funcionarios> obj)
        {
            foreach(Funcionarios obj1 in obj)
            {
                Console.WriteLine(obj1);
            }
        }
    }
}

