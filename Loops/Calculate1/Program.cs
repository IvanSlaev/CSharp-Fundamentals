using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            double sum = 1, fac = 1;

            for (int i = 1; i <= N; i++)
            {
                fac *= i;
                sum += (fac / Math.Pow(x, i));
            }
            Console.WriteLine("{0:0.00000}", sum);
        }
    }
}
