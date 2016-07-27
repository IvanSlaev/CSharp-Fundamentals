using System;
using System.Collections.Generic;

namespace BitSwap
{
    class BitSwap
    {
        static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            uint[] positionsP = new uint[k];
            uint[] positionsQ = new uint[k];
            uint[] digitsP = new uint[k];
            uint[] digitsQ = new uint[k];
            uint newNumber = number;
            uint one = 1;

            for (var i = 0; i < k; i++)
            {
                var P = p + i;
                positionsP[i] = number >> P;
                digitsP[i] = positionsP[i] & one;
            }
            for (var i = 0; i < k; i++)
            {
                var Q = q + i;
                positionsQ[i] = number >> Q;
                digitsQ[i] = positionsQ[i] & one;
            }
            for (var i = 0; i < k; i++)
            {
                int Q = q + i;
                if (digitsP[i] == 0)
                {
                    uint mask = ~(one << Q);
                    newNumber = mask & newNumber;
                }
                else
                {
                    uint mask = one << Q;
                    newNumber = mask | newNumber;
                }
            }
            for (var i = 0; i < k; i++)
            {
                int P = p + i;
                if (digitsQ[i] == 0)
                {
                    uint mask = ~(one << P);
                    newNumber = mask & newNumber;
                }
                else
                {
                    uint mask = one << P;
                    newNumber = mask | newNumber;
                }
            }
            Console.WriteLine(Convert.ToString(newNumber));
            Console.WriteLine(Convert.ToInt32(newNumber, 2));
        }
    }
}
