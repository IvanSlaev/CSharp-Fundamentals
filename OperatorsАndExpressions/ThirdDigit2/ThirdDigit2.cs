using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDigit2
{
    class ThirdDigit2
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            if (number.Length < 3)
                Console.WriteLine("false " + 0);
            else
            {
                int indexOfThirdElement = number.Length - 3;
                char thirdElement = number.ElementAt(indexOfThirdElement);
                int thirdDigit = int.Parse(new string(thirdElement, 1));
                if (thirdDigit == 7)
                    Console.WriteLine("true");
                else
                    Console.WriteLine("false {0}", thirdDigit);
            }
           
        }
    }
}
