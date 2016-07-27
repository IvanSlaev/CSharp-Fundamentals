using System;

namespace ThirdBit
{
    class ThirdBit
    {
        static void Main(string[] args)
        {
            int p = 3;
            int number = int.Parse(Console.ReadLine());
            int mask = 1 << p;
            int andMaskNumber = mask & number;
            int result = andMaskNumber >> p;
            Console.WriteLine(result);
            Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
        }
    }
}
