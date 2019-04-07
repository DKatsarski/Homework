using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_06.String_length
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads from the console a string of maximum 20 characters.If the length of the string is less than 20, the rest of the characters should be filled with *.
            //Print the result string into the console.Write a program that reads from the console a string of maximum 20 characters.If the length of the string is less than 20, the rest of the characters should be filled with *.
            //Print the result string into the console.

            //substring - index to 20 

            char[] arr = new char[20];
            int counterPosition = 0;
            int counterLenght = 0;
            char currentKey = Char.MinValue;
            char homo = Char.MaxValue;

            do
            {
                currentKey = Console.ReadKey().KeyChar;

                if (currentKey == (char)ConsoleKey.Enter)
                {
                    homo = currentKey;
                }
                else
                {
                    arr[counterPosition] = currentKey;

                    counterLenght++;
                    counterPosition++;
                }



            } while (homo != (char)ConsoleKey.Enter);

            if (counterPosition != 20)
            {
                for (int i = counterPosition; i < arr.Length; i++)
                {
                    arr[i] = '*';
                }

            }



            Console.WriteLine();
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }
    }
}