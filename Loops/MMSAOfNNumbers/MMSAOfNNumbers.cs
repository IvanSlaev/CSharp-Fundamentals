using System;

namespace MMSAOfNNumbers
{
    class MMSAOfNNumbers
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double[] numbers = new double[N];
            for (int i = 0; i < N; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());
            }
            double min = numbers[0], max = numbers[0], sum = numbers[0];
            for (int i = 1; i < N; i++)
            {
                if (numbers[i] < min)
                    min = numbers[i];
                else if (numbers[i] > max)
                    max = numbers[i];

                sum += numbers[i];
            }
            double avg = sum / (double)N;
            Console.WriteLine("min={0:0.00}", min);
            Console.WriteLine("max={0:0.00}", max);
            Console.WriteLine("sum={0:0.00}", sum);
            Console.WriteLine("avg={0:0.00}", avg);
        }
    }
}