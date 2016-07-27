using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitsToBits
{
    class Program
    {
        static void Main(string[] args)
        {
            byte N = byte.Parse(Console.ReadLine());
            int[] numbers = new int[N];
            byte counter0 = 1, counter1 = 0, bufferCounter0 = 0, bufferCounter1 = 0;
            int mask = 1, prevNumber = 0, nowNumber = 0, buffer = 0;

            for (byte i = 0; i < N; i++)
                numbers[i] = int.Parse(Console.ReadLine());
            for (byte i = 0; i < N; i++)
            {
                prevNumber = numbers[i] & mask;
                if (prevNumber == 0)
                    counter0++;
                else
                    counter1++;

                for (int j = 1; j < 30; j++)
                {
                    buffer = numbers[i] >> i;
                    nowNumber = buffer & mask;
                    if (nowNumber == prevNumber)
                    {
                        if (nowNumber == 0)
                            counter0++;
                        else
                            counter1++;
                    }
                    else
                    {
                        if (nowNumber == 0)
                        {
                            counter0++;
                            if (bufferCounter1 < counter1)
                            {
                                bufferCounter1 = counter1;
                                counter1 = 0;
                            }
                        }
                        else
                        {
                            counter1++;
                            if (bufferCounter0 < counter0)
                            {
                                bufferCounter0 = counter0;
                                counter0 = 0;
                            }
                        }
                    }
                    prevNumber = nowNumber;
                }

                Console.WriteLine(bufferCounter0);
                Console.WriteLine(bufferCounter1);
            }
        }
    }
}
