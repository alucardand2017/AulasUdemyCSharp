
namespace ExercicioSecao14Interface.Services
{
    class PayPallTaxService : ITaxService
    {
        public double Tax(double amount, int parcela)
        {
            double SomaJs = amount + (amount * parcela * 0.01);
            double SomaTx = SomaJs + SomaJs * 0.02;
            return SomaTx;
        }
    }
}
