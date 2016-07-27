using System;

namespace NumberComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Max(firstNumber, secondNumber));
        }
    }
}
