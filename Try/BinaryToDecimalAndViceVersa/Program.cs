using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimalAndViceVersa
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Bin, Dec and Hex string to integer");
            //string decNumber = "1234";
            //Console.WriteLine("Decimal string {0}", decNumber);
            //string hexNumber = "4d2";
            //Console.WriteLine("Hex string {0}", hexNumber);
            //string binNumber = "10011010010";
            //Console.WriteLine("Binary string {0}", binNumber);
            //Console.WriteLine("from bin to decimal");
            //Console.WriteLine(Convert.ToInt32(binNumber, 2));
            //Console.WriteLine("from hex to decimal"); 
            //Console.WriteLine(Convert.ToInt32(hexNumber, 16));
            //Console.WriteLine();
            //Console.WriteLine("Integer to bin and hex");
            //int intNumber = 1234;
            //Console.WriteLine("Integer {0}",intNumber);
            //string binaryNumber = Convert.ToString(intNumber, 2);
            //Console.WriteLine("Binary number {0}", binaryNumber);
            //string toHex = Convert.ToString(intNumber, 16);
            //Console.WriteLine("Hex number {0}", toHex);

            int one = 1177;
            int number = 27;
            int posi = 0, digiti = 0, newNumber = 0, mask = 1;
            digiti = number & mask;
            newNumber = digiti << 1;
            for (int i = 4; i > 1; i--)
            {
                if (i > 2)
                {
                    posi = number >> i;
                    digiti = posi & mask;
                    newNumber = newNumber | digiti;
                    newNumber = newNumber << 1;
                }
                else
                {
                    posi = number >> i;
                    digiti = posi & mask;
                    newNumber = newNumber | digiti;
                }

                
            }
            Console.WriteLine(newNumber);
            string newNum = Convert.ToString(newNumber, 2);
            Console.WriteLine(newNum);
        }
    }
}
