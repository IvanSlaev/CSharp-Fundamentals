using System;
using System.Collections.Generic;

namespace DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            List<string> listOfBits = new List<string>();
            int i = 0;
            if (number == 0)
                Console.WriteLine(0);
            else
            {
            while (number != 0)
            {
                listOfBits.Add(Convert.ToString(number % 2));
                number /= 2;
            }
            listOfBits.Reverse();
            string res = String.Join( null , listOfBits);
            Console.WriteLine(res);
            }
        }
    }
}
