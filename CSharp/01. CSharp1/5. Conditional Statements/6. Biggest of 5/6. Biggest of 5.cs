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
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());


            double bigger = Math.Max(a, b);
            double bigger1 = Math.Max(b, c);
            double bigger2 = Math.Max(c, d);
            double bigger3 = Math.Max(d, e);

            double greater = Math.Max(bigger, bigger1);
            double greater1 = Math.Max(bigger2, bigger3);

            double greaterNumber = Math.Max(greater, greater1);
            Console.WriteLine(greaterNumber);

         

        }
    }
}
