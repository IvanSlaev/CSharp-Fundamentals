using System;

namespace PointInCircle
{
    class PointInCircle
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double r = 2;
            double R = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            double eps = R - r;
            if (R < r || Math.Abs(eps) < 0.01)
                Console.WriteLine("yes {0}", R.ToString("0.00"));
            else
                Console.WriteLine("no {0}", R.ToString("0.00"));
        }
    }
}
