using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireInTheMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 8; //int.Parse(Console.ReadLine());

            char dots = '.';
            char nets = '#';
            char dashLeft = '\\';
            char dashRight = '/';
            int width = n;
            int height = n + (width / 2 - 1);
           
            int middle = n / 2;
            int one = 1;
            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                   
                    if (row == height - n / 2 - 1)
                    {
                        Console.Write('-');
                    }
                    else if (row + col == height && row == height - n / 2)   //here i draw right diagonal
                    {
                        Console.Write(dashRight);
                    }
                    else if (row + col == height + one && row > height - n / 2 - 1 && col >= middle   )   //here i draw right diagonal
                    {
                        Console.Write(dashRight);
                       
                    }
                    else if (row + col == height + 1 && row > height - n / 2 - 1 && col >= middle)   //here i draw right diagonal
                    {
                        Console.Write(dashRight);
             
                    }
                    else if (row + col == height + 2 && row > height - n / 2 - 1 && col >= middle)   //here i draw right diagonal
                    {
                        Console.Write(dashRight);

                    }
                    else if (row + col == height + 3 && row > height - n / 2 - 1 && col >= middle)   //here i draw right diagonal
                    {
                        Console.Write(dashRight);

                    }
                    //else if (row + col > height && col >= middle && row > height - n / 2 - 1)   //here i draw right diagonal
                    //{
                    //    Console.Write(dashRight);
                    //}
                    //else if (row + col > height && col >= middle && row > height - n / 2 - 1)   //here i draw right diagonal
                    //{
                    //    Console.Write(dashRight);
                    //}








                    else if (col - row == -(n / 2) && row == height - n / 2)
                    {
                        Console.Write(dashLeft);
                    }
                    else
                    {
                        Console.Write(dots);
                    }
                    //tuk si uwelichawam diagonala
                 
                }
                one++;
                Console.WriteLine();
               
            }
        }
    }
}
