﻿namespace Minesweeper
{
    using System;

    public static class Drawer
    {
        public static void DrawBoard(char[,] board)
        {
            int boardRowLength = board.GetLength(0);
            int boardColLength = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < boardRowLength; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < boardColLength; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine("   ---------------------\n");
        }

        public static void UpdateSelectedPoint(char[,] field, char[,] bombs, int row, int col)
        {
            char bombsCount = BombSetter.PlaceBombsOnTheirPositions(bombs, row, col);
            bombs[row, col] = bombsCount;
            field[row, col] = bombsCount;
        }
    }
}
