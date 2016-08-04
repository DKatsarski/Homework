using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] digits = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                string[] currentLine = Console.ReadLine().Split(' ');
                for (int col = 0; col < currentLine.Length; col++)
                {
                    digits[row, col] = int.Parse(currentLine[col]);
                }
            }


        }
    }
}
