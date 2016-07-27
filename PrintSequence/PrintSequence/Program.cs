using System;

namespace PrintSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 2;
            for (var i = 0; i < 1000; i++)
            {
                Console.WriteLine(number);
                if (number > 0)
                    number++;
                else
                    number--;
                number *= -1;
            }
        }
    }
}
