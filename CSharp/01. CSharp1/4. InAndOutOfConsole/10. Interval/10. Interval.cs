using System;

namespace _10.Interval
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int count = 0;

            int greaterNumber = Math.Max(n, m);
            int smallerNumber = Math.Min(n, m);
            int number = smallerNumber + 1;

            for (int i = number; i <= greaterNumber; i++)
            {
                if ((i % 5) == 0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
