using System;

namespace TheBiggestOfFiveNumbers
{
    class TheBiggestOfFiveNumbers
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[5];
            for (var i = 0; i < 5; i++)
                numbers[i] = double.Parse(Console.ReadLine());
            double buffer = numbers[0];
            for (var i = 1; i < 5; i++)
                if (buffer < numbers[i])
                    buffer = numbers[i];
            Console.WriteLine(buffer);
        }
    }
}
