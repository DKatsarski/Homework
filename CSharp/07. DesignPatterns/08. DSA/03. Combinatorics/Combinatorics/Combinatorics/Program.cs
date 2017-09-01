using System;
using System.Collections.Generic;

namespace Combinatorics
{
    public class Program
    {
        static void CountingCombinations(int n, List<int> list)
        {
            if (n == 0)
            {

                list.Add(1);
                return;
            }
            

            CountingCombinations(n - 1, list);

            CountingCombinations(n - 1, list);

        }
        static void Main()
        {
            string input = Console.ReadLine();
            int counter = 0;
            char ch = '*';

            foreach (var item in input)
            {
                if (item == ch)
                {
                    counter++;
                }
            }

            long result = 1;

            for (double i = 0; i < counter; i++)
            {
                result += (long)Math.Pow(2.0, i);
            }

            Console.WriteLine(result);
        }
    }
}
