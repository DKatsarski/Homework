using System;
using System.Text.RegularExpressions;

namespace _02.CombinationsWithDuplicants
{
    public class Startup
    {
        static void Main()
        {
            int permutationsOfNumber = int.Parse(Console.ReadLine());
            int lenthOfLoop = permutationsOfNumber;

            NestingLoops(permutationsOfNumber, lenthOfLoop);
        }

        public static void NestingLoops(int n, int loopNumber, string vector = "", int counter = 1)
        {
            if (n == 0)
            {
                string stringWithNoWhiteSpaces = string.Empty;

                stringWithNoWhiteSpaces = Regex.Replace(vector, @"\s+", "");
                
                // Cheking if the same number exists two times
                for (int i = 0; i < stringWithNoWhiteSpaces.Length - 1; i++)
                {
                    for (int j = i; j < stringWithNoWhiteSpaces.Length - 1; j++)
                    {
                        if (stringWithNoWhiteSpaces[i] == stringWithNoWhiteSpaces[j + 1])
                        {
                            return;
                        }
                    }
                }

                Console.Write("(" + vector.Trim() + "), ");
                return;
            }

            NestingLoops(n - 1, loopNumber, vector + " " + (counter));

            for (int i = 0; i < loopNumber - 1; i++)
            {
                NestingLoops(n - 1, loopNumber, vector + " " + (counter += 1));
            }
        }
    }
}
