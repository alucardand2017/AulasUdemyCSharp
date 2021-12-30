using System.Globalization;

namespace ExercicioGrupoDotNet.Entities
{
    abstract class Funcionario
    {
        public int NumRegistro { get; set; }
        public string Nome { get; set; }
        public double SalarioClt { get; set; }
        public double HorasAcumuladas { get; set; }
        protected Funcionario()
        {
        }
        protected Funcionario(int numRegistro, string nome, double salarioClt, double horasAcumuladas)
        {
            NumRegistro = numRegistro;
            Nome = nome;
            SalarioClt = salarioClt;
            HorasAcumuladas = horasAcumuladas;
        }
        public virtual double CalcularSalarioBruto()
        {
            return SalarioClt + 1.50 * HorasAcumuladas * CalcularValorDaHora();
        }
        public double CalcularValorDaHora()
        {
            return SalarioClt / 180;
        }
        public virtual double CalcularImposto()
        {
            if (CalcularSalarioBruto() < 3300.00)
                return 0.09 * CalcularSalarioBruto();
            else
                return 0.12 * CalcularSalarioBruto();
        }
        public virtual double CalcularSalarioLiquido()
        {
            return CalcularSalarioBruto() - CalcularImposto();
        }

        public override string ToString()
        {
            return
                "Nome = " +
                Nome +
                "\nRegistro = " +
                NumRegistro +
                "\nSalario Clt = " +
                SalarioClt + 
                "\nHoras Acumuladas = " +
                HorasAcumuladas +
                "\nCálculo valor da hora = " + 
                CalcularValorDaHora().ToString("F2", CultureInfo.InvariantCulture) + 
                "\nSalario Bruto = " +
                CalcularSalarioBruto().ToString("F2", CultureInfo.InvariantCulture) +
                "\nSalario Liquido = " +
                CalcularSalarioLiquido().ToString("F2", CultureInfo.InvariantCulture) +
                "\nImposto Pago = " +
                CalcularImposto().ToString("F2", CultureInfo.InvariantCulture) + ", ";
        }
    }
}
