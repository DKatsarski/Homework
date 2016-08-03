using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.LargestArea
{
    class Program
    {
        static void Main(string[] args)
        {

            //var input = Console.ReadLine().Split(' ');
            //int n = int.Parse(input[0]);
            //int m = int.Parse(input[1]);

            int[,] arr =
            {
                { 1, 3, 2, 2, 2, 4 },
                { 3, 3, 3, 2, 4, 4 },
                { 4, 3, 1, 2, 3, 3 },
                { 4, 3, 1, 3, 3, 1 },
                { 4, 3, 3, 3, 1, 1 }
            };
                
                
                
                //new int[n, m];
            int counter = 0;
            int bestResult = int.MinValue;

            // fill the matrix
            //for (int row = 0; row < arr.GetLength(0); row++)
            //{
            //    string[] values = (Console.ReadLine().Split(' '));
            //    for (int col = 0; col < arr.GetLength(1); col++)
            //    {

            //        arr[row, col] = int.Parse(values[col]);

            //    }

            //}


            //search for matches
            for (int row = 0; row < arr.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < arr.GetLength(1) - 1; col++) // GetLenght - 2 -> it is - 2 because it should go beyond the array
                {
                    if (arr[row, col] == arr[row, col + 1] || arr[row, col] == arr[row, col - 1] || arr[row, col] == arr[row + 1, col] || arr[row, col] == arr[row - 1, col])
                    {
                        counter++;
                        if (counter > bestResult)
                        {
                            bestResult = counter;
                        }
                    }
                
                }
                counter = 0;
            }

            Console.WriteLine(bestResult);


        }
    }
}
