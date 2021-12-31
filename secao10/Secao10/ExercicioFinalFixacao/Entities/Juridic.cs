namespace ExercicioFinalFixacao.Entities
{
    class Juridic : Payer
    {
        public int NumberOfEmployees { get; set; }
        public Juridic(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }
        public override double Taxes()
        {
            double partialTaxes = 0;
            if (NumberOfEmployees > 10)
                partialTaxes = AnualIncome * 0.14;
            else
                partialTaxes = AnualIncome * 0.16;
            return partialTaxes;
        }
    }
}
