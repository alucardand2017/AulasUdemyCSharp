
using ExercicioSecao13.Exceptions;
namespace ExercicioSecao13.Entities
{
    class FichaProduto
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
        public int Qnt { get; set; }

        public FichaProduto()
        {
        }
        public FichaProduto(string nome, double valor, int qnt)
        {
            if (nome.Length < 5)
                throw new DomainException("Nome inválido! Deve ter pelo menos 5 caracteres");
            Nome = nome;
            if (!(valor is double))
                throw new DomainException("Valor incorreto");
            Valor = valor;
            if (!(qnt is int))
                throw new DomainException("Quantidade inválida");
            Qnt = qnt;
        }
        public double ValorBruto()
        {
            return (Valor * Qnt);
        }
    }
}
