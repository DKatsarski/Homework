using System;


namespace _11.BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();   
            var dec = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[s.Length - i - 1] == '0') continue;
                dec += (int)Math.Pow(2, i);
            }
            Console.WriteLine(dec);


        }
    }
}
