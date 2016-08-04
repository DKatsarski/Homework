using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Trails_3D
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] xyz = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int x = xyz[0];
            int y = xyz[1];
            int z = xyz[2];
            int rows = y;
            int cols = 2 * (x + z);
            bool[,] visited = new bool[rows, cols];
            string redMoves = TransformMoves(Console.ReadLine());
            string blueMoves = TransformMoves(Console.ReadLine());







        }

        private static string TransformMoves(string v)
        {
            throw new NotImplementedException();
        }
    }
}
