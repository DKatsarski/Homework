using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class StartUp
    {
        /*
         Write a program that reads from the console a sequence of positive integer numbers.

            The sequence ends when empty line is entered.
            Calculate and print the sum and average of the elements of the sequence.
            Keep the sequence in List<int>. 
         */
        static void Main()
        {
            List<int> list = new List<int>();

            while (true)
            {
                var n = Console.ReadLine();
                if (string.IsNullOrEmpty(n))
                {
                    break;
                }

                list.Add(int.Parse(n));
            }
            var sum = list.Sum();
            double average = list.Average();
            Console.WriteLine(sum);
            Console.WriteLine("{0:F2}", average);
        }
    }
}
