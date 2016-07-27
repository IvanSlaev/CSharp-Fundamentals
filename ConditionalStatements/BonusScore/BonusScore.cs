using System;

namespace BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            int score = int.Parse(Console.ReadLine());
            if (score >= 1 && score <=3)
                Console.WriteLine(Convert.ToString(score * 10));
            else if (score >= 4 && score <= 6)
                Console.WriteLine(Convert.ToString(score * 100));
            else if (score >= 7 && score <= 9)
                Console.WriteLine(Convert.ToString(score * 1000));
            else
                Console.WriteLine("invalid score");
        }
    }
}
