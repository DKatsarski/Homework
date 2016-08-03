using System;

namespace Sum_Of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double b = 1;
            double a = 0;
            double c = 0;

            if (n <= 1)
            {
                Console.Write("0");
                Console.ReadLine();
            }
            else if (n == 2)
            {
                Console.Write("0, 1");
                Console.ReadLine();
            }
            else
            {

                Console.Write("0, 1");

                
            for (int i = 0; i < n - 2; i++)
            {

                c = a + b;
                Console.Write(", {0}", c);
                a = b;
                b = c;
            }
                Console.ReadLine();
            }
        }
    }
}
