using System;


namespace _2.Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = int.Parse(Console.ReadLine());

            if (score == 0)
            {
                Console.WriteLine("invalid score");
            }
            else if (score <= 3)
            {
                Console.WriteLine(score * 10);
            }
            else if (score <= 6)
            {
                Console.WriteLine(score * 100);
            }
            else if (score <= 9)
            {
                Console.WriteLine(score * 1000);
            }
            else
            {
                Console.WriteLine("invalid score");
            }
        }
    }
}
