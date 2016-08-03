using System;

namespace _2.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {

            //Read line, and split it by whitespace into an array of strings
            string[] tokens = Console.ReadLine().Split(' ');

            //Parse element 0
            int a = int.Parse(tokens[0]);

            //Parse element 1
            int b = int.Parse(tokens[1]);

            int[,] arr = new int[a, b];

            int sum = 0;
            int bestSum = int.MinValue;
            //Fill the matrix
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                string[] values = (Console.ReadLine().Split(' '));
                for (int col = 0; col < arr.GetLength(1); col++)
                {

                    arr[row, col] = int.Parse(values[col]);

                }

            }

            //search the best sum square
            for (int row = 0; row < arr.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < arr.GetLength(1) - 2; col++) // GetLenght - 2 -> it is - 2 because it should go beyond the array
                {
                    sum = arr[row, col] + arr[row, col + 1] + arr[row, col + 2] +
                        arr[row + 1, col] + arr[row + 1, col + 1] + arr[row + 1, col + 2] +    //summing the subarrayrr
                        arr[row + 2, col] + arr[row + 2, col + 1] + arr[row + 2, col + 2];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                    }
                }
            }

            Console.WriteLine(bestSum);
  
        }

    }
}
