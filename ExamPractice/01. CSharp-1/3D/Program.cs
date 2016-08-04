using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 5; //int.Parse(Console.ReadLine());
            int size = input *input - 1;
            string[,] cube = new string[size, size];
            int cubeRow = 0;
            int cubeCol = 0;
            string direction = "right";

            for (int i = 0; i <= size * size; i++)
            {
                cube[cubeRow, cubeCol] = " ";
                if (i == size - input + 1)
                {

                }

            }


            //print here
            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = 0; j < size; j++)
            //    {
            //        Console.Write(cube[i, j]);
            //    }
            //    Console.WriteLine();
            //}



        }
    }
}
