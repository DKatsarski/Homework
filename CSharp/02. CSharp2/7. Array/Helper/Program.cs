using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            bool verdad = true;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int x = int.Parse(Console.ReadLine());

            Array.Sort(arr);

            while (verdad)
            {
                if (arr[arr.Length / 2] >= x)
                {
                    if (arr[arr.Length / 2] == x)
                    {
                        break;
                    }
                    arr = arr.Take(arr.Length / 2).ToArray();
                }
                else if (arr[arr.Length / 2] < x)
                {

                    if (arr[arr.Length / 2] == x)
                    {
                        break;
                    }
                    arr = arr.Skip(arr.Length / 2).ToArray();
                }
            }

            Console.WriteLine(arr[arr.Length / 2]);
        }
    }

}
