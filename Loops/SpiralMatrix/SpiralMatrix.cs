using System;

namespace SpiralMatrix
{
    class SpiralMatrix
    {
        static void Main(string[] args)
        {
            
            int n = byte.Parse(Console.ReadLine());
            int[,] arr = new int[n, n];

            int ri = 0, rn = n - 1, ci = 0, cn = n - 1, elementValue = 1, direction = 0, i = 0;
            while (ri <= rn && ci <= cn)
            {
                if (direction == 0)
                {
                    for (i = ri; i <= rn; i++)
                    {
                        arr[ri, i] = elementValue;
                        elementValue++;
                    }
                    direction++;
                    ri++;
                }
                else if (direction == 1)
                {
                    for (i = ri; i <= rn; i++)
                    {
                        arr[i, cn] = elementValue;
                        elementValue++;
                    }
                    direction++;
                    cn--;
                }
                else if (direction == 2)
                {
                    for (i = cn; i >= ci; i--)
                    {
                        arr[rn, i] = elementValue;
                        elementValue++;
                    }
                    direction++;
                    rn--;
                }
                else if (direction == 3)
                {
                    for (i = rn; i >= ri; i--)
                    {
                        arr[i, ci] = elementValue;
                        elementValue++;
                    }
                    direction = 0;
                    ci++;
                }
            }
            for (int p = 0; p < n; p++)
            {
                for (int q = 0; q< n; q++)
                {
                    Console.Write("{0} ", arr[p, q]);
                }
                Console.WriteLine();
            }

            //tom
        }
    }
}
