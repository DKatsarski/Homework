using System;

namespace FourDigits
{
    class FourDigits
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int lastDigit = n % 10;

            int secondToLastVariable = n / 10;
            int secondToLast = secondToLastVariable % 10;

            int thridToLastVariable = n / 100;
            int thridToLast = thridToLastVariable % 10;

            int firstDigitVariable = n / 1000;
            int firstDigit = firstDigitVariable % 10;


            // results
            //sum
            Console.WriteLine(lastDigit + secondToLast + thridToLast + firstDigit);
            //reverse order
            Console.WriteLine("{0}{1}{2}{3}", lastDigit, secondToLast, thridToLast, firstDigit);
            //place the last first
            Console.WriteLine("{0}{1}{2}{3}", lastDigit, firstDigit, thridToLast, secondToLast);
            //exchange the second and the third digits
            Console.WriteLine("{0}{1}{2}{3}", firstDigit, secondToLast, thridToLast, lastDigit);

        }
    }
}
