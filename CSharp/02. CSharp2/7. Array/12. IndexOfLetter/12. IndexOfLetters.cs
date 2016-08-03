using System;

namespace _12.IndexOfLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = new char[26];
            int counter = -1;
            for (int i = 97; i < arr.Length + 97; i++)
            {
                counter++;
                arr[counter] = (char)i;
            }

            string input = Console.ReadLine();
            input = input.ToLower();
            for (int i = 0; i < input.Length; i++)
            {
                char letter = input[i];
                Console.WriteLine(Array.IndexOf(arr, letter));
            }
        }
    }
}
