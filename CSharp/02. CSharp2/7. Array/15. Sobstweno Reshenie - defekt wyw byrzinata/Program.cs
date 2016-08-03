using System;

namespace _15.PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = int.Parse(Console.ReadLine());
            long theNumber = 0;
            long count = 0;

            for (long i = 3; i <= n; i++)
            {
                for (long j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }

                }
                if (count == 2)
                {
                    theNumber = i;
                }

                count = 0;

            }
            Console.WriteLine(theNumber);
        }
    }
}
