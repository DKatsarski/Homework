using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.ArrangeArray
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

            

            Array.Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.ReadLine();
        }
    }
}
