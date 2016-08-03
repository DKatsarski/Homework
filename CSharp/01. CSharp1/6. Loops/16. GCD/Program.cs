using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.GCD
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = Math.Max(a, b);
            int d = Math.Min(a, b);
            int leftOver = 0;

            while (d * 2 < c)
            {
                d *= 2;
                leftOver = c - d;
                if (c == d + leftOver)
                {
                    c = d;
                    leftOver =
                }
            }
          
            //while (leftOver * 2 < d)
            //{
            //    leftOver *= 2;
            //}
        }
    }
}
