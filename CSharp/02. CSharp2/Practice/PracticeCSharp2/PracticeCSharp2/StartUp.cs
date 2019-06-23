namespace PracticeCSharp2
{
    using System.Collections.Generic;
    using System;
    using System.Linq;
    using System.Text;
    using System.Runtime.InteropServices;

    public class StartUp
    {
        static void Main()
        {
            var a = new int[10, 10];

            for (int row = 0; row < a.GetLength(0); row++)
            {
                for (int col = 0; col < a.GetLength(1); col++)
                {
                    a[row, col] = col;
                }
            }

            for (int row = 0; row < a.GetLength(0); row++)
            {
                for (int col = 0; col < a.GetLength(1); col++)
                {
                    Console.Write(a[row, col]);
                }
                Console.WriteLine();
            }

            var st = new StringBuilder();

            st.Append(a.GetUpperBound(0));

            Console.WriteLine(st);

            for (int row = 0; row < a.GetLength(0); row++)
            {
                for (int col = 0; col < a.GetLength(1); col++)
                {
                    
                }
            }
        }

    }
}

