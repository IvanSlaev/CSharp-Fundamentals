using System;

namespace BinaryToDecimal
{
    class BinaryToDecimal
    {
        public static long PowerOf2(int power)
        {
            long power2 = 1;
            for (int i = 1; i <= power; i++)
            {
                power2 *= 2;
            }
            return power2;
        }
        static void Main(string[] args)
        {
            string binNumber = Console.ReadLine();
            long decNumber = 0;
            int power = binNumber.Length - 1;

            foreach (var character in binNumber)
            {
                if (character == '1')
                    decNumber += PowerOf2(power);
                power--;
            }
            Console.WriteLine(decNumber);
        }
    }
}
