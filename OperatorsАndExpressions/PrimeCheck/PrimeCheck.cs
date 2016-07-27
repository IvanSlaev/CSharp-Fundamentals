using System;

namespace PrimeCheck
{
    class PrimeCheck
    {
        static void Main(string[] args)
        {
            int prime = int.Parse(Console.ReadLine());
            string message = "true";
            if (prime < 2)
                message = "false";
            for (int i = 2; i <= 100; i++)
            {
                int remainder = prime % i;
                if (i != prime)
                {
                    if (remainder == 0)
                    {
                        message = "false";
                        break;
                    }

                }
            }
            Console.WriteLine(message);
        }
    }
}
