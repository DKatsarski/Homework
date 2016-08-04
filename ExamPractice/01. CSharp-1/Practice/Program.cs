using System;
namespace Practice
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
            double biggerNumber = Math.Max(bigger, bigger1);

            double smaller = Math.Min(a, b);
            double smaller1 = Math.Min(b, c);
            double smallestNumber = Math.Min(smaller, smaller1);

            double arithmeticMean = (a + b + c) / 3;

            Console.WriteLine("{0}", biggerNumber);
            Console.WriteLine("{0}", smallestNumber);
            Console.WriteLine("{0:F2}", arithmeticMean);


        }
    }
}
