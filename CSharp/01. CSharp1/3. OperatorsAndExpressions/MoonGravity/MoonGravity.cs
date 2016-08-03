using System;

namespace MoonGravity
{
    class MoonGravity
    {
        static void Main(string[] args)
        {
            float w = float.Parse(Console.ReadLine());
            float moonWeight = (w * 0.17f);
           
            Console.WriteLine("{0:F3}", moonWeight);
            Console.ReadLine();

        }
    }
}
