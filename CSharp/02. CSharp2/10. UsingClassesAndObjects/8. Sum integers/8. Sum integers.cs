using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Sum_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Trim(' ')
                .Split(' ')
                .Select(x => int.Parse(x))
                .ToArray();
            int result = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
            }

            Console.WriteLine(result);


        }
    }
}
