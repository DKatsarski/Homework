using System;
using System.Collections.Generic;
using System.Numerics;

namespace _1.Durankulak_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int numberToConvert = 0;
            BigInteger decimalNumber = 0;
            var result = new List<int>();
            // declaring the table 
            for (int i = 0; i < input.Length; i++)
            {
               
                    for (int j = 'A'; j <= 'Z'; j++)
                    {
                        if (input[i] == (char)j && input.Length == 1)
                        {
                            result.Add((int)input[i] - 'A');
                            break;
                        }
                        else if (input[i] == (char)j)
                        {
                            result.Add((int)input[i] - 'A');
                            break;
                        }

                    }

                    for (int k = 26, d = 'a'; k <= 156; k += 26, d++)
                    {
                        if (input[i] == d)
                        {
                            numberToConvert = k + input[i + 1] - 'A';
                            result.Add(numberToConvert);
                            i++;
                            break;
                        }
                    }
            }

            for (int i = 0; i < result.Count; i++)
            {
                decimalNumber += result[i] * BigInteger.Pow(168, result.Count - i - 1);
            }
            Console.WriteLine(decimalNumber);

        }

    }
}
