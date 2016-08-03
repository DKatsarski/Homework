using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.SequenceOfMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //input on a single line
            //string[] input = Console.ReadLine().Split(' ');
            //int n = int.Parse(input[0]);
            //int m = int.Parse(input[1]);
            // DIAGONALITE NE RABOTQT DOBRE !!! OUTSIDE OF ARRAY BOUNDERY
            int[,] matrix = {
                {92, 11, 23, 42, 59, 48 },
                { 09, 92, 23, 72, 56, 14 },
                { 17, 63, 92, 46, 85, 95 },
                { 34, 12, 52, 69, 23, 95 },
                { 26, 88, 78, 71, 29, 95 },
                { 26 ,34, 16, 63, 39, 95 }

                };

            //Filing The Matrix
            //for (int row = 0; row < matrix.GetLength(0); row++)
            //{
            //    string[] value = Console.ReadLine().Split(' ');
            //    for (int col = 0; col < matrix.GetLength(1); col++)
            //    {
            //        matrix[row, col] = int.Parse(value[col]);

            //    }
            //}




            //Walking through the colomns

            string direction = "down";
            int counter = 1;
            int bestResult = int.MinValue;
            int colCount = 0;
            int currentRow = 0;


            // walking through the colomns
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 1; row < matrix.GetLength(0); row++)
                {

                    if (matrix[row, col] == matrix[row - 1, col])
                    {
                        counter++;
                        if (counter > bestResult)
                        {
                            bestResult = counter;
                        }

                    }
                    else if (matrix[row, col] != matrix[row - 1, col])
                    {
                        counter = 1;
                    }

                }
                counter = 1;
            }

            //walking through the rows
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 1; c < matrix.GetLength(1); c++)
                {

                    if (matrix[r, c] == matrix[r, c - 1])
                    {
                        counter++;
                        if (counter > bestResult)
                        {
                            bestResult = counter;
                        }

                    }
                    else if (matrix[r, c] != matrix[r, c - 1])
                    {
                        counter = 1;
                    }

                }
                counter = 1;
            }


            //Walking through first diagonals  TODO: Diagonals

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                currentRow = row;
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[currentRow, col] == matrix[currentRow + 1, col + 1])
                    {
                        counter++;

                        if (counter > bestResult)
                        {
                            bestResult = counter;
                        }
                        else if (matrix[currentRow, col] != matrix[currentRow + 1, col + 1])
                        {
                            counter = 1;
                        }

                    }
                    currentRow++;
                }
                counter = 1;

            }

            //above left diagonal       

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                currentRow = 0;
                for (int col = 1 + row; col <= matrix.GetLength(1) - 2; col++)
                {

                    if (matrix[currentRow, col] == matrix[currentRow + 1, col + 1])
                    {
                        counter++;
                        if (counter > bestResult)
                        {
                            bestResult = counter;
                        }

                    }
                    else
                    {
                        bestResult = 1;
                    }
                    currentRow++;
                }

            }





            //above right diagonal


            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                currentRow = 0;
                for (int col = matrix.GetLength(1) - 2 - row; col >= 1; col--)
                {

                    if (matrix[currentRow, col] == matrix[currentRow + 1, col - 1])
                    {
                        counter++;
                        if (counter > bestResult)
                        {
                            bestResult = counter;
                        }

                    }
                    else
                    {
                        counter = 1;
                    }
                    currentRow++;
                }



                Console.WriteLine(bestResult);








                //for (int row = 0; row < n; row++)
                //{
                //    for (int col = 0; col < m; col++)
                //    {
                //        Console.Write(matrix[row, col] + (col < m ? " " : ""));
                //    }
                //    Console.WriteLine();
                //}




            }
        }
    }
}
