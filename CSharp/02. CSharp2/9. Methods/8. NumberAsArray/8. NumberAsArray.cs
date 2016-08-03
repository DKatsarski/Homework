using System;
using System.Collections.Generic;
using System.Linq;

namespace _8.NumberAsArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);

            int[] a1 = Console.ReadLine()
                .Trim(' ')
                .Split(' ')
                .Select(x => int.Parse(x))
                .ToArray();
            int[] b1 = Console.ReadLine()
               .Trim(' ')
               .Split(' ')
               .Select(x => int.Parse(x))
               .ToArray();

            List<int> result = new List<int>();

            if (a1.Length > b1.Length)
            {
                for (int i = 0; i < b1.Length; i++)
                {
                    result.Add(a1[i] + b1[i]);
                }
                for (int i = b1.Length; i < a1.Length; i++)
                {
                    result.Add(a1[i]);
                }
            }
            else
            {
                for (int i = 0; i < a1.Length; i++)
                {
                    result.Add(a1[i] + b1[i]);
                }
                for (int i = a1.Length; i < b1.Length; i++)
                {
                    result.Add(b1[i]);
                }
            }

            for (int i = 0; i < result.Count; i++)
            {
                if (result[i] == result[result.Count - 1] && result[i] > 9)
                {
                    result[i] = result[i] - 10;
                    Console.Write("{0} ", result[i]);
                    result.Add(1);
                    result[i + 1] = 1;
                    Console.Write("{0} ", result[i + 1]);
                }
                else if (result[i] > 9  )
                {
                    result[i] = result[i] - 10;
                    result[i + 1] = result[i + 1] + 1;
                }


                Console.Write("{0} ", result[i]);
            }

            Console.ReadLine();
        }
    }
}
