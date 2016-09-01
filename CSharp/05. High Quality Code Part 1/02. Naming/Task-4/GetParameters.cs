using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    public static class GetParameters
    {
        public static char[,] CreatePlayingField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        public static char[,] SetBombs()
        {
            int rows = 5;
            int cols = 10;
            char[,] playingField = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    playingField[i, j] = '-';
                }
            }

            List<int> bombsOnField = new List<int>();
            while (bombsOnField.Count < 15)
            {
                Random random = new Random();
                int bomb = random.Next(50);
                if (!bombsOnField.Contains(bomb))
                {
                    bombsOnField.Add(bomb);
                }
            }

            foreach (int bomb in bombsOnField)
            {
                int col = (bomb / cols);
                int row = (bomb % cols);
                if (row == 0 && bomb != 0)
                {
                    col--;
                    row = cols;
                }
                else
                {
                    row++;
                }
                playingField[col, row - 1] = '*';
            }

            return playingField;
        }
    }
}
