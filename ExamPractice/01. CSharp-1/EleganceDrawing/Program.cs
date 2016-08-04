using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleganceDrawing
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 6; //int.Parse(Console.ReadLine());

            char dots = '.';
            char star = '*';
            char att = '@';
            int width = input * 3 + 1;
            int hight = input * 2;
            int n = 0;
            int m = 0;

            for (int row = 0; row < input * 2; row++)
            {
                for (int col = 0; col < width; col++)
                {

                    if (row == 0 && col > input && col < input + input || row == hight - 1 && col > input && col < input + input || row < hight - (input / 2) && row >= input / 2 && col == 1 || row < hight - (input / 2) && row >= input / 2 && col == width - 2 /* ot tuk pochwam diagonalite -> */ || row + col == input + 1 + n || row + col == input * 6 - 3 + n && col != width - 1 && row != hight - 1/* ot tuk otricatelnite diagonalite -> */ || row - col == hight + input - 3 + n && row != 0 && row != hight - 1 && col != 0 || col - row == hight - 1 + m && col != width - 1 && row != 0 /* pochwam kliumbite */)
                    {
                        Console.Write(star);
                    }
                    else if ((row == n - 1 || row == n) && (col > 1 && col < width - 2) && (row + col) % 2 == 1)
                    {
                        Console.Write(att);
                    }
                    else
                    {
                        Console.Write(".");
                    }
                 

                }
                n -= 1;
                m++;
                Console.WriteLine();
            }
           
        }
    }
}
