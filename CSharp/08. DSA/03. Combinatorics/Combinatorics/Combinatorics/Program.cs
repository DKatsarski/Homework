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
            var counter = 0;
            char ch = '*';

            for (int i = 0; i < input.Length; i++)
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
