using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.String_length
{
    class Program
    {
        static void Main(string[] args)
        {
            string stars = new string('*', 20);
            string input = Console.ReadLine();
            List<char> list = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                list.Add(input[i]);
            }

            for (int i = input.Length; i < stars.Length; i++)
            {
                list.Add(stars[i]); 
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list.ElementAt(i));
            }
            Console.ReadLine();
        }
    }
}
