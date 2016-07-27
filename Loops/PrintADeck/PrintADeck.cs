using System;
using System.Collections.Generic;

namespace PrintADeck
{
    class PrintADeck
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> cards = new List<string>() { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            int lastSignToOutput = cards.IndexOf(input);
            for (var i = 0; i <= lastSignToOutput; i++)
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", cards[i]);
        }
    }
}
