using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();
           
            long result = 0;
            text = text.ToLower();

            for (int i = 0; i < text.Length; i++)
            {
                char ch = text[i];

                if (ch == '@')
                {
                   
                    break;
                }
                else if ('0' <= ch && ch <= '9')
                {
                    result *= (ch - '0');
                }
                else if ('a' <= ch  && ch <= 'z')
                {
                    result += (ch - 'a');
                }
                else
                {
                    result %= number;
                }
                


            }
            Console.WriteLine(result);

        }
    }
}
