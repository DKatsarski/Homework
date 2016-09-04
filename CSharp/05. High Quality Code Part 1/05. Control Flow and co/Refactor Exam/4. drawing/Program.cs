namespace _4.DrawingCat
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int catSize = int.Parse(Console.ReadLine());
            char drawingSymbol = char.Parse(Console.ReadLine());
            char space = ' ';
            int catHeight = catSize;
            int catWidth = catSize - 1;

            // Draw ears
            Console.Write(space);
            Console.Write(drawingSymbol);
            Console.Write(new string(space, (catSize / 4) - 1));
            Console.Write(drawingSymbol);
            Console.WriteLine();

            // Draw head
            for (int row = 0; row < ((catSize / 4) - 1); row++)
            {
                Console.Write(space);
                Console.Write(new string(drawingSymbol, (catSize / 4) - 1 + 2));
                Console.WriteLine();
            }

            // Draw Neck
            for (int row = 0; row < (catSize / 4) - 1; row++)
            {
                Console.Write(new string(space, 2));
                Console.Write(new string(drawingSymbol, (catSize / 4) - 1));
                Console.WriteLine();
            }

            // Draw body
            for (int row = 0; row < ((catSize / 4) - 1); row++)
            {
                Console.Write(space);
                Console.Write(new string(drawingSymbol, (catSize / 4) - 1 + 2));
                Console.WriteLine();
            }
            
            // Draw body and tale
            Console.Write(space);
            Console.Write(new string(drawingSymbol, (catSize / 4) - 1 + 2));
            Console.Write(new string(space, 3));
            Console.Write(new string(drawingSymbol, (catSize / 4) - 1 + 1)); 
            Console.WriteLine();
            
            // Draw bottom  
            for (int row = 0; row < (catSize / 4) - 1 + 2; row++)
            {
                Console.Write(new string(drawingSymbol, (catSize / 4) - 1 + 4));
                Console.Write(new string(space, 2));
                Console.Write(drawingSymbol);
                Console.WriteLine();
            }
            
            // Draw last two lines of the cat
            Console.Write(new string(drawingSymbol, (catSize / 4) - 1 + 4));
            Console.Write(space);
            Console.Write(new string(drawingSymbol, 2));
            Console.WriteLine();

            // Draw last part
            Console.Write(space);
            Console.Write(new string(drawingSymbol, (catSize / 4) - 1 + 5));
            Console.WriteLine();
        }
    }
}
