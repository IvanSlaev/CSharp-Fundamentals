using System;

namespace FourDigits
{
    class FourDigits
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] inputArray = input.ToCharArray();

            int sumOfDigits = 0;
            foreach (var element in inputArray)
                sumOfDigits += int.Parse(new string(element, 1));
            Console.WriteLine(sumOfDigits);

            char[] revArray = input.ToCharArray();
            Array.Reverse(revArray);
            Console.WriteLine(revArray);

            char[] lastFirstDigitArray = new char[4];
            char lastEl = inputArray[3];
            lastFirstDigitArray[0] = lastEl;
            for (var i = 1; i <= 3; i++)
                lastFirstDigitArray[i] = inputArray[i - 1];
            Console.WriteLine(lastFirstDigitArray);

            char[] lastFirstRevArray = input.ToCharArray();
            lastFirstRevArray[1] = inputArray[2];
            lastFirstRevArray[2] = inputArray[1];
            Console.WriteLine(lastFirstRevArray);
        }
    }
}
