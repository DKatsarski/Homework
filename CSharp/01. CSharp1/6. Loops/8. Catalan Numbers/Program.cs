using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _8.Catalan_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger twoTimesN = 2 * n;
            BigInteger nPlusOne = n + 1;
            BigInteger dividerN = 1;
            BigInteger dividerNONE = 1;
            BigInteger dividerTwoTimesN = 1;
            if (n == 0)
            {
                Console.WriteLine(1);
                return;
            }

            while (twoTimesN != 1)
            {
                dividerTwoTimesN *= twoTimesN;
                twoTimesN--;
            }
            while (nPlusOne != 1)
            {
                dividerNONE *= nPlusOne;
                nPlusOne--;
            }
            while (n != 1)
            {
                dividerN *= n;
                n--;
            }

            BigInteger result = dividerTwoTimesN / (dividerNONE * dividerN);
            Console.WriteLine(result);


        }
    }
}
