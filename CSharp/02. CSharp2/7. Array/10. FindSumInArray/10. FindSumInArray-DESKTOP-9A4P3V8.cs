using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.FindSumInArray
{
    class Program
    {
        static void Main(string[] args)
        {
           // int r = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            int[] arr = { 4, 3, 1, 4, 2, 5, 8 };//new int[r];
            int omg = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                int sequence = arr[i];
                for (int j = i - 1; j >= 0; j--)
                {
                    sequence += arr[j];
                    if (sequence == s)
                    {
                        
                        while (omg != s)
                        {
                            Console.Write("{0} ", arr[i]);
                            omg += arr[i];
                            i--;
                          
                        }
                        break;
                    }
                }
            }

        }
    }
}
