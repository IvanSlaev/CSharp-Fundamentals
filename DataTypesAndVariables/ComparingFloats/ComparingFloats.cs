using System;

namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double eps = a - b;
            string result = "false";
            if (Math.Abs(eps) < 0.000001)
                result = "true";
            Console.WriteLine(result);
        }
    }
}