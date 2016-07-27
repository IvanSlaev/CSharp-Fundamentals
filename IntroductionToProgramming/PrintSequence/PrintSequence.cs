using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintSequence
{
    class PrintSequence
    {
        static void Main(string[] args)
        {
            var number = 2;
            for (var i = 0; i < 10; i++)
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
