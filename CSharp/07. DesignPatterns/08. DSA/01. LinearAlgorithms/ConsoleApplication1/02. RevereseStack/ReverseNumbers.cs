using System;
using System.Collections.Generic;

namespace _02.RevereseStack
{
    class ReverseNumbers
    {
        static void Main()
        {
            Stack<int> stack = new Stack<int>();
            string input = string.Empty;

            while (true)
            {
                input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    break;
                }

                stack.Push(int.Parse(input));
            }

            var resulstList = new List<int>();

            while (stack.Count > 0)
            {
                resulstList.Add(stack.Pop());
            }

            Console.WriteLine(string.Join(" ", resulstList));
        }
    }
}
