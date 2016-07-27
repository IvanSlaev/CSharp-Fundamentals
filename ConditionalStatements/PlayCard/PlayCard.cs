using System;

namespace PlayCard
{
    class PlayCard
    {
        static void Main(string[] args)
        {
            string playCard = Console.ReadLine();
            string[] playCards = new string[13] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
            string message = "no";
            foreach (var card in playCards)
            {
                if (card == playCard)
                    message = "yes";
            }
            Console.WriteLine("{0} {1}",message, playCard);
        }
    }
}