namespace Exam
{
    using System;

    class Program
    {
        static void Main()
        {
            long trees = long.Parse(Console.ReadLine());
            long branches = long.Parse(Console.ReadLine());
            long squerrels = long.Parse(Console.ReadLine());
            long tails = long.Parse(Console.ReadLine());

            double totalTailsCount = trees * branches * squerrels * tails;

            // The logic behind the mathematical operations in the if-statement
            // are given by the condition of the exercise.
            if (totalTailsCount % 2 == 0)
            {
                totalTailsCount *= 376439;
                Console.WriteLine("{0:F3}", totalTailsCount);
            }
            else if (totalTailsCount % 2 != 0)
            {
                totalTailsCount /= 7;
                Console.WriteLine("{0:F3}", totalTailsCount);
            }
        }
    }
}
