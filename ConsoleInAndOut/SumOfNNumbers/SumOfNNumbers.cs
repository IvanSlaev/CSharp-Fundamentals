using System;

namespace SumOfNNumbers
{
    class SumOfNNumbers
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double sum = 0;
            for (var i = 1; i <= N; i++)
                sum += double.Parse(Console.ReadLine());
            Console.WriteLine(sum);
        }
    }
}
