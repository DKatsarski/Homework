﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.TextToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            string inputText = Console.ReadLine();
            string[] kofa = new string[inputText.Length];
            int result = 0;

           
            for (int i = 0; i < kofa.Length; i++)
            {
                switch (kofa.Contains)
                {
                    case "0": result += 0; break;
                    case "1": result += 1; break;
                    case "2": result += 2; break;
                    case "3": result += 3; break;
                    case "4": result += 4; break;
                    case "5": result += 5; break;
                    case "6": result += 6; break;
                    case "7": result += 7; break;
                    case "8": result += 8; break;
                    case "9": result += 9; break;
                    case "A": result += 0; break;
                    case "B": result += 1; break;
                    case "C": result += 2; break;
                    case "D": result += 3; break;
                    case "E": result += 4; break;
                    case "F": result += 5; break;
                    case "G": result += 6; break;
                    case "H": result += 7; break;
                    case "I": result += 8; break;
                    case "J": result += 9; break;
                    case "K": result += 10; break;
                    case "L": result += 11; break;
                    case "M": result += 12; break;
                    case "N": result += 13; break;
                    case "O": result += 14; break;
                    case "P": result += 15; break;
                    case "Q": result += 16; break;
                    case "R": result += 17; break;
                    case "S": result += 18; break;
                    case "T": result += 19; break;
                    case "U": result += 20; break;
                    case "V": result += 21; break;
                    case "W": result += 22; break;
                    case "X": result += 23; break;
                    case "Y": result += 24; break;
                    case "Z": result += 25; break;
                    case "a": result += 0; break;
                    case "b": result += 1; break;
                    case "c": result += 2; break;
                    case "d": result += 3; break;
                    case "e": result += 4; break;
                    case "f": result += 5; break;
                    case "g": result += 6; break;
                    case "h": result += 7; break;
                    case "i": result += 8; break;
                    case "j": result += 9; break;
                    case "k": result += 10; break;
                    case "l": result += 11; break;
                    case "m": result += 12; break;
                    case "n": result += 13; break;
                    case "o": result += 14; break;
                    case "p": result += 15; break;
                    case "q": result += 16; break;
                    case "r": result += 17; break;
                    case "s": result += 18; break;
                    case "t": result += 19; break;
                    case "u": result += 20; break;
                    case "v": result += 21; break;
                    case "w": result += 22; break;
                    case "x": result += 23; break;
                    case "y": result += 24; break;
                    case "z": result += 25; break;
                    case "@": Console.WriteLine(result); break;

                    default: result %= m;
                        break;
                }
                Console.WriteLine(result);
            }
          

        }
    }
}
