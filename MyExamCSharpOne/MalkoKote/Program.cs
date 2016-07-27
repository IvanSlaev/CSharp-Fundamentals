using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalkoKote
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            char character = char.Parse(Console.ReadLine());
            int add = (N - 2) / 4;


            Console.Write(" ");
            Console.Write(character);
            for (int j = 1; j < add; j++)
                Console.Write(" ");
            Console.WriteLine(character);

            for (int i = 0; i < add - 1; i++)
            {
                Console.Write(" ");
                for (int j = 0; j < add; j++)
                    Console.Write(character);
            Console.WriteLine(character);
            }

            for (int i = 0; i < add - 1; i++)
            {
                Console.Write(" ");
                Console.Write(" ");
                for (int j = 0; j < add - 1; j++)
                    Console.Write(character);
                Console.WriteLine();
            }
        }
    }
}
