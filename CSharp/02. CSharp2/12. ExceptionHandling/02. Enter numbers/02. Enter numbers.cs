using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Enter_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sb = new List<int>();
            FillStringBuilder(sb);
            bool tester = false;
            for (int i = 0; i < sb.Count - 1; i++)
            {

                if (sb[i] < sb[i + 1])
                {
                    tester = true;
                }
                else
                {
                    tester = false;
                    Console.WriteLine("Exception");
                    break;
                }
            }
            if (tester == true)
            {
                PrintStringBuilder(sb);
            }
            
            
            


        }

        static void FillStringBuilder(List<int> sb)
        {
            string input = string.Empty;

            for (int i = 0; i < 10; i++)
            {
                input = Console.ReadLine();
                sb.Add(int.Parse(input));
            }
        }

        static void PrintStringBuilder(List<int> sb)
        {
            Console.Write("0 < ");
            for (int i = 0; i < sb.Count; i++)
            {

                Console.Write("{0} < ", sb[i]);
            }
            Console.WriteLine("100");
        }

     
      
    }
}
