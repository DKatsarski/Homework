using System;

namespace Sum_Of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double b = 0;

            for (int i = 0; i < n ; i++)
            {
                double a = double.Parse(Console.ReadLine());
                b += a;
            }

            Console.WriteLine(b);
        }
    }
}
