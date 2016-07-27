using System;
using System.Linq;
using System.Text;

namespace CSAdvancedExam1
{
    class Problem1
    {
        public static int PowerOf22(int power)
        {
            int powerOf22 = 1;
            if (power != 0)
            {
                for (int i = 1; i <= power; i++)
                {
                    powerOf22 *= 23;
                }
            }
            return powerOf22;
        }
        public static int ToDecimal(string number)
        {
            int decNumber = 0;
            int power = number.Length - 1;
            foreach (char c in number)
            {
                decNumber += ((int)c - 97) * PowerOf22(power);
                power--;
            }
            return decNumber;
        }

        public static string BackTo23(int number)
        {
            StringBuilder number23base = new StringBuilder();
            while (number != 0)
            {
                number23base.Insert(0,((char)(number % 23 + 97)));
                number /= 23;
            }
            return number23base.ToString();
        }
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine()
                .Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            int holeDecimal = 0;
            foreach (string number in numbers)
            {
                holeDecimal += ToDecimal(number);
            }
            Console.WriteLine("{0} = {1}", BackTo23(holeDecimal), holeDecimal);
        }
    }
}
