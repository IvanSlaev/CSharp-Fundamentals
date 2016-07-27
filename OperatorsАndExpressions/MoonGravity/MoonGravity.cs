using System;

namespace MoonGravity
{
    class MoonGravity
    {
        static void Main(string[] args)
        {
            double W = double.Parse(Console.ReadLine());
            double weightOnTheMoon = W * 0.17;
            Console.WriteLine(weightOnTheMoon.ToString("0.000"));
        }
    }
}