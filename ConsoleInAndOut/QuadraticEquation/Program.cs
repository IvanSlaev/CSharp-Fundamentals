using System;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double D = Math.Pow(b, 2) - 4 * a * c;
            if (D > 0)
            {
                double x1 = ((-b + Math.Sqrt(D)) / (2 * a));
                double x2 = ((-b - Math.Sqrt(D)) / (2 * a));
                Console.WriteLine("{0:0.00}", Math.Min(x1, x2));
                Console.WriteLine("{0:0.00}", Math.Max(x1, x2));
            }
            else if (D == 0)
                Console.WriteLine("{0:0.00}", -b / (2 * a));
            else
                Console.WriteLine("no real roots");
        }
    }
}