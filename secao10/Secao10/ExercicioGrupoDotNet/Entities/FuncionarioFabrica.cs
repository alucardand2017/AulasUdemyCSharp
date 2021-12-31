using System.Globalization;

namespace ExercicioGrupoDotNet.Entities
{
    class FuncionarioFabrica : Funcionario
    {
        public double HoraExtra60 { get; set; }
        public double AddNoturno { get; set; }
        public FuncionarioFabrica(int numRegistro, string nome, double salarioClt, double horasAcumuladas, double horaExtra60, double addNoturno) : base(numRegistro, nome, salarioClt, horasAcumuladas)
        {
            HoraExtra60 = horaExtra60;
            AddNoturno = addNoturno;
        }
        public override double CalcularSalarioBruto()
        {
            return (SalarioClt * (1 + AddNoturno / 100)) + (1 + HoraExtra60 / 100.00) * HorasAcumuladas * CalcularValorDaHora();
        }
        public override string ToString()
        {
            return base.ToString() +
                "\nPercentual da HE = " +
                HoraExtra60.ToString("F2", CultureInfo.InvariantCulture) +
                "\nPercentual do Adic. Noturno = " +
                AddNoturno.ToString("F2", CultureInfo.InvariantCulture) +
                "\n";
        }
    }
}
