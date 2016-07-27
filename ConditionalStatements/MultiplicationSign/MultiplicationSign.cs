using System;

namespace MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());
            if (A == 0 || B == 0 || C == 0)
                Console.WriteLine(0);
            else
            {
                if (A < 0)
                {
                    if (B < 0)
                    {
                        if (C < 0)
                            Console.WriteLine("-");
                        else
                            Console.WriteLine("+");
                    }
                    else
                    {
                        if (C < 0)
                            Console.WriteLine("+");
                        else
                            Console.WriteLine("-");
                    }
                }
                else
                {
                    if (B < 0)
                    {
                        if (C < 0)
                            Console.WriteLine("+");
                        else
                            Console.WriteLine("-");
                    }
                    else
                    {
                        if (C < 0)
                            Console.WriteLine("-");
                        else
                            Console.WriteLine("+");
                    }
                }
            }
        }
    }
}
