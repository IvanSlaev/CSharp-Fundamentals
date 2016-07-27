using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conductor
{
    class Program
    {
        static void Main(string[] args)
        {
            int P = int.Parse(Console.ReadLine());
            int ticketsForPerforation = int.Parse(Console.ReadLine());
            List<int> tickets = new List<int>();
            for (int i = 0; i < ticketsForPerforation; i++)
                tickets.Add(int.Parse(Console.ReadLine()));
            int N = 0, mask = 1, position = 0, digit = 0, newN = 0;

            string strP = Convert.ToString(P, 2);


            foreach (var ticket in tickets)
            {
                N = ticket;
                string strN = Convert.ToString(N, 2);
                for (int i = strP.Length - 1; i < strN.Length; i++)
                {
                    for (int j = i; j > i - strP.Length; j--)
                    {
                        position = N >> j;
                        digit = position & mask;
                        newN = (digit | newN) << j;
                    }
                    Console.WriteLine(newN);
                }

            }
             
        }
    }
}
