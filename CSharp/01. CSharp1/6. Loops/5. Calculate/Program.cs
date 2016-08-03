
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal x = decimal.Parse(Console.ReadLine());
            decimal result = 0;
            decimal factorial = 1;
            decimal power = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                power = Power(x, i);

                result += factorial / power;
            }

            Console.WriteLine("{0:F5}", result + 1);
        }

        public static decimal Power(decimal x, decimal power)
        {
            decimal result = 1;
            for (int i = 1; i <= power; i++)
            {
                result *= x;
            }
            return result;
        }
    }
}