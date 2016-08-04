using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Moving_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            //input - masiw
            string[] words = Console.ReadLine().Split(' ');

            string result = ExtractLetters(words);
            result = MoveLetters(result);
            Console.WriteLine(result);

        }

        private static string MoveLetters(string result)
        {
           
        }

        private static string ExtractLetters(string[] words)
        {

            string result = string.Empty;
            int maxWordLength = words.Max(word => word.Length);

            for (int i = 0; i < maxWordLength; i++)
            {
                foreach (string word in words)
                {
                    int index = word.Length - i - 1;
                    bool condition = index >= 0;
                    if (condition)
                    {
                        result += word[index];
                    }
                }
            }
            return result;

        }
    }
}
