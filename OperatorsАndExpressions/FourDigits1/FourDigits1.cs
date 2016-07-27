using System;

namespace FourDigits1
{
    class FourDigits1
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int d = num % 10;
            int c = (num % 100) / 10;
            int b = (num % 1000) / 100;
            int a = (num % 10000) / 1000;

            Console.WriteLine(a + b + c + d);
            Console.WriteLine(d + "" + c + "" + b + "" + a);
            Console.WriteLine(d + "" + a + "" + b + "" + c);
            Console.WriteLine(a + "" + c + "" + b + "" + d);
        }
    }
}
