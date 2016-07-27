using System;

namespace Circle
{
    class Circle
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            double perimeter = 2 * Math.PI * r;
            double area = Math.PI * Math.Pow(r, 2);
            Console.WriteLine("{0:0.00} {1:0.00}", perimeter, area);
        }
    }
}
