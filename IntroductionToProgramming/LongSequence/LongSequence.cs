using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongSequence
{
    class LongSequence
    {
        static void Main(string[] args)
        {
            var number = 2;
            for (var i = 0; i < 1000; i++)
            {
                Console.WriteLine(number);
                if (number > 0)
                    number++;
                else
                    number--;
                number *= -1;
            }
        }
    }
}
