using System;

namespace _7._1.MultidimentionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string letter = Console.ReadLine();
            int[,] matrix = new int[n, n];
            int matrixRow = 0;
            int matrixCol = 0;
            letter = letter.ToLower();


            if (letter == "d")
            {
                MatrixD(n, matrix, ref matrixRow, ref matrixCol);
            }
            else if (letter == "c")
            {
                matrixRow = LetterC(n, matrix, ref matrixCol);
            }
            else if (letter == "a")
            {
                MatrixA(n, matrix, ref matrixRow, ref matrixCol);
            }
            else if (letter == "b")
            {
                MatrixB(n, matrix, ref matrixRow, ref matrixCol);
            }





        }







        private static void MatrixB(int n, int[,] matrix, ref int matrixRow, ref int matrixCol)
        {
            string direction = "down";
            for (int i = 1; i <= n * n; i++)
            {
                if (direction == "down" && (matrixRow >= n || matrix[matrixRow, matrixCol] != 0))
                {
                    matrixRow--;
                    matrixCol++;
                    direction = "up";

                }
                else if (direction == "up" && (matrixRow < 0 || matrix[matrixRow, matrixCol] != 0))
                {
                    matrixRow++;
                    matrixCol++;
                    direction = "down";
                }


                matrix[matrixRow, matrixCol] = i;

                if (direction == "down")
                {
                    matrixRow++;
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
                    Console.Write(matrix[i, j] + (j + 1 < n ? " " : ""));
                }
                Console.WriteLine();
            }
        }



        private static void MatrixA(int n, int[,] matrix, ref int matrixRow, ref int matrixCol)
        {
            string direction = "down";
            for (int i = 1; i <= n * n; i++)
            {
                if (direction == "down" && (matrixRow >= n || matrix[matrixRow, matrixCol] != 0))
                {
                    matrixRow = 0;
                    matrixCol++;
                    direction = "down";

                }


                matrix[matrixRow, matrixCol] = i;

                if (direction == "down")
                {
                    matrixRow++;
                }
            }


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + (j + 1 < n ? " " : ""));
                }
                Console.WriteLine();
            }
        }

        private static int LetterC(int n, int[,] matrix, ref int matrixCol)
        {
            int matrixRow;
            string direction = "up";
            int counter = n - 2;
            int colCounter = 1;
            matrixRow = n - 1;
            for (int i = 1; i <= n * n; i++)
            {
                if (direction == "top" && (matrixRow >= n || matrix[matrixRow, matrixCol] != 0))
                {
                    matrixRow--;
                    matrixCol++;
                    direction = "right";

                }
                else if (direction == "right" && (matrixCol >= n || matrixRow >= n))
                {
                    if (counter >= 0)
                    {
                        matrixCol = 0;
                        matrixRow = counter;
                        direction = "right";
                        counter--;
                    }
                    else
                    {
                        matrixRow = 0;
                        matrixCol = colCounter;
                        direction = "top";
                    }

                }


                matrix[matrixRow, matrixCol] = i;

                if (direction == "top")
                {
                    matrixCol++;
                    matrixRow++;
                    colCounter++;
                    direction = "right";

                }
                else if (direction == "right")
                {
                    matrixCol++;
                    matrixRow++;
                }
                else if (direction == "up")
                {
                    if (matrixRow == n - 1)
                    {
                        matrixRow--;
                    }

                    counter--;
                    direction = "right";

                }


            }


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + (j + 1 < n ? " " : ""));
                }
                Console.WriteLine();
            }

            return matrixRow;
        }





        private static void MatrixD(int n, int[,] matrix, ref int matrixRow, ref int matrixCol)
        {
            string direction = "down";
            for (int i = 1; i <= n * n; i++)
            {
                if (direction == "down" && (matrixRow >= n || matrix[matrixRow, matrixCol] != 0))
                {
                    matrixRow--;
                    matrixCol++;
                    direction = "right";

                }
                else if (direction == "right" && (matrixCol >= n || matrix[matrixRow, matrixCol] != 0))
                {
                    matrixCol--;
                    matrixRow--;
                    direction = "up";
                }
                else if (direction == "up" && (matrixRow < 0 || matrix[matrixRow, matrixCol] != 0))
                {
                    matrixRow++;
                    matrixCol--;
                    direction = "left";
                }
                else if (direction == "left" && (matrixCol < 0 || matrix[matrixRow, matrixCol] != 0))
                {
                    matrixCol++;
                    matrixRow++;
                    direction = "down";
                }

                matrix[matrixRow, matrixCol] = i;

                if (direction == "down")
                {
                    matrixRow++;
                }
                else if (direction == "right")
                {
                    matrixCol++;
                }
                else if (direction == "up")
                {
                    matrixRow--;
                }
                else if (direction == "left")
                {
                    matrixCol--;
                }



            }


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + (j + 1 < n ? " " : ""));
                }
                Console.WriteLine();
            }
        }
    }
}
