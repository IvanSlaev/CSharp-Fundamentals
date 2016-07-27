using System;

namespace Calculate
{
    class Calculate
    {
        public static int Factorial(int N)
        {
            int factorial = 1;
            for (int i = 1; i <= N; i++)
                factorial *= i;
            return factorial;
        }
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double S = 1;

            for (var i = 1; i <= N; i++)
            {
                S += (Factorial(i) / Math.Pow(x, i));
            }
            Console.WriteLine("{0:0.00000}", S);
        }
    }
}
