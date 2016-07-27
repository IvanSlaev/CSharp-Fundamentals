using System;

namespace SumOf5Numbers
{
    class SumOf5Numbers
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (var i = 0; i < 5; i++)
                sum += int.Parse(Console.ReadLine());
            Console.WriteLine(sum);
        }
    }
}
