using System;

namespace _10.Interval
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = 0;

          
            for (int i = a + 1; i < b; i++)
            {

                if (i % 5 == 0)
                {
                    c++;
                }
            }

            Console.WriteLine(c);
        }
    }
}
