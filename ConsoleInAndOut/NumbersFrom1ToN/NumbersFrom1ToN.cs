using System;

namespace NumbersFrom1ToN
{
    class NumbersFrom1ToN
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (var i = 1; i <= number; i++)
                Console.WriteLine(i);
        }
    }
}