using System;

namespace Task3
{
    class WalkInMatrica
    {
        static void ChangeDirection(ref int dx, ref int dy)
        {
            int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };
            int currentDirection = 0;
            int len = dirX.Length;

            for (int i = 0; i < len; i++)
            {
                if (dirX[i] == dx && dirY[i] == dy)
                {

                    currentDirection = i;
                    break;
                }
            }

            if (currentDirection == 7)
            {
                dx = dirX[0]; dy = dirY[0];
                return;
            }

            dx = dirX[currentDirection + 1];
            dy = dirY[currentDirection + 1];
        }

        static bool CheckIfNextCellIsEmpty(int[,] matrix, int row, int col)
        {
            int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };

            for (int i = 0; i < 8; i++)
            {
                if (row + dirX[i] >= matrix.GetLength(0) || row + dirX[i] < 0)
                {
                    dirX[i] = 0;
                }

                if (col + dirY[i] >= matrix.GetLength(0) || col + dirY[i] < 0)
                {
                    dirY[i] = 0;
                }
            }

            for (int i = 0; i < 8; i++)
            {
                if (matrix[row + dirX[i], col + dirY[i]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        // Tuk nai weroqtno shte trqbwa da naprawq matricata w masiw. ne wijdam na pryw pogled, che trqbwa da e matrica. 
        static void FindEmptyCell(int[,] matrix, out int row, out int col)
        {
            row = 0;
            col = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        row = i; col = j;
                        return;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            //Console.WriteLine( "Enter a positive number " );
            //string input = Console.ReadLine(  );
            //int n = 0;
            //while ( !int.TryParse( input, out n ) || n < 0 || n > 100 )
            //{
            //    Console.WriteLine( "You haven't entered a correct positive number" );
            //    input = Console.ReadLine(  );
            //}
            int n = 3;
            int[,] matrix = new int[n, n];
            int step = n, k = 1, i = 0, j = 0, dx = 1, dy = 1;

            while (true)
            { //malko e kofti tova uslovie, no break-a raboti 100% : )
                matrix[i, j] = k;

                if (!CheckIfNextCellIsEmpty(matrix, i, j))
                {
                    break;
                } // prekusvame ako sme se zadunili

                if (i + dx >= n || i + dx < 0 || j + dy >= n || j + dy < 0 || matrix[i + dx, j + dy] != 0)
                {
                    while ((i + dx >= n || i + dx < 0 || j + dy >= n || j + dy < 0 || matrix[i + dx, j + dy] != 0))
                    {
                        ChangeDirection(ref dx, ref dy);
                    }
                }

                i += dx; j += dy; k++;
            }

            for (int p = 0; p < n; p++)
            {
                for (int q = 0; q < n; q++)
                {
                    Console.Write("{0,3}", matrix[p, q]);
                }

                Console.WriteLine();
            }

            FindEmptyCell(matrix, out i, out j);
            if (i != 0 && j != 0)
            { // taka go napravih, zashtoto funkciqta ne mi davashe da ne si definiram out parametrite
                dx = 1; dy = 1;

                while (true)
                { //malko e kofti tova uslovie, no break-a raboti 100% : )
                    matrix[i, j] = k;

                    if (!CheckIfNextCellIsEmpty(matrix, i, j))
                    {
                        break;
                    }// prekusvame ako sme se zadunili

                    if (i + dx >= n || i + dx < 0 || j + dy >= n || j + dy < 0 || matrix[i + dx, j + dy] != 0)
                    {

                        while ((i + dx >= n || i + dx < 0 || j + dy >= n || j + dy < 0 || matrix[i + dx, j + dy] != 0)) ChangeDirection(ref dx, ref dy);
                        i += dx; j += dy; k++;
                    }
                }
            }

            for (int pp = 0; pp < n; pp++)
            {
                for (int qq = 0; qq < n; qq++)
                {
                    Console.Write("{0,3}", matrix[pp, qq]);
                }

                Console.WriteLine();
            }
        }
    }
}
