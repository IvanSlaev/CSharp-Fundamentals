using System;

namespace PrintТheASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 33; i <= 126; i++)
            {
                char character = (char)i;
                Console.Write(character.ToString());
            }
        }
    }
}