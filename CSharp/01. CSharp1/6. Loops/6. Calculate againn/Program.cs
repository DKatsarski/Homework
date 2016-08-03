using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _5.Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = int.Parse(Console.ReadLine());
            BigInteger k = int.Parse(Console.ReadLine());
            BigInteger result = 1;
            BigInteger devider = 1;
            BigInteger trueNumber = 0;
            while (n != 1)
            {
                result *= n;
                n--;
                while (k != 1)
                {
                    devider *= k;
                    k--;
                }
               
            }
            trueNumber = result / devider;
            Console.WriteLine("{0}", trueNumber);
        }
    }
}
