using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002.Magic_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');

            StringBuilder result = ExtractLetters(words);

            result = MoveLetters(result);
            Console.WriteLine(result.ToString());



        }

        private static StringBuilder MoveLetters(StringBuilder builder)
        {
            for (int i = 0; i < builder.Length; i++)
            {
                char letter = builder[i];
                int indexInAlphabet = char.ToLower(letter) - 'a' + 1;
                MoveRight(builder, i, indexInAlphabet);
            }
            return builder;
        }

        private static void MoveRight(StringBuilder builder, int index, int count)
        {
            char letter = builder[index];
          
            int position = index + count;
            builder.Remove(index, 1);
            position %= builder.Length + 1;
            builder.Insert(position, letter); 
           
        }

        private static StringBuilder ExtractLetters(string[] words)
        {
            StringBuilder builder = new StringBuilder();
            int maxWordLenght = words.Max(word => word.Length);

            for (int i = 0; i < maxWordLenght; i++)
            {
                foreach (var word in words)
                {
                    int index = word.Length - i - 1;
                    bool condition = index >= 0;
                
                    if (condition)
                    {
                        builder.Append(word[index]);
                    }
                 
                }
            }
            return builder;

        }
    }
}
