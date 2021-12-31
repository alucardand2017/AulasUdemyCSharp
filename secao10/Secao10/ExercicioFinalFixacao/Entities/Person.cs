namespace ExercicioFinalFixacao.Entities
{
    class Person : Payer
    {
        public double HealthExpenditures { get; set; }
        public Person(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Taxes()
        {
            double partialTaxes = 0;
            if (AnualIncome < 20000.00)
                partialTaxes = (AnualIncome * 0.15);
            else
                partialTaxes = AnualIncome * 0.25;
            return partialTaxes - (HealthExpenditures * 0.5);
        }
    }
}
