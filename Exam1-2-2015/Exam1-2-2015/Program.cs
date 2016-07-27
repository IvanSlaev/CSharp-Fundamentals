using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1_2_2015
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int maxNumber = A;
            int minNumber = A;
            int average;

            if (maxNumber < B)
                maxNumber = B;
            if (maxNumber < C)
                maxNumber = C;


        }
    }
}
