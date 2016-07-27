using System;

namespace Cube
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int counter = 1;

            int n = 2;
            int m = 1;

            while (counter < 2*N)
            {
                if (counter == 1)
                {
                    for (var i = 1; i < N; i++)
                        Console.Write(" ");
                    for (var i = 1; i <= N; i++)
                        Console.Write(":");
                    Console.WriteLine();
                    counter++;
                }
                else if (counter == 2)
                {
                    for (var i = 1; i < N - 1; i++)
                        Console.Write(" ");
                    Console.Write(":");
                    for (var i = 1; i <= N - 2; i++)
                        Console.Write("/");
                    Console.Write("::");
                    Console.WriteLine();
                    counter++;
                }
                else if (counter > 2 && counter <= N - 1)
                {
                    for (var i = 1; i < N - n; i++)
                        Console.Write(" ");
                    Console.Write(":");
                    for (var i = 1; i <= N - 2; i++)
                        Console.Write("/");
                    Console.Write(":");
                    for (var i = 1; i <= m; i++)
                        Console.Write("X");
                    Console.Write(":");
                    Console.WriteLine();
                    counter++;
                    n++;
                    m++;
                }
                else if (counter == N)
                {
                    for (var i = 1; i <= N; i++)
                        Console.Write(":");
                    for (var i = 1; i <= m; i++)
                        Console.Write("X");
                    Console.Write(":");
                    Console.WriteLine();
                    counter++;
                    m--;
                    n--;
                }
                else if (counter > N && counter < N * 2 - 1)
                {
                    Console.Write(":");
                    for (var i = 1; i <= n; i++)
                        Console.Write(" ");
                    Console.Write(":");
                    for (var i = 1; i <= m; i++)
                        Console.Write("X");
                    Console.Write(":");
                    Console.WriteLine();
                    counter++;
                    m--;
                }
                else if (counter == N * 2 - 1)
                {
                    for (var i = 1; i <= N; i++)
                        Console.Write(":");
                    Console.WriteLine();
                    counter++;
                }
            }
        }
    }
}
