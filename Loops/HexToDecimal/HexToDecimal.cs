using System;

namespace HexToDecimal
{
    class HexToDecimal
    {
        public static long PowerOf16(int power)
        {
            long power16 = 1;
            for (int i = 1; i <= power; i++)
            {
                power16 *= 16;
            }
            return power16;
        }

        static void Main(string[] args)
        {
            string hexNumber = Console.ReadLine();
            int power = hexNumber.Length - 1;
            long decNumber = 0;

            foreach (char character in hexNumber)
            {
                string stringChar = Convert.ToString(character);
                long stringCharBuffer = 0;
                switch (stringChar)
                {
                    case "1":
                        stringCharBuffer = 1;
                        break;
                    case "2":
                        stringCharBuffer = 2;
                        break;
                    case "3":
                        stringCharBuffer = 3;
                        break;
                    case "4":
                        stringCharBuffer = 4;
                        break;
                    case "5":
                        stringCharBuffer = 5;
                        break;
                    case "6":
                        stringCharBuffer = 6;
                        break;
                    case "7":
                        stringCharBuffer = 7;
                        break;
                    case "8":
                        stringCharBuffer = 8;
                        break;
                    case "9":
                        stringCharBuffer = 9;
                        break;
                    case "A":
                        stringCharBuffer = 10;
                        break;
                    case "B":
                        stringCharBuffer = 11;
                        break;
                    case "C":
                        stringCharBuffer = 12;
                        break;
                    case "D":
                        stringCharBuffer = 13;
                        break;
                    case "E":
                        stringCharBuffer = 14;
                        break;
                    case "F":
                        stringCharBuffer = 15;
                        break;
                    case "a":
                        stringCharBuffer = 10;
                        break;
                    case "b":
                        stringCharBuffer = 11;
                        break;
                    case "c":
                        stringCharBuffer = 12;
                        break;
                    case "d":
                        stringCharBuffer = 13;
                        break;
                    case "e":
                        stringCharBuffer = 14;
                        break;
                    case "f":
                        stringCharBuffer = 15;
                        break;
                }
                decNumber += stringCharBuffer * PowerOf16(power);
                power--;
            }
            Console.WriteLine(decNumber);
        }
    }
}
