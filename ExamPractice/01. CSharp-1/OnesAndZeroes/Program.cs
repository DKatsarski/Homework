using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnesAndZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int fieldSize = n * 2 - 1;
            int mid = n - 1;

            char empty = ' ';
            char top = '/';
            char edge = ':';
            char side = 'X';

            for (int row = 0; row < fieldSize; row++)
            {
                for (int col = 0; col < fieldSize; col++)
                {
                    if (col == 0 && row >= mid || col == mid && row >= mid || col == fieldSize - 1 && row <= mid || col >= mid && row == 0 || col <= mid && row == mid || col <= mid && row == fieldSize - 1 || col + row == mid || col + row == fieldSize - 1 + mid || row + col == fieldSize - 1 && row <= mid)
                    {
                        Console.Write(edge);
                    }
                    else if (col > mid && col + row < fieldSize - 1 + mid && col + row >= fieldSize - 1)
                    {
                        Console.Write(side);
                    }
                    else if (row < mid && row + col >= mid)
                    {
                        Console.Write(top);
                    }
                    else
                    {
                        Console.Write(empty);
                    }

                   
                }
                Console.WriteLine();
            }

        }
    }
}
