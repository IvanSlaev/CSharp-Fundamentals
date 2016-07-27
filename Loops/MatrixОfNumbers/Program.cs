using System;

namespace MatrixОfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for (var i = 1; i <= N; i++)
            {
                for (var j = i; j <= i + N - 1; j++)
                    Console.Write("{0} ", j);
                Console.WriteLine();
            }
        }
    }
}
