using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Extract_sentences
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: everything
            string wordToSearch = Console.ReadLine();
            string textToSearchFrom = Console.ReadLine();
            string dot = ".";
            int indexOfDot = textToSearchFrom.IndexOf(dot);
            int indexOfWordToSearch = textToSearchFrom.IndexOf(wordToSearch);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < textToSearchFrom.Length; i++)
            {
                if (i == indexOfDot)
                {

                    indexOfDot = textToSearchFrom.IndexOf(dot, indexOfDot + 1);
                    indexOfWordToSearch = textToSearchFrom.IndexOf(wordToSearch, indexOfWordToSearch + 1);
                   // i += 1;
                }


                if (indexOfWordToSearch < indexOfDot)
                {
                 
                     sb.Append(textToSearchFrom[i]);
                   
                    
                }
            }
            Console.Write(sb);


           





        }
    }
}
