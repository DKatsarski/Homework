using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Digit_As_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] digits = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            if (digits.Contains(input))
            {
                if (input == digits[0])
                {
                    Console.WriteLine("zero");
                }
                if (input == digits[1])
                {
                    Console.WriteLine("one");
                }
                if (input == digits[2])
                {
                    Console.WriteLine("two");
                }
                if (input == digits[3])
                {
                    Console.WriteLine("three");
                }
                if (input == digits[4])
                {
                    Console.WriteLine("four");
                }
                if (input == digits[5])
                {
                    Console.WriteLine("five");
                }
                if (input == digits[6])
                {
                    Console.WriteLine("six");
                }
                if (input == digits[7])
                {
                    Console.WriteLine("seven");
                }
                if (input == digits[8])
                {
                    Console.WriteLine("eight");
                }
                if (input == digits[9])
                {
                    Console.WriteLine("nine");
                }
            }
            else
            {
                Console.WriteLine("not a digit");
            }
        }
    }
}
