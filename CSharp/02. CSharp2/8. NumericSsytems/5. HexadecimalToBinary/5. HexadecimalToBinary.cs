using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.HexadecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            List<string> list = new List<string>();

            for (int i = 0; i < n.Length; i++)
            {
                char helper = n[i];

                switch (helper)
                {

                    case '0': list.Add("0000"); break;
                    case '1': list.Add("0001"); break;
                    case '2': list.Add("0010"); break;
                    case '3': list.Add("0011"); break;
                    case '4': list.Add("0100"); break;
                    case '5': list.Add("0101"); break;
                    case '6': list.Add("0110"); break;
                    case '7': list.Add("0111"); break;
                    case '8': list.Add("1000"); break;
                    case '9': list.Add("1001"); break;
                    case 'A': list.Add("1010"); break;
                    case 'B': list.Add("1011"); break;
                    case 'C': list.Add("1100"); break;
                    case 'D': list.Add("1101"); break;
                    case 'E': list.Add("1110"); break;
                    case 'F': list.Add("1111"); break;
                        
                    default:;
                        break;
                }
            }

            Console.Write(list.ElementAt(0).TrimStart('0'));
            for (int i = 1; i < list.Count; i++)
            {
                 
                Console.Write(list.ElementAt(i));
            }
            Console.ReadLine();
        }
    }
}
