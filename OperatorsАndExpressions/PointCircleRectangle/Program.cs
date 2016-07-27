using System;

namespace PointCircleRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            double R = Math.Sqrt(Math.Pow(x - 1, 2) + Math.Pow(y - 1, 2));
            if (R <= 1.5)
                Console.Write("inside circle ");
            else
                Console.Write("outside circle ");
            if (x >= -1 && x <= 5 && y >= -1 && y <= 1)
                Console.WriteLine("inside rectangle ");
            else
                Console.WriteLine("outside rectangle ");
        }
    }
}
