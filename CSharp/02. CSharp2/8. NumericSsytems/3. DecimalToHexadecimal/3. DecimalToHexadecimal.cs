using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _3.DecimalToHexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            while (n != 0)
            {
                BigInteger helper = n % 16;
                string helperOne = helper.ToString();
                if (n % 16 >= 10 && n % 16 <= 15)
                {
                    switch (helperOne)
                    {
                        case "10": list.Add("A"); break;
                        case "11": list.Add("B"); break;
                        case "12": list.Add("C"); break;
                        case "13": list.Add("D"); break;
                        case "14": list.Add("E"); break;
                        case "15": list.Add("F"); break;

                        default:
                            break;
                    }
                }
                else
                {
                    list.Add(helperOne);
                }
                n /= 16;

            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list.ElementAt(list.Count - i - 1));
            }
            Console.ReadLine();

        }
    }
}
