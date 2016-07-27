using System;
using System.Numerics;

namespace CatalanNumbers
{
    class CatalanNumbers
    {
        public static BigInteger Factorial(int N)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= N; i++)
                factorial *= i;
            return factorial;
        }
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            BigInteger catalanNumber = Factorial(2 * N) / (Factorial(N + 1) * Factorial(N));
            Console.WriteLine(catalanNumber);
        }
    }
}
