using System;

namespace GCD
{
    class GCD
    {
        static void Main(string[] args)
        {
            string[] numArray = Console.ReadLine().Split(' ');
            int maxNumber = Math.Max(int.Parse(numArray[0]), int.Parse(numArray[1]));
            int minNumber = Math.Min(int.Parse(numArray[0]), int.Parse(numArray[1]));
            int remainder = maxNumber % minNumber;
            if (remainder == 0)
                Console.WriteLine(minNumber);
            else
            {
                while (remainder != 0)
                {
                    remainder = maxNumber % minNumber;
                    maxNumber = minNumber;
                    minNumber = remainder;
                }
                Console.WriteLine(maxNumber);
            }
        }
    }
}
