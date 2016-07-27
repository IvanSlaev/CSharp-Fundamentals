using System;

namespace TrailingZeroInN
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int counter = 0;

            while (N != 0)
            {
                counter += N / 5;
                N /= 5;
            }
            Console.WriteLine(counter);  
        }
    }
}
