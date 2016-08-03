using System;

namespace _5.Biggest_Of_3
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
            Console.WriteLine(bigger2);
        }
    }
}
