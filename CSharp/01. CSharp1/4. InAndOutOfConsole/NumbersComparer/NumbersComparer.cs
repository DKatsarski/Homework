using System;


namespace NumbersComparer
{
    class NumbersComparer
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double greater = Math.Max(a, b);
            Console.WriteLine(greater);
        }
    }
}
