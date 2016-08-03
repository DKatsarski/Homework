using System;
using System.Collections.Generic;
using System.Linq;

namespace _23.Series_of_letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<char> list = new List<char>();
            char holder = ' ';
            bool tester = false;

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    tester = true;
                }
                else if (input[i] != input[i + 1])
                {
                    holder = input[i];
                    list.Add(holder);
                    if (input[i+1] == input[input.Length - 1])
                    {
                        holder = input[input.Length - 1];
                        list.Add(holder);
                    }
                }
            }

            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list.ElementAt(i) == list.ElementAt(i + 1))
                {
                    list.RemoveAt(i);
                }
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list.ElementAt(i));
            }
            Console.ReadLine();
        }
    }
}
