using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper.Contracts
{
    public interface IDrawer
    {
        void DrawBoard(char[,] board);
    }
}
