using System;
using System.Collections.Generic;

namespace PrintADeckWithUsingChars
{
    class PrintADeckWithUsingChars
    {
        static void Main(string[] args)
        {

            char input = Convert.ToChar(Console.ReadLine());
            List<char> cards = new List<char>() { '2', '3', '4', '5', '6', '7', '8', '9', '1', 'J', 'Q', 'K', 'A' };
            int lastSignToOutput = cards.IndexOf(input);
            for (var i = 0; i <= lastSignToOutput; i++)
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", cards[i]);
        }
    }
}
