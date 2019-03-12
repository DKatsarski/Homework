using School;
using System;

namespace Problem_11.Numbers_in_Interval
{
    public class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var printNumbers = string.Empty;

            for (int i = 0; i < n + 1; i++)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    printNumbers += i.ToString() + " ";
                }
            }

            Console.WriteLine(printNumbers);
        }
    }
}