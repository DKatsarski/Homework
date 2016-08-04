using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestArea
{
    class TestArea
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                                            .Split(' ');
            StringBuilder result = new StringBuilder();
            result = ExtractLetters(input);

            result = MoveLetters(result);
            Console.WriteLine(result.ToString());


        }

        private static StringBuilder MoveLetters(StringBuilder result)
        {

            for (int i = 0; i < result.Length; i++)
            {
                char letter = result[i];
                int positionInAlphabet = char.ToLower(letter) - 'a' + 1;
                result.Remove(i, 1);
                int expectedPosition = (positionInAlphabet + i) % (result.Length + 1);

                result.Insert(expectedPosition, letter);


            }
            return result;
        }





        private static StringBuilder ExtractLetters(string[] input)
        {
            StringBuilder sb = new StringBuilder();
            int longestWord = input.Max(word => word.Length);

            for (int i = 0; i < longestWord; i++)
            {
                foreach (var word in input)
                {
                    int index = word.Length - 1 - i;
                    bool condition = index >= 0;
                    if (condition)
                    {
                        sb.Append(word[index]);
                    }
                }
            }
            return sb;
        }
    }
}