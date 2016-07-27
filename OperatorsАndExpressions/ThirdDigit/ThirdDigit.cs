using System;
using System.Collections.Generic;
using System.Linq;

namespace ThirdDigit
{
    class ThirdDigit
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string numbers = number.ToString();
            if (numbers.Length < 3)
                Console.WriteLine("false " + 0);
            else
            {
                int indexOfThirdElement = numbers.Length - 3;
                List<int> integerList = new List<int>();
                foreach (var numb in numbers)
                    integerList.Add(int.Parse(new string(numb, 1)));
                if (integerList.ElementAt(indexOfThirdElement) == 7)
                    Console.WriteLine("true");
                else
                    Console.WriteLine("false {0}", integerList.ElementAt(indexOfThirdElement));
            }
        }
    }
}