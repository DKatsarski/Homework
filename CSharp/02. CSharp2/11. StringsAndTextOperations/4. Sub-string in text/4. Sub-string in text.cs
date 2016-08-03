using System;

namespace _4.Sub_string_in_text
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = Console.ReadLine();
            string text = Console.ReadLine();
            int index = text.IndexOf(pattern);
            int count = 0;
            
            while (index != -1)
            {
                count++;
                index = text.IndexOf(pattern, index + 1);
            }
            Console.WriteLine(count);
        }

     
    }
}
