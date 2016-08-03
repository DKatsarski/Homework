using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            arr[0] = int.Parse(Console.ReadLine());
            int currentSum = arr[0];
            int maximalSum = int.MinValue;

            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                currentSum = arr[i];
               
                for (int j = i - 1; j >= 0 ; j--)
                {

                    
                    currentSum += arr[j];
                    
                    if (currentSum > maximalSum)
                    {
                        maximalSum = currentSum;
                    }

                }

            }
            Console.WriteLine(maximalSum);
        }
    }
}
