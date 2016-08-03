using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
	

	

namespace _7.Calculate_thirdtime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the bigger number (enter the '49' of TOTO 6/49): ");
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            Console.Write("Enter number to see how many combinations there are with it(enter the '6' of TOTO 6/49): ");
            BigInteger k = BigInteger.Parse(Console.ReadLine());
            BigInteger helper = n - k;
            BigInteger dividerN = 1;
            BigInteger dividerK = 1;
            BigInteger dividerNK = 1;

            while (n != 1)
            {
                dividerN *= n;
                n--;
                while (k != 1)
                {
                    dividerK *= k;
                    k--;
                
                }
            }
            while (helper != 1)
            {
                dividerNK *= helper;
                helper--;
            }

            BigInteger result = dividerN / (dividerK * dividerNK);
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
