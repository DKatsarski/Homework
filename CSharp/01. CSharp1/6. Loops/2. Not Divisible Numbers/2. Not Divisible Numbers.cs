﻿using System;

namespace _2.Not_Divisible_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    Console.Write("{0} ", i);
                }

               
            }
            Console.ReadLine();
        }   
    }
}
