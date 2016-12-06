using System;
using System.Collections.Generic;

namespace Combinatorics
{
    public class Program
    {
        static void CountingCombinations(int n, List<int> list, string vector = "")
        {
            if (n == 0)
            {

                list.Add(1);
                return;
            }

            var counter = 1;

            CountingCombinations(n - 1, list, vector + counter);

            CountingCombinations(n - 1, list, vector + (counter += 1));

        }
        static void Main()
        {
            string input = Console.ReadLine();
            var counter = 1;
            char ch = '*';

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == ch)
                {
                    counter++;
                }
            }
            
            if (counter == 1)
            {
                Console.WriteLine(counter);
            }
            else
            {
                int number = counter;
                var list = new List<int>();

                CountingCombinations(number, list);
                Console.WriteLine(list.Count);
            }
        }
    }
}
