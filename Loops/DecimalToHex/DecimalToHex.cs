using System;
using System.Collections.Generic;

namespace DecimalToHex
{
    class DecimalToHex
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            string hexBuffer;
            List<string> hexNumberList = new List<string>();

            if (number == 0)
                Console.WriteLine(0);
            else
            {
                while (number != 0)
                {
                    hexBuffer = Convert.ToString(number % 16);
                    switch (hexBuffer)
                    {
                        case "10":
                            hexBuffer = "A";
                            break;
                        case "11":
                            hexBuffer = "B";
                            break;
                        case "12":
                            hexBuffer = "C";
                            break;
                        case "13":
                            hexBuffer = "D";
                            break;
                        case "14":
                            hexBuffer = "E";
                            break;
                        case "15":
                            hexBuffer = "F";
                            break;
                    }
                    hexNumberList.Add(hexBuffer);
                    number /= 16;
                }
            }
            hexNumberList.Reverse();
            string hexNumber = String.Join(null, hexNumberList);
            Console.WriteLine(hexNumber);
        }
    }
}
