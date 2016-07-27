using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charove = new char[3] { '1', '2', '3' };
            int[] intove = new int[3];
            intove = charove.Select(x => x - '0').ToArray();
            StringBuilder chislo = new StringBuilder();
            for (int i = 0; i < intove.Length; i++)
            {
                chislo.Append(intove[i] + " ");
            }
            Console.WriteLine(chislo);


        }
    }
}
