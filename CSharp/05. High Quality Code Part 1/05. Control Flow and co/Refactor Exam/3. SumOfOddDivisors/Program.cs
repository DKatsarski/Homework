namespace _3.SumOfOddDivisors
{
    using System;

    class Program
    {
        static void Main()
        {
            int startInterval = int.Parse(Console.ReadLine());
            int endInterval = int.Parse(Console.ReadLine());
            int sumOfOdDevisors = 0;

            for (int i = startInterval; i <= endInterval; i++)
            {
                for (int j = 1; j < 1000; j++)
                {
                    if (i % j == 0 && j % 2 != 0)
                    {
                        sumOfOdDevisors += j;
                    }
                }
            }

            Console.WriteLine(sumOfOdDevisors);
        }
    }
}
