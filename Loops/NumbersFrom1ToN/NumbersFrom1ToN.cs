using System;

namespace NumbersFrom1ToN
{
    class NumbersFrom1ToN
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            for (long i = 1; i <= N; i++)
                if (i < N)
                    Console.Write("{0} ", i);
                else
                    Console.WriteLine(N);
        }
    }
}
