using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramThatRemovesAllNegatives
{
    public class RemoveNegatives
    {
        static void Main()
        {
            string input = string.Empty;
            var list = new List<int>();

            while (true)
            {
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    break;
                }

                list.Add(int.Parse(input));
            }

            var resultList = new List<int>();

            foreach (var item in list)
            {
                if (item >= 0)
                {
                    resultList.Add(item);
                }
            }

            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
