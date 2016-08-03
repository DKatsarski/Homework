using System;
using System.Numerics;

namespace _02_Maximal_Sum
{
    class MaximalSum
    {
        static void Main()
        {
            string n = Console.ReadLine();
            BigInteger[] arr = new BigInteger[n.Length];
            BigInteger sum = 0;
            
            
            for (int index = 0; index < n.Length; index++)
            {
                arr[index] = (n[n.Length - index - 1] - '0');
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 1)
                {
                    sum += BigInteger.Pow(2, i);
                }
                

            }
            Console.WriteLine(sum);

        }
    }
}