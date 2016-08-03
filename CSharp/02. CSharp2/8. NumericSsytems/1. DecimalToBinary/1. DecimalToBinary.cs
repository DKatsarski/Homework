using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _1.DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            List<BigInteger> list = new List<BigInteger>();

            while (n != 0)
            {
                if (n % 2 == 1)
                {
                    list.Add(1);
                }
                else if (n % 2 == 0)
                {
                    list.Add(0);
                }

                n /= 2;
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list.ElementAt(list.Count - i - 1));
            }
            Console.ReadLine();
        }
    }
}
