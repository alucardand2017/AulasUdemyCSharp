using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExGenericsERestricoes.Entities
{
    class Product : IComparable
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public Product(string name, double value)
        {
            Name = name;
            Value = value;
        }
        //funcao obrigatória da interface IComparable
        public int CompareTo(object obj)
        {
            if (!(obj is Product)) // testa se é o produto que desejamos, se não retorna uma exceção.
                throw new ArgumentException("Argument isn't a Product");
            Product other = obj as Product; //cria uma variavel do objeto da classe e a iguala a variável que chegou na função (funciona por meio de downcasting, já que todas as classes tem como superclasse Object
            return Value.CompareTo(other.Value); //compara os valores do campo Value do Produto que estamos
        }
        public override string ToString()
        {
            return Name + "," + Value.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
