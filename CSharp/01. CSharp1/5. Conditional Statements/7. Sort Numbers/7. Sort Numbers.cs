using System;

namespace _7.Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double bigger = Math.Max(a, b);
            double bigger1 = Math.Max(b, c);

            double bigger2 = Math.Max(bigger, bigger1);
            double middle = Math.Min(bigger, bigger1);

            double smallest = Math.Min(a, b);
            double smallest1 = Math.Min(b, c);
            double smallestNumber = Math.Min(smallest, smallest1);

            if (middle == bigger2)
            {
                Console.Write("{0} {1} {2}", bigger2, smallestNumber, smallestNumber);
                Console.ReadLine();
            }
            else if (middle == smallestNumber)
            {
                Console.Write("{0} {1} {2}", bigger2, smallestNumber, smallestNumber);
                Console.ReadLine();
            }
            else
            {
                {
                    Console.Write("{0} {1} {2}", bigger2, middle, smallestNumber);
                    Console.ReadLine();
                }
            }
         

        }
    }
}
