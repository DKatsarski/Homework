using System;
using System.Numerics;
using System.Text;

namespace _01.Zerg___
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] number = { "Rawr", "Rrrr", "Hsst", "Ssst", "Grrr", "Rarr", "Mrrr", "Psst", "Uaah", "Uaha", "Zzzz", "Bauu", "Djav", "Myau", "Gruh" };
            string input = Console.ReadLine();
            BigInteger decinamlNumber = 0;
            int counter = 0;

            for (int i = 0; i < input.Length - 3; i += 4)
            {
                string holder = string.Empty;
                BigInteger digit = 0;
              
                holder = input.Substring(i, 4);

                digit = Array.IndexOf(number, holder);

                decinamlNumber += digit * BigInteger.Pow(15, input.Length / 4 - 1 - counter);
                counter++;
            }
            Console.WriteLine(decinamlNumber);
        }
    }
}
