using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.GetTheLargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            var list = new List<int>();
            for (int i = 0; i < input.Length; i++)
            {
                list.Add(int.Parse(input[i]));
            }
            Console.WriteLine(list.Max()); 
        }
    }
}
