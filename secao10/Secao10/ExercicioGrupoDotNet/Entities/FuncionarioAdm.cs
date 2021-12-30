using System.Globalization;

namespace ExercicioGrupoDotNet.Entities
{
    class FuncionarioAdm : Funcionario
    {
        public double HoraExtra75 { get; set; }

        public FuncionarioAdm(int numRegistro, string nome, double salarioClt, double horasAcumuladas, double horaExtra75) : base(numRegistro, nome, salarioClt, horasAcumuladas)
        {
            HoraExtra75 = horaExtra75;
        }
        public override double CalcularSalarioBruto()
        {
            return SalarioClt + (1 + HoraExtra75/100.00) * HorasAcumuladas * CalcularValorDaHora();
        }
        public override string ToString()
        {
            return base.ToString() +
                "\nValor da HE = " +
                HoraExtra75.ToString("F2", CultureInfo.InvariantCulture) +
                "\n";
        }
    }
}
