using System;
using ExDelegatesActFuncPred.Services;


namespace ExDelegatesActFuncPred
{
    class Program
    {
        delegate void Multiop(double n1, double n2);
        delegate double BinaryOp(double n1, double n2);
        delegate double MonoOp(double n3);
        static void Main(string[] args)
        {
            double a = 10;
            double b = 20;
            BinaryOp op1 = new BinaryOp(CalculationService.Max);
            BinaryOp op2 = new BinaryOp(CalculationService.Sum);
            MonoOp op3 = new MonoOp(CalculationService.Square);

            Multiop op4 = CalculationService.ShowMax;
            op4 += CalculationService.ShowSum;


            Console.WriteLine(op1(a, b));
            Console.WriteLine(op2(a, b));
            Console.WriteLine(op3(a));
            
            op4.Invoke(a, b);
            op4(a, b);
        
        }
    }
}
