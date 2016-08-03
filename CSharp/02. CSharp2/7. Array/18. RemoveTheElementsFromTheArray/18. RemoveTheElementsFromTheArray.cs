using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.RemoveTheElementsFromTheArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            int count = 0;

            int[] arr = { 14, 2, 9, 8, 3, 13, 17, 19, 30, 1 };//new int[n];
            //arr[0] = int.Parse(Console.ReadLine());

            //for (int i = 1; i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            var arrToList = arr.ToList();
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1]  > arr[i] || arr[i] == arr[arr.Length - 1])
                {
                    arrToList.Remove(arr[i - 1]);
                    count++;   
                }
            }
            arr = arrToList.ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine(count);
        }
    }
}
