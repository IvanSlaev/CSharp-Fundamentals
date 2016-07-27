using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourDigits
{
    class FourDigits
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] inputArray = input.ToCharArray();
            char[] revercedArray = input.ToCharArray();
            Array.Reverse(revercedArray);
            Console.WriteLine(revercedArray);
            char firstNumber = inputArray[0];
            char lastNumber = inputArray[3];
            char[] revFirstAndLastArray = input.ToCharArray();
            revFirstAndLastArray.SetValue(lastNumber, 0);
            revFirstAndLastArray.SetValue(firstNumber, 3);
            Console.WriteLine(revFirstAndLastArray);




        }
    }
}
