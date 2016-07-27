using System;
using System.Numerics;

namespace CatalanNumbers
{
    class CatalanNumbers
    {
        public static BigInteger Factorial(int n)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
                factorial *= i;
            return factorial;
        }
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            BigInteger number = Factorial(N) / (Factorial(K) * Factorial(N - K));
            Console.WriteLine(number);
        }
    }
}
