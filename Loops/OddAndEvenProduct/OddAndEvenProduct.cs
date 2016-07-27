using System;

namespace OddAndEvenProduct
{
    class OddAndEvenProduct
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string numbersString = Console.ReadLine();
            string[] numbersArray = numbersString.Split(' ');
            long evenPro = 1;
            long oddPro = 1;

            for (int i = 1; i <= N; i++)
            {
                if (i % 2 == 0)
                    evenPro *= int.Parse(numbersArray[i - 1]);
                else
                    oddPro *= int.Parse(numbersArray[i - 1]);
            }
            if (oddPro == evenPro)
                Console.WriteLine("yes {0}", oddPro);
            else
                Console.WriteLine("no {0} {1}", oddPro, evenPro);
        }
    }
}
