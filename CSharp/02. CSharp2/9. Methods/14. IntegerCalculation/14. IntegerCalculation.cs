using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.IntegerCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine()
                .Split(' ')
                .Select(x => double.Parse(x))
                .ToArray();

            Console.WriteLine(arr.Min());
            Console.WriteLine(arr.Max());
            Console.WriteLine("{0:F2}", arr.Average());
            Console.WriteLine(arr.Sum());
            Console.WriteLine(Product(arr));





        }

         static double Product(double[] arr)
        {
            double count = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                
                count *= arr[i];
                
            }

            return count;

        }
    }
}
