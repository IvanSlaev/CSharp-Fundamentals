using System;

namespace Interval
{
    class Interval
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            long M = long.Parse(Console.ReadLine());
            int counter = 0;
            for (var i = Math.Min(N, M) + 1; i < Math.Max(N, M); i++)
                if (i % 5 == 0)
                    counter++;
            Console.WriteLine(counter);
        }
    }
}
