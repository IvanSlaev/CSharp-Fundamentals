using System;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            long number = 0;
            long[] numbers = new long[N];
            for (var i = 0; i < N; i++)
            {
                if (i < 2)
                    numbers[i] = i;
                else
                {
                    number = numbers[i - 1] + numbers[i - 2];
                    numbers[i] = number;
                }
            }
            for (var i = 0; i < N; i++)
            {
                if (i < N - 1)
                    Console.Write(numbers[i] + ", ");
                else
                    Console.WriteLine(numbers[i]);
            }
        }
    }
}
