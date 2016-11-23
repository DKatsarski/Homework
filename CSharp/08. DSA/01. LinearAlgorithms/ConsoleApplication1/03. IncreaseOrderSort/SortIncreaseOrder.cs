using System;
using System.Collections.Generic;

namespace _03.IncreaseOrderSort
{
    class SortIncreaseOrder
    {
        static void Main()
        {
            var list = new List<int>();

            string input = string.Empty;

            while (true)
            {
                input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    break;
                }

                list.Add(int.Parse(input));
            }

            list.Sort();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
