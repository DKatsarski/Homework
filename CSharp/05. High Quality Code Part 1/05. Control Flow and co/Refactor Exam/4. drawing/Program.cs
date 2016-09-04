using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.drawing
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());
            char space = ' ';
            int height = input;
            int width = input - 1;
           
            
            // ushi
                        


       
            Console.Write(space);
            Console.Write(symbol);
            Console.Write(new string(space, (input / 4) - 1));
            Console.Write(symbol);
           
            Console.WriteLine();



            // glawa

            for (int row = 0; row < ((input / 4) - 1); row++)
            {
              
                    Console.Write(space);
                    Console.Write(new string(symbol, (input / 4) - 1  + 2));
                 

                Console.WriteLine();

            }

            //wrat

            for (int row = 0; row < (input / 4) - 1; row++)
            {
                Console.Write(new string(space, 2));
                Console.Write(new string(symbol, (input / 4) - 1));
                Console.WriteLine();
            }

            //tqlo

            for (int row = 0; row < ((input / 4) - 1); row++)
            {

                Console.Write(space);
                Console.Write(new string(symbol, (input / 4) - 1 + 2));
                Console.WriteLine();

            }


            //tqlo i opashka

            Console.Write(space);
            Console.Write(new string(symbol, (input / 4) - 1 + 2));
            Console.Write(new string(space, 3));
            Console.Write(new string(symbol, (input / 4) - 1 + 1));    // TUK MOJE DA IMAM PROBLEM !!!
            Console.WriteLine();


            // predposledna chast 

            for (int row = 0; row < (input / 4) - 1 + 2; row++)
            {
                Console.Write(new string(symbol, (input / 4) - 1 + 4));
                Console.Write(new string(space, 2));
                Console.Write(symbol);
                Console.WriteLine();
            }


            // poredposleden red 

            Console.Write(new string(symbol, (input / 4) - 1 + 4));
            Console.Write(space);
            Console.Write(new string(symbol, 2));
            Console.WriteLine();

            // posleden red
            Console.Write(space);
            Console.Write(new string(symbol, (input / 4) - 1 + 5));
            Console.WriteLine();

        }
    }
}
