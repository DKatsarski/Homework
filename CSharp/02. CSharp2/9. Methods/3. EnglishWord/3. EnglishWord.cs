﻿using System;

namespace _3.EnglishWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(EnglisWord(input));
        }

        static string EnglisWord(string lastDigit)
        {

            lastDigit = lastDigit[lastDigit.Length - 1].ToString();
            switch (lastDigit)
            {
                case "0": lastDigit = "zero"; break;
                case "1": lastDigit = "one"; break;
                case "2": lastDigit = "two"; break;
                case "3": lastDigit = "three"; break;
                case "4": lastDigit = "four"; break;
                case "5": lastDigit = "five"; break;
                case "6": lastDigit = "six"; break;
                case "7": lastDigit = "seven"; break;
                case "8": lastDigit = "eight"; break;
                case "9": lastDigit = "nine"; break;
               
                default:
                    break;
            }

            return lastDigit;

        }
    }
}
