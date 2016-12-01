using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.AllPaths
{
    class Startup
    {
        private const int MatrixSize = 6;

        private static int validPathsCount;

        private static bool[,] matrix =
        {
            { true, false, false, false, true, true },
            { true, true, true, false, false, false },
            { false, false, true, true, true, true },
            { true, true, true, false, false, true },
            { true, true, true, false, false, true },
            { true, true, true, true, true, true },
        };

        private static int goalRowCoordinate = 5;
        private static int goalColCoordinate = 5;

        public static void Main()
        {
            FindPath(0, 0);

            Console.WriteLine(validPathsCount);
        }

        private static void FindPath(int row, int col)
        {
            if (row == goalRowCoordinate && col == goalColCoordinate)
            {
                validPathsCount++;
                return;
            }

            if (row + 1 < MatrixSize && matrix[row + 1, col])
            {

                matrix[row + 1, col] = false;
                FindPath(row + 1, col);
                matrix[row + 1, col] = true;
            }

            if (col + 1 < MatrixSize && matrix[row, col + 1])
            {
                matrix[row, col + 1] = false;
                FindPath(row, col + 1);
                matrix[row, col + 1] = true;
            }

            if (row - 1 >= 0 && matrix[row - 1, col])
            {
                matrix[row - 1, col] = false;
                FindPath(row - 1, col);
                matrix[row - 1, col] = true;
            }

            if (col - 1 >= 0 && matrix[row, col - 1])
            {
                matrix[row, col - 1] = false;
                FindPath(row, col - 1);
                matrix[row, col - 1] = true;
            }
        }
    }
}
