using System;

namespace NthBit
{
    class NthBit
    {
        static void Main(string[] args)
        {
            long P = long.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            long mask = 1 << N;
            long andMaskP = mask & P;
            long result = andMaskP >> N;
            Console.WriteLine(result);
            Console.WriteLine(Convert.ToString(result, 2));
        }
    }
}
