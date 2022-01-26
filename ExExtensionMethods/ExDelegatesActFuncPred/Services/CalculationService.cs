namespace ExDelegatesActFuncPred.Services
{
    class CalculationService
    {
        public static double Max(double x, double y)
        {
            if (x > y)
                return x;
            else
                return y;
        }
        public static double Sum(double x, double y)
        {
            return x + y;
        }
        public static double Square(double x)
        {
            return x * x;
        }
        public static void ShowMax(double x, double y)
        {
            if (x > y)
                System.Console.WriteLine(x);
            else
                System.Console.WriteLine(y);
        }
        public static void ShowSum(double x, double y)
        {
            System.Console.WriteLine((x+y).ToString("F2"));
        }
    }
}
