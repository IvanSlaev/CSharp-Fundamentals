using System;
using System.Collections.Generic;

namespace Conductor
{
    class Program
    {
        static void Main(string[] args)
        {
            int P = int.Parse(Console.ReadLine());
            int ticketsForPerforation = int.Parse(Console.ReadLine());
            int[] tickets = new int[ticketsForPerforation];
            for (int i = 0; i < ticketsForPerforation; i++)
                tickets[i] = int.Parse(Console.ReadLine());
            int N = 0, mask = 1, position = 0, digit = 0, newN = 0, mask1 = 1;

            string strP = Convert.ToString(P, 2);


            foreach (var ticket in tickets)
            {
                N = ticket;
                string strN = Convert.ToString(N, 2);
                for (int i = strP.Length - 1; i < strN.Length; i++)
                {
                    for (int j = i; j > i - strP.Length; j--)
                    {
                        if (j > i - strP.Length + 1)
                        {
                        position = N >> j;
                        digit = position & mask;
                        newN = (digit | newN) << 1;
                        }
                        else
                        {
                            position = N >> j;
                            digit = position & mask;
                            newN = digit | newN;
                        }
                    }
                    if (newN == P)
                    {
                        for (int j = i; j > i - strP.Length; j--)
                        {
                            mask1 = ~(mask << j);
                            N = N & mask1;
                        }
                    }
                    newN = 0;
                }
                Console.WriteLine(N);
            }  
        }
    }
}
