using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.AppearanceCunt
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine()
                .Trim(' ')
                .Split(' ')
                .Select(x => int.Parse(x))
                .ToArray();

             int numberToFind = int.Parse(Console.ReadLine());

        
            Console.WriteLine(Counter(arr, numberToFind));



        }

        public static int Counter(int[] arr, int numberToFind)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (numberToFind == arr[i])
                {
                    counter++;
                }
            }
            return counter;
        }
 

    }
}
