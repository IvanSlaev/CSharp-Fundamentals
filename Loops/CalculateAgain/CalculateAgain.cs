using System;
using System.Numerics;

namespace CalculateAgain
{
    class CalculateAgain
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            BigInteger facN = 1;
            BigInteger facK = 1;
            
            for (var i = 1; i <= N; i++)
            {
                    facN *= i;
                if (i <= K)
                    facK *= i;
            }
            BigInteger result = facN / facK;
            Console.WriteLine(result);

        }
    }
}
