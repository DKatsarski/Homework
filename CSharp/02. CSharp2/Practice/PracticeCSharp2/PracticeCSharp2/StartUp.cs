using Bazik;
using School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp2
{
    public class PracticeCSharp2
    {
        static void Main()
        {

            int n = Convert.ToInt32(Console.ReadLine());

            int[][] arr = new int[n][];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int test = diagonalDifference(arr);

            Console.WriteLine(test);
        }

        static int diagonalDifference(int[][] arr)
        {

            int sumOfLeftToRightDiagonals = 0;
            int sumOfRightToLeftDiagonals = 0;
            int result = 0;

            int oppositeRow = 0;
            int oppositeCol = 0;

            int indexDropperCol = 1;


            for (int row = 0; row < arr.GetLength(0); row++)
            {
                int test = arr.GetLength(0);

                oppositeRow = row;

                for (int col = 0; col < arr[row].Length; col++)
                {
                    oppositeCol = arr[row].Length - indexDropperCol;

                    if (row == col)
                    {
                        sumOfLeftToRightDiagonals += arr[row][col];
                    }

                    if ((oppositeRow + oppositeCol == arr[row].Length - 1))
                    {
                        sumOfRightToLeftDiagonals += arr[row][oppositeCol];
                    }

                    indexDropperCol += 1;
                }

                indexDropperCol = 1;

            }

            result = Math.Abs(sumOfLeftToRightDiagonals - sumOfRightToLeftDiagonals);

            return result;
        }

    }
}
