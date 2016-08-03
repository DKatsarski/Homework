using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _16.Trailing__0_in_N
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = int.Parse(Console.ReadLine());
            BigInteger result = 1;
            while (n != 1)
            {
                result *= n;
                n--;
            }
            string solution = result.ToString();
            int count = 0;
            for (int i = 0; i < solution.Length; i++)
            {
                if (solution[solution.Length - i - 1] == '0')
                {
                    count++;
                }
                else
                {
                    Console.WriteLine(count);
                    return;
                }

            }
            Console.WriteLine(count);
        }
    }
}
