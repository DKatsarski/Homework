using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.KotTakoa
{
    class Program
    {
        static void Main(string[] args)
        {
            //remove all spaces 
            int n = int.Parse(Console.ReadLine());
            string[] lines = new string[n];
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = Console.ReadLine();
            }

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i][i] == '"')
                {
                    while (lines[i][i] != '"')
                    {
                        i++;
                    }
                }
                else
                {

                    lines[i] = lines[i].Replace(" ", "");
                    lines[i] = lines[i].Replace("var", "var ");
                    lines[i] = lines[i].Replace("int", "int ");
                    lines[i] = lines[i].Replace("string", "string ");
                    lines[i] = lines[i].Replace("System", "System ");
                    lines[i] = lines[i].Replace("class", "class ");
                    lines[i] = lines[i].Replace("using", "using ");
                    lines[i] = lines[i].Replace("static", "static ");
                    lines[i] = lines[i].Replace("var", "var ");
                    lines[i] = lines[i].Replace("var", "var ");
                    lines[i] = lines[i].Replace("var", "var ");
                    lines[i] = lines[i].Replace("var", "var ");
                    lines[i] = lines[i].Replace("var", "var ");
                    lines[i] = lines[i].Replace("var", "var ");
                }
            }

            for (int i = 0; i < lines.Length; i++)
            {
                result.Append(lines[i]);
            }
            Console.WriteLine(result);
        }
    }
}
