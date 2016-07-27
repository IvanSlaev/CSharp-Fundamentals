using System;

namespace ExchangeIfGreater
{
    class ExchangeIfGreater
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            if (A > B)
            {
                double buffer = B;
                B = A;
                A = buffer;
            }
            Console.WriteLine("{0} {1}", A, B);
        }
    }
}
