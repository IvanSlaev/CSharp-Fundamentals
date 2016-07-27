using System;

namespace MatrixОfNumbers
{
    class MatrixOfNumbersWithOneLoop
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = N;
            int i = 1;
            int j = 1;
            while (true)
            {
                if (i <= M)
                {
                    Console.Write("{0} ", i);
                    i++;
                    continue;
                }
                else
                {
                    i = i - M + j;
                    M++;
                    j++;
                    Console.WriteLine();
                }
                if (i > N)
                    break;
            }
        }
    }
}
