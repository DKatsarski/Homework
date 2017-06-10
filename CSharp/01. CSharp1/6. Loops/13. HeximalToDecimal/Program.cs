using System;


namespace _11.BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            var hex = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[s.Length - i - 1] == '0') continue;
                hex += (int)Math.Pow(16, i);
                if (s[s.Length - i - 1] == 'A')
                {
                    hex += (int)Math.Pow(16, i);
                }
                    
            }
            Console.WriteLine(hex);
            Console.WriteLine("op");


        }
    }
}
