using System;

namespace OddOrEven
{
    class OddOrEven
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double result = number % 2;
            if (result == 0)
                Console.WriteLine("even " + number);
            else
                Console.WriteLine("odd " + number);
        }
    }
}
