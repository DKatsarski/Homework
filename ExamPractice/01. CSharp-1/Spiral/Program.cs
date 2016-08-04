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

            int[,] matrix = new int[n, n];
            int matrixRow = 0;
            int matrixCol = 0;
            string direction = "right";
            for (int i = 1; i <= n * n; i++)
            {
                if (direction == "right" && (matrixCol >= n || matrix[matrixRow, matrixCol] != 0))
                {
                    matrixCol--;
                    matrixRow++;
                    direction = "down";
                }
                else if (direction == "down" && (matrixRow >= n || matrix[matrixRow, matrixCol] != 0))
                {
                    matrixRow--;
                    matrixCol--;
                    direction = "left";
                }
                else if (direction == "left" && (matrixCol < 0 || matrix[matrixRow, matrixCol] != 0))
                {
                    matrixCol++;
                    matrixRow--;
                    direction = "up";
                }
                else if (direction == "up" && (matrixRow < 0 || matrix[matrixRow, matrixCol] != 0))
                {
                    matrixRow++;
                    matrixCol++;
                    direction = "right";
                }

                matrix[matrixRow, matrixCol] = i;



                if (direction == "right")
                {
                    matrixCol++;
                }
                else if (direction == "down")
                {
                    matrixRow++;
                }
                else if (direction == "left")
                {
                    matrixCol--;
                }
                else if (direction == "up")
                {
                    matrixRow--;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
               
                }
                Console.WriteLine();

            }

        
        }
    }
}
