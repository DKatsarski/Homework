using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.CombinationsWithDuplicants
{
    public class Startup
    {
        static void Main()
        {
            var list = new List<string>() { "test", "rock", "fun" };

            int permutationsOfNumber = list.Count;
            int lenthOfLoop = permutationsOfNumber;

            NestingLoops(permutationsOfNumber, lenthOfLoop, list);
        }

        public static void NestingLoops(int n, int loopNumber, List<string> list, string vector = "", int counter = 0)
        {
            if (n == 1)
            {

                var stringWithNoWhiteSpaces = string.Join(" ", vector.Trim()).Split(' ');

                // Cheking if the same number exists two times
                for (int i = 0; i < stringWithNoWhiteSpaces.Length - 1; i++)
                {

                    if (stringWithNoWhiteSpaces[i] == stringWithNoWhiteSpaces[i + 1])
                    {
                        return;
                    }
                }

                // I can put them all  in a list and then do a seperate check to see if something is repeating
                Console.Write("(" + vector.Trim() + "), ");
                return;
            }

            NestingLoops(n - 1, loopNumber, list, vector + " " + list[counter]);

            for (int i = 0; i < loopNumber - 1; i++)
            {
                if (counter >= list.Count - 1)
                {
                    return;
                }
                else
                {
                    NestingLoops(n - 1, loopNumber, list, vector + " " + list[counter += 1]);
                }
            }
        }
    }
}
