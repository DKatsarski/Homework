using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiral
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] spiral = new int[n,n];

            string direction = "right";
            int currentRow = 0;
            int currentCol = 0;

            for (int i = 1; i <= n * n; i++)
            {
                if (direction == "right" && (currentCol >= n || spiral[currentRow, currentCol] != 0))
                {
                    currentCol--;
                    currentRow++;
                    direction = "down";
                }
                else if (direction == "down" && (currentRow >= n || spiral[currentRow, currentCol] != 0))
                {
                    currentRow--;
                    currentCol--;
                    direction = "left";

                }
                else if (direction == "left" && (currentCol < 0 || spiral[currentRow, currentCol] != 0))
                {
                    currentRow--;
                    currentCol++;
                    direction = "up";

                }
                else if (direction == "up" && (currentRow < 0 || spiral[currentRow, currentCol] != 0))
                {
                    currentRow++;
                    currentCol++;
                    direction = "right";
                }
              
                //tuk se pridawa stojnost na konkretnata kletka
                spiral[currentRow, currentCol] = i;

                if (direction == "right")
                {
                    currentCol++;
                }
                else if (direction == "down")
                {
                    currentRow++;
                }
                else if (direction == "left")
                {
                    currentCol--;
                }
                else if (direction == "up")
                {
                    currentRow--;
                }
            }

            //print matrix
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(spiral[i, j] + " ");
                }
                Console.WriteLine();
            }
          
        }
    }
}
