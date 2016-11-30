﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.CombinationsWithDuplicants
{
    public class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            NestingLoops(n, k);
        }

        public static void NestingLoops(int n, int loopNumber, string vector = "", int counter = 1)
        {
            if (n == 0)
            {
                string p = string.Empty;
                p = Regex.Replace(vector, @"\s+", "");
                

                for (int i = 0; i < p.Length - 1; i++)
                {
                    if (p[i] >= p[i + 1])
                    {
                        return;
                    }
                }
                Console.Write("(" + vector.Trim() + "), ");
                return;
            }

            NestingLoops(n - 1, loopNumber, vector + " " + (counter));

            for (int i = 0; i < loopNumber - 1; i++)
            {
                NestingLoops(n - 1, loopNumber, vector + " " + (counter += 1));
            }
        }
    }
}
