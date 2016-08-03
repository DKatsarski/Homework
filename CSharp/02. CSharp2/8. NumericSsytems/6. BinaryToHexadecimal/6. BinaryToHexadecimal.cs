using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.HexadecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            n = n.ToUpper();
            int count = 1;
            List<string> list = new List<string>();
            if (n.Length < 4 )
            {
                 n = n.PadLeft(4, '0');
            }
            else if (n.Length % 2 != 0)
            {
                while (n.Length % 4 != 0)
                {
                    n = n.PadLeft(count, '0');
                    count++;
                }
            }


            for (int i = 0; i < n.Length - 3; i += 4)
            {
                string helper = n[i].ToString() + n[i + 1].ToString() + n[i + 2].ToString() + n[i + 3].ToString();


                switch (helper)
                {

                    case "0000": list.Add("0"); break;
                    case "0001": list.Add("1"); break;
                    case "0010": list.Add("2"); break;
                    case "0011": list.Add("3"); break;
                    case "0100": list.Add("4"); break;
                    case "0101": list.Add("5"); break;
                    case "0110": list.Add("6"); break;
                    case "0111": list.Add("7"); break;
                    case "1000": list.Add("8"); break;
                    case "1001": list.Add("9"); break;
                    case "1010": list.Add("A"); break;
                    case "1011": list.Add("B"); break;
                    case "1100": list.Add("C"); break;
                    case "1101": list.Add("D"); break;
                    case "1110": list.Add("E"); break;
                    case "1111": list.Add("F"); break;

                    default:
                        ;
                        break;
                }
            }

            for (int i = 0; i < list.Count; i++)
            {

                Console.Write(list.ElementAt(i));
            }
            Console.ReadLine();
        }
    }
}
