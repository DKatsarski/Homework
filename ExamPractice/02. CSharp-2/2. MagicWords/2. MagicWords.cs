using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.MagicWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var words = new List<string>();
            for (int i = 0; i < n; i++)
            {
                words.Add(Console.ReadLine());
            }
            // reorder
            for (int i = 0; i < n; i++)
            {

                // i - dumata s koqto rabotim se namira na tozi index
                var word = words[i];
                // len(w0) % (n+1) - nowiq index
                var newIndex = word.Length % (n + 1);

                words.Insert(newIndex, word);
                if (newIndex < i)
                {
                    words.RemoveAt(i + 1);
                }
                else
                {
                    words.RemoveAt(i);
                }


            }
            //Print
            var longestWord = 0;
            foreach (var word in words)
            {
                longestWord = Math.Max(longestWord, word.Length);
            }

            //var maxLenght = words.Max(x => x.Length);

            var result = new StringBuilder();
            for (int i = 0; i < longestWord; i++)
            {
                foreach (var word in words)
                {
                    if (word.Length > i)
                    {
                        result.Append(word[i]);
                    }
                 
                }
            }
            Console.WriteLine(result.ToString());



        }
    }
}
