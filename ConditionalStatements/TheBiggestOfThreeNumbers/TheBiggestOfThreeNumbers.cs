using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBiggestOfThreeNumbers
{
    class TheBiggestOfThreeNumbers
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double buffer = a;
            if (buffer < b)
                buffer = b;
            if (buffer < c)
                buffer = c;
            Console.WriteLine(buffer);
        }
    }
}
