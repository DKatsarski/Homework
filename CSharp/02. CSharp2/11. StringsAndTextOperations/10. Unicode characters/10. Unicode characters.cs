using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Unicode_characters
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that converts a string to a sequence of C# Unicode character literals.

            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            foreach (char c in input)
            {
                sb.Append("\\u");
                sb.Append(String.Format("{0:X4}", (int)c));
                
            }
            sb.ToString();
            for (int i = 0; i < sb.Length; i++)
            {
                Console.Write(sb[i]);
            }
            Console.ReadLine();

        }

      
    }
}
