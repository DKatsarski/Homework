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
            int Редове = 5;
            int Колони = 10;
            char[,] игрално_поле = new char[Редове, Колони];

            for (int i = 0; i < Редове; i++)
            {
                for (int j = 0; j < Колони; j++)
                {
                    игрално_поле[i, j] = '-';
                }
            }

            List<int> r3 = new List<int>();
            while (r3.Count < 15)
            {
                Random random = new Random();
                int asfd = random.Next(50);
                if (!r3.Contains(asfd))
                {
                    r3.Add(asfd);
                }
            }

            foreach (int i2 in r3)
            {
                int kol = (i2 / Колони);
                int red = (i2 % Колони);
                if (red == 0 && i2 != 0)
                {
                    kol--;
                    red = Колони;
                }
                else
                {
                    red++;
                }
                игрално_поле[kol, red - 1] = '*';
            }

            return игрално_поле;
        }
    }
}
