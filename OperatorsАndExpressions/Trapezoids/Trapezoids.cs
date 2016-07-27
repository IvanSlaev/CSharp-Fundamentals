using System;

namespace Trapezoids
{
    class Trapezoids
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = h * (a + b) / 2;
            Console.WriteLine(area.ToString("0.0000000"));
        }
    }
}
